namespace Guia_FInanceiro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbTipoEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudYMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMargemSeg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantidadeEmpresas = new System.Windows.Forms.Label();
            this.dgvTelecom = new System.Windows.Forms.DataGridView();
            this.dgvEletricas = new System.Windows.Forms.DataGridView();
            this.dgvBancos = new System.Windows.Forms.DataGridView();
            this.dgvSeguro = new System.Windows.Forms.DataGridView();
            this.dgvSaneamento = new System.Windows.Forms.DataGridView();
            this.lblBancos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargemSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelecom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEletricas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaneamento)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(17, 74);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.RowTemplate.Height = 25;
            this.dgvPrincipal.Size = new System.Drawing.Size(1303, 245);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(536, 18);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(176, 35);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbTipoEmpresa
            // 
            this.cbTipoEmpresa.FormattingEnabled = true;
            this.cbTipoEmpresa.Location = new System.Drawing.Point(26, 32);
            this.cbTipoEmpresa.Name = "cbTipoEmpresa";
            this.cbTipoEmpresa.Size = new System.Drawing.Size(156, 23);
            this.cbTipoEmpresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
            // 
            // nudYMin
            // 
            this.nudYMin.Location = new System.Drawing.Point(204, 33);
            this.nudYMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudYMin.Name = "nudYMin";
            this.nudYMin.Size = new System.Drawing.Size(133, 23);
            this.nudYMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yield mínimo";
            // 
            // nudMargemSeg
            // 
            this.nudMargemSeg.Location = new System.Drawing.Point(357, 33);
            this.nudMargemSeg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMargemSeg.Name = "nudMargemSeg";
            this.nudMargemSeg.Size = new System.Drawing.Size(133, 23);
            this.nudMargemSeg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(357, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Margem de segurança";
            // 
            // lblQuantidadeEmpresas
            // 
            this.lblQuantidadeEmpresas.AutoSize = true;
            this.lblQuantidadeEmpresas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeEmpresas.Location = new System.Drawing.Point(1108, 32);
            this.lblQuantidadeEmpresas.Name = "lblQuantidadeEmpresas";
            this.lblQuantidadeEmpresas.Size = new System.Drawing.Size(200, 25);
            this.lblQuantidadeEmpresas.TabIndex = 8;
            this.lblQuantidadeEmpresas.Text = "Quantidade Empresas:";
            // 
            // dgvTelecom
            // 
            this.dgvTelecom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelecom.Location = new System.Drawing.Point(1034, 345);
            this.dgvTelecom.Name = "dgvTelecom";
            this.dgvTelecom.RowHeadersWidth = 51;
            this.dgvTelecom.RowTemplate.Height = 25;
            this.dgvTelecom.Size = new System.Drawing.Size(484, 194);
            this.dgvTelecom.TabIndex = 9;
            // 
            // dgvEletricas
            // 
            this.dgvEletricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEletricas.Location = new System.Drawing.Point(17, 345);
            this.dgvEletricas.Name = "dgvEletricas";
            this.dgvEletricas.RowHeadersWidth = 51;
            this.dgvEletricas.RowTemplate.Height = 25;
            this.dgvEletricas.Size = new System.Drawing.Size(484, 194);
            this.dgvEletricas.TabIndex = 10;
            // 
            // dgvBancos
            // 
            this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancos.Location = new System.Drawing.Point(527, 345);
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.RowHeadersVisible = false;
            this.dgvBancos.RowHeadersWidth = 51;
            this.dgvBancos.RowTemplate.Height = 25;
            this.dgvBancos.Size = new System.Drawing.Size(484, 194);
            this.dgvBancos.TabIndex = 11;
            // 
            // dgvSeguro
            // 
            this.dgvSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguro.Location = new System.Drawing.Point(651, 575);
            this.dgvSeguro.Name = "dgvSeguro";
            this.dgvSeguro.RowHeadersWidth = 51;
            this.dgvSeguro.RowTemplate.Height = 25;
            this.dgvSeguro.Size = new System.Drawing.Size(625, 194);
            this.dgvSeguro.TabIndex = 12;
            // 
            // dgvSaneamento
            // 
            this.dgvSaneamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaneamento.Location = new System.Drawing.Point(17, 575);
            this.dgvSaneamento.Name = "dgvSaneamento";
            this.dgvSaneamento.RowHeadersWidth = 51;
            this.dgvSaneamento.RowTemplate.Height = 25;
            this.dgvSaneamento.Size = new System.Drawing.Size(617, 194);
            this.dgvSaneamento.TabIndex = 13;
            // 
            // lblBancos
            // 
            this.lblBancos.AutoSize = true;
            this.lblBancos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBancos.Location = new System.Drawing.Point(527, 322);
            this.lblBancos.Name = "lblBancos";
            this.lblBancos.Size = new System.Drawing.Size(56, 20);
            this.lblBancos.TabIndex = 14;
            this.lblBancos.Text = "Bancos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Elétricas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saneamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(651, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seguro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1034, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telecom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dgvPrincipal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudMargemSeg);
            this.panel2.Controls.Add(this.dgvTelecom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nudYMin);
            this.panel2.Controls.Add(this.lblQuantidadeEmpresas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvSaneamento);
            this.panel2.Controls.Add(this.cbTipoEmpresa);
            this.panel2.Controls.Add(this.dgvBancos);
            this.panel2.Controls.Add(this.dgvSeguro);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Controls.Add(this.dgvEletricas);
            this.panel2.Controls.Add(this.lblBancos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(10, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1933, 803);
            this.panel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1955, 834);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargemSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelecom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEletricas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaneamento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnAtualizar;
        private ComboBox cbTipoEmpresa;
        private Label label1;
        private NumericUpDown nudYMin;
        private Label label2;
        private NumericUpDown nudMargemSeg;
        private Label label3;
        private Label lblQuantidadeEmpresas;
        private DataGridView dgvTelecom;
        private DataGridView dgvEletricas;
        private DataGridView dgvBancos;
        private DataGridView dgvSeguro;
        private DataGridView dgvSaneamento;
        private Label lblBancos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label10;
    }
}