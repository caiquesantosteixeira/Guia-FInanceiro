using ClosedXML.Excel;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;

namespace Guia_FInanceiro
{
    public partial class Form1 : Form
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Current Legislators";
        static readonly string SpreadsheetId = "1C6-gPVvM5w9BAFC7vWzuEilIYH87W49hH9719B4JxBw";
        static readonly string sheet = "Planilha Neto";
        static SheetsService service;
        static List<string> _tipos;
        public List<Empresa> _empresas;
        public Form1()
        {
            InitializeComponent();
            InicializarChamadaGoogle();
            InicializarListas();
            InicializarNuds();
            AdicionarColunasFiltroGeral();

            AdicionarColunasBest(dgvBancos);
            AdicionarColunasBest(dgvEletricas);
            AdicionarColunasBest(dgvSaneamento);
            AdicionarColunasBest(dgvSeguro);
            AdicionarColunasBest(dgvTelecom);
        }

        private static void InicializarChamadaGoogle()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("C:\\Users\\caique\\Source\\Repos\\Guia FInanceiro\\Guia FInanceiro\\client_secret.json.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        private void InicializarListas()
        {
            _empresas = new List<Empresa>();
            _tipos = new List<string>();
        }

        private void InicializarNuds()
        {
            nudYMin.Value = 6;
            nudMargemSeg.Value = 0;
        }

        private void AdicionarColunasFiltroGeral()
        {
            dgvPrincipal.Columns.Add("", "linha");
            dgvPrincipal.Columns.Add("", "Cod");
            dgvPrincipal.Columns.Add("", "Nome da Empresa");
            dgvPrincipal.Columns.Add("", "Tipo");
            dgvPrincipal.Columns.Add("", "DY");
            dgvPrincipal.Columns.Add("", "Preço");
            dgvPrincipal.Columns.Add("", "Preço Teto");
            dgvPrincipal.Columns.Add("", "% segurança");

            dgvPrincipal.Columns.Add("", "med. p.");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ReadEntries();
                RunTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private List<Empresa> ReadEntries()
        {
            var range = $"{sheet}!A:U";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            var response = request.Execute();
            IList<IList<object>> values = response.Values;

            var lista = new List<Empresa>();

            if (values != null && values.Count > 0)
            {
                for(var x = 3 ; x < values.Count;x++) 
                {
                    var row = values[x];
                    var empresa = new Empresa();
                    empresa.Cod = row[2].ToString();
                    empresa.NomeEmpresa = row[1].ToString();
                    empresa.Preco = Convert.ToDecimal((row[4]).ToString().Replace("R$",""));
                    empresa.Dy = Convert.ToDecimal(row[14].ToString().Replace("R$", "").Replace("%", ""));
                    empresa.PrecoTeto = Convert.ToDecimal(row[15].ToString().Replace("R$", ""));
                    empresa.PercentualSeguranca = Convert.ToDecimal(row[16].ToString().Replace("R$", "").Replace("%", ""));
                    empresa.Tipo = row[3].ToString();
                    empresa.MediaP = (empresa.Dy + (empresa.PercentualSeguranca * 1.3M)) / 2;
                    lista.Add(empresa);
                    
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            _empresas = lista;
            return lista;
        }

        private List<Empresa> Filtrar(List<Empresa> empresas) 
        {
            var tipo = cbTipoEmpresa.SelectedValue.ToString();
           
            if (tipo != "nenhum") 
            {
                empresas = empresas.Where(a => a.Tipo == tipo).OrderByDescending(a => a.Dy).ToList();
            }
            
            empresas = empresas.Where(b => Convert.ToDecimal(b.Dy) >= nudYMin.Value).OrderByDescending(a => a.Dy).ToList();
        
            empresas = empresas.Where(a => a.PercentualSeguranca > nudMargemSeg.Value).ToList().OrderByDescending(a => a.MediaP).ToList();
            

            return empresas;
        }

        private void TratarTipos() 
        {
            _tipos.Add("nenhum");
            _tipos.AddRange(_empresas.Select(a => a.Tipo).Distinct().ToList());
            cbTipoEmpresa.DataSource = _tipos;
        }

        private void AtualizarGrid(List<Empresa> empresas)
        {
            dgvPrincipal.Rows.Clear();
           
            lblQuantidadeEmpresas.Text = "Quantidade Empresas:" +" : "+ empresas.Count.ToString();

            for (var x = 0; x< empresas.Count;x++)
            {
                dgvPrincipal.Rows.Insert(x,x.ToString(), empresas[x].Cod, empresas[x].NomeEmpresa, empresas[x].Tipo, empresas[x].Dy, empresas[x].Preco, empresas[x].PrecoTeto, empresas[x].PercentualSeguranca, empresas[x].MediaP);
            }
        }

        private void AtualizarGridResumo(DataGridView dgv, List<Empresa> empresas,string tipo)
        {
            empresas = empresas.Where(a => a.Tipo == tipo).ToList();
            dgv.Rows.Clear();

            for (var x = 0; x < empresas.Count; x++)
            {
                
                dgv.Rows.Insert(x,  empresas[x].NomeEmpresa, empresas[x].Dy, empresas[x].Preco, empresas[x].PrecoTeto, empresas[x].PercentualSeguranca);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            InicializarChamadaGoogle();
            RunTasks();
        }

        private void RunTasks()
        {
            TratarTipos();

            var empresas = Filtrar(_empresas);

            AtualizarGrid(empresas);
            PopularResumos();
        }
        private void AdicionarColunasBest(DataGridView dgv)
        {
            dgv.Columns.Add("", "Nome da Empresa");
            dgv.Columns.Add("", "DY");
            dgv.Columns.Add("", "Preço");
            dgv.Columns.Add("", "Preço Teto");
            dgv.Columns.Add("", "% segurança");
            dgv.RowHeadersVisible = false;
        }
        private void PopularResumos()
        {
            var todasEmpresasOrdenadas = _empresas.Where(a => a.PercentualSeguranca>2).OrderByDescending(a => a.PercentualSeguranca).ToList();
            AtualizarGridResumo(dgvBancos, todasEmpresasOrdenadas, "Bancos");
            AtualizarGridResumo(dgvEletricas, todasEmpresasOrdenadas, "Energia");
            AtualizarGridResumo(dgvSaneamento, todasEmpresasOrdenadas, "Saneamento");
            AtualizarGridResumo(dgvSeguro, todasEmpresasOrdenadas, "Seguros");
            AtualizarGridResumo(dgvTelecom, todasEmpresasOrdenadas, "Telecomunicações");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}