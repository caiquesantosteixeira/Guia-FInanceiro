﻿namespace Guia_FInanceiro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargemSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelecom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEletricas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaneamento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(31, 162);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.RowTemplate.Height = 25;
            this.dgvPrincipal.Size = new System.Drawing.Size(982, 332);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(812, 107);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(201, 47);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbTipoEmpresa
            // 
            this.cbTipoEmpresa.FormattingEnabled = true;
            this.cbTipoEmpresa.Location = new System.Drawing.Point(53, 97);
            this.cbTipoEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoEmpresa.Name = "cbTipoEmpresa";
            this.cbTipoEmpresa.Size = new System.Drawing.Size(178, 28);
            this.cbTipoEmpresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
            // 
            // nudYMin
            // 
            this.nudYMin.Location = new System.Drawing.Point(256, 98);
            this.nudYMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudYMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudYMin.Name = "nudYMin";
            this.nudYMin.Size = new System.Drawing.Size(152, 27);
            this.nudYMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(256, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yield mínimo";
            // 
            // nudMargemSeg
            // 
            this.nudMargemSeg.Location = new System.Drawing.Point(431, 98);
            this.nudMargemSeg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudMargemSeg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMargemSeg.Name = "nudMargemSeg";
            this.nudMargemSeg.Size = new System.Drawing.Size(152, 27);
            this.nudMargemSeg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(431, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Margem de segurança";
            // 
            // lblQuantidadeEmpresas
            // 
            this.lblQuantidadeEmpresas.AutoSize = true;
            this.lblQuantidadeEmpresas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeEmpresas.Location = new System.Drawing.Point(416, 498);
            this.lblQuantidadeEmpresas.Name = "lblQuantidadeEmpresas";
            this.lblQuantidadeEmpresas.Size = new System.Drawing.Size(251, 32);
            this.lblQuantidadeEmpresas.TabIndex = 8;
            this.lblQuantidadeEmpresas.Text = "Quantidade Empresas:";
            // 
            // dgvTelecom
            // 
            this.dgvTelecom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelecom.Location = new System.Drawing.Point(1127, 790);
            this.dgvTelecom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTelecom.Name = "dgvTelecom";
            this.dgvTelecom.RowHeadersWidth = 51;
            this.dgvTelecom.RowTemplate.Height = 25;
            this.dgvTelecom.Size = new System.Drawing.Size(493, 120);
            this.dgvTelecom.TabIndex = 9;
            // 
            // dgvEletricas
            // 
            this.dgvEletricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEletricas.Location = new System.Drawing.Point(1127, 263);
            this.dgvEletricas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEletricas.Name = "dgvEletricas";
            this.dgvEletricas.RowHeadersWidth = 51;
            this.dgvEletricas.RowTemplate.Height = 25;
            this.dgvEletricas.Size = new System.Drawing.Size(493, 120);
            this.dgvEletricas.TabIndex = 10;
            // 
            // dgvBancos
            // 
            this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancos.Location = new System.Drawing.Point(1127, 86);
            this.dgvBancos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.RowHeadersWidth = 51;
            this.dgvBancos.RowTemplate.Height = 25;
            this.dgvBancos.Size = new System.Drawing.Size(493, 120);
            this.dgvBancos.TabIndex = 11;
            // 
            // dgvSeguro
            // 
            this.dgvSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguro.Location = new System.Drawing.Point(1127, 616);
            this.dgvSeguro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSeguro.Name = "dgvSeguro";
            this.dgvSeguro.RowHeadersWidth = 51;
            this.dgvSeguro.RowTemplate.Height = 25;
            this.dgvSeguro.Size = new System.Drawing.Size(493, 120);
            this.dgvSeguro.TabIndex = 12;
            // 
            // dgvSaneamento
            // 
            this.dgvSaneamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaneamento.Location = new System.Drawing.Point(1127, 439);
            this.dgvSaneamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSaneamento.Name = "dgvSaneamento";
            this.dgvSaneamento.RowHeadersWidth = 51;
            this.dgvSaneamento.RowTemplate.Height = 25;
            this.dgvSaneamento.Size = new System.Drawing.Size(493, 120);
            this.dgvSaneamento.TabIndex = 13;
            // 
            // lblBancos
            // 
            this.lblBancos.AutoSize = true;
            this.lblBancos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBancos.Location = new System.Drawing.Point(1127, 57);
            this.lblBancos.Name = "lblBancos";
            this.lblBancos.Size = new System.Drawing.Size(72, 25);
            this.lblBancos.TabIndex = 14;
            this.lblBancos.Text = "Bancos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1127, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Elétricas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1127, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saneamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1127, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seguro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1127, 761);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telecom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1081, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 926);
            this.panel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(177, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "RADAR DE OPORTUNIDADE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 587);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(982, 332);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 996);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBancos);
            this.Controls.Add(this.dgvSaneamento);
            this.Controls.Add(this.dgvSeguro);
            this.Controls.Add(this.dgvBancos);
            this.Controls.Add(this.dgvEletricas);
            this.Controls.Add(this.dgvTelecom);
            this.Controls.Add(this.lblQuantidadeEmpresas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMargemSeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudYMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoEmpresa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridView1;
    }
}