namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCampoDeFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxParametroDeFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.listBoxListaClientesFiltrados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxNIFCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoradaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContactoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxListaCasas = new System.Windows.Forms.ListBox();
            this.listBoxListaArrendamentos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxListaAcquisicoes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCampoDeFiltro
            // 
            this.textBoxCampoDeFiltro.Location = new System.Drawing.Point(12, 30);
            this.textBoxCampoDeFiltro.Name = "textBoxCampoDeFiltro";
            this.textBoxCampoDeFiltro.Size = new System.Drawing.Size(341, 20);
            this.textBoxCampoDeFiltro.TabIndex = 0;
            // 
            // comboBoxParametroDeFiltro
            // 
            this.comboBoxParametroDeFiltro.FormattingEnabled = true;
            this.comboBoxParametroDeFiltro.Location = new System.Drawing.Point(12, 56);
            this.comboBoxParametroDeFiltro.Name = "comboBoxParametroDeFiltro";
            this.comboBoxParametroDeFiltro.Size = new System.Drawing.Size(147, 21);
            this.comboBoxParametroDeFiltro.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(165, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(188, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // listBoxListaClientesFiltrados
            // 
            this.listBoxListaClientesFiltrados.FormattingEnabled = true;
            this.listBoxListaClientesFiltrados.Location = new System.Drawing.Point(12, 87);
            this.listBoxListaClientesFiltrados.Name = "listBoxListaClientesFiltrados";
            this.listBoxListaClientesFiltrados.Size = new System.Drawing.Size(341, 524);
            this.listBoxListaClientesFiltrados.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxListaAcquisicoes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBoxListaArrendamentos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listBoxListaCasas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxContactoCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMoradaCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNIFCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNomeCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(359, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 581);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(53, 32);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // textBoxNIFCliente
            // 
            this.textBoxNIFCliente.Location = new System.Drawing.Point(53, 58);
            this.textBoxNIFCliente.Name = "textBoxNIFCliente";
            this.textBoxNIFCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxNIFCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIF: ";
            // 
            // textBoxMoradaCliente
            // 
            this.textBoxMoradaCliente.Location = new System.Drawing.Point(53, 84);
            this.textBoxMoradaCliente.Name = "textBoxMoradaCliente";
            this.textBoxMoradaCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxMoradaCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morada:";
            // 
            // textBoxContactoCliente
            // 
            this.textBoxContactoCliente.Location = new System.Drawing.Point(53, 110);
            this.textBoxContactoCliente.Name = "textBoxContactoCliente";
            this.textBoxContactoCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxContactoCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contato:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Casas:";
            // 
            // listBoxListaCasas
            // 
            this.listBoxListaCasas.FormattingEnabled = true;
            this.listBoxListaCasas.Location = new System.Drawing.Point(6, 206);
            this.listBoxListaCasas.Name = "listBoxListaCasas";
            this.listBoxListaCasas.Size = new System.Drawing.Size(266, 108);
            this.listBoxListaCasas.TabIndex = 11;
            // 
            // listBoxListaArrendamentos
            // 
            this.listBoxListaArrendamentos.FormattingEnabled = true;
            this.listBoxListaArrendamentos.Location = new System.Drawing.Point(6, 337);
            this.listBoxListaArrendamentos.Name = "listBoxListaArrendamentos";
            this.listBoxListaArrendamentos.Size = new System.Drawing.Size(266, 108);
            this.listBoxListaArrendamentos.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Arrendamentos:";
            // 
            // listBoxListaAcquisicoes
            // 
            this.listBoxListaAcquisicoes.FormattingEnabled = true;
            this.listBoxListaAcquisicoes.Location = new System.Drawing.Point(6, 473);
            this.listBoxListaAcquisicoes.Name = "listBoxListaAcquisicoes";
            this.listBoxListaAcquisicoes.Size = new System.Drawing.Size(266, 108);
            this.listBoxListaAcquisicoes.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aquisiçoes: ";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxListaClientesFiltrados);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.comboBoxParametroDeFiltro);
            this.Controls.Add(this.textBoxCampoDeFiltro);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCampoDeFiltro;
        private System.Windows.Forms.ComboBox comboBoxParametroDeFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListBox listBoxListaClientesFiltrados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxListaCasas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxContactoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMoradaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNIFCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.ListBox listBoxListaAcquisicoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxListaArrendamentos;
        private System.Windows.Forms.Label label6;
    }
}