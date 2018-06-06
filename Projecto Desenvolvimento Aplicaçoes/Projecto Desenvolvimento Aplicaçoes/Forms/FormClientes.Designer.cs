namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.textBoxCampoDeFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxParametroDeFiltro = new System.Windows.Forms.ComboBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.groupBoxDetalhesClientes = new System.Windows.Forms.GroupBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.BindingSourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNIFCliente = new System.Windows.Forms.TextBox();
            this.textBoxMoradaCliente = new System.Windows.Forms.TextBox();
            this.textBoxContactoCliente = new System.Windows.Forms.TextBox();
            this.listBoxListaAquisicoes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxListaArrendamentos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxListaCasas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCriarCliente = new System.Windows.Forms.Button();
            this.buttonGuardarDadosCliente = new System.Windows.Forms.Button();
            this.buttonApagarCliente = new System.Windows.Forms.Button();
            this.DataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            contactoLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            this.groupBoxDetalhesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            contactoLabel.Location = new System.Drawing.Point(20, 100);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 16;
            contactoLabel.Text = "Contacto:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            moradaLabel.Location = new System.Drawing.Point(26, 74);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 17;
            moradaLabel.Text = "Morada:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            nIFLabel.Location = new System.Drawing.Point(40, 48);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 18;
            nIFLabel.Text = "NIF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            nomeLabel.Location = new System.Drawing.Point(29, 22);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome:";
            // 
            // textBoxCampoDeFiltro
            // 
            this.textBoxCampoDeFiltro.Location = new System.Drawing.Point(16, 12);
            this.textBoxCampoDeFiltro.Name = "textBoxCampoDeFiltro";
            this.textBoxCampoDeFiltro.Size = new System.Drawing.Size(307, 20);
            this.textBoxCampoDeFiltro.TabIndex = 0;
            this.textBoxCampoDeFiltro.TextChanged += new System.EventHandler(this.textBoxCampoDeFiltro_TextChanged);
            // 
            // comboBoxParametroDeFiltro
            // 
            this.comboBoxParametroDeFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParametroDeFiltro.Items.AddRange(new object[] {
            "Nome",
            "NIF",
            "Contacto",
            "Morada"});
            this.comboBoxParametroDeFiltro.Location = new System.Drawing.Point(16, 38);
            this.comboBoxParametroDeFiltro.Name = "comboBoxParametroDeFiltro";
            this.comboBoxParametroDeFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParametroDeFiltro.TabIndex = 2;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFiltrar.Location = new System.Drawing.Point(143, 38);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(80, 21);
            this.buttonFiltrar.TabIndex = 3;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // groupBoxDetalhesClientes
            // 
            this.groupBoxDetalhesClientes.Controls.Add(nomeLabel);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxDetalhesClientes.Controls.Add(nIFLabel);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxNIFCliente);
            this.groupBoxDetalhesClientes.Controls.Add(moradaLabel);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxMoradaCliente);
            this.groupBoxDetalhesClientes.Controls.Add(contactoLabel);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxContactoCliente);
            this.groupBoxDetalhesClientes.Controls.Add(this.listBoxListaAquisicoes);
            this.groupBoxDetalhesClientes.Controls.Add(this.label7);
            this.groupBoxDetalhesClientes.Controls.Add(this.listBoxListaArrendamentos);
            this.groupBoxDetalhesClientes.Controls.Add(this.label6);
            this.groupBoxDetalhesClientes.Controls.Add(this.listBoxListaCasas);
            this.groupBoxDetalhesClientes.Controls.Add(this.label5);
            this.groupBoxDetalhesClientes.Controls.Add(this.buttonCriarCliente);
            this.groupBoxDetalhesClientes.Controls.Add(this.buttonGuardarDadosCliente);
            this.groupBoxDetalhesClientes.Location = new System.Drawing.Point(368, 102);
            this.groupBoxDetalhesClientes.Name = "groupBoxDetalhesClientes";
            this.groupBoxDetalhesClientes.Size = new System.Drawing.Size(316, 525);
            this.groupBoxDetalhesClientes.TabIndex = 5;
            this.groupBoxDetalhesClientes.TabStop = false;
            this.groupBoxDetalhesClientes.Text = "Detalhes";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCliente, "Nome", true));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(73, 19);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // BindingSourceCliente
            // 
            this.BindingSourceCliente.DataSource = typeof(Projecto_Desenvolvimento_Aplicaçoes.Cliente);
            // 
            // textBoxNIFCliente
            // 
            this.textBoxNIFCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCliente, "NIF", true));
            this.textBoxNIFCliente.Location = new System.Drawing.Point(73, 45);
            this.textBoxNIFCliente.Name = "textBoxNIFCliente";
            this.textBoxNIFCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxNIFCliente.TabIndex = 2;
            // 
            // textBoxMoradaCliente
            // 
            this.textBoxMoradaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCliente, "Morada", true));
            this.textBoxMoradaCliente.Location = new System.Drawing.Point(73, 71);
            this.textBoxMoradaCliente.Name = "textBoxMoradaCliente";
            this.textBoxMoradaCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxMoradaCliente.TabIndex = 3;
            // 
            // textBoxContactoCliente
            // 
            this.textBoxContactoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCliente, "Contacto", true));
            this.textBoxContactoCliente.Location = new System.Drawing.Point(73, 97);
            this.textBoxContactoCliente.Name = "textBoxContactoCliente";
            this.textBoxContactoCliente.Size = new System.Drawing.Size(219, 20);
            this.textBoxContactoCliente.TabIndex = 4;
            // 
            // listBoxListaAquisicoes
            // 
            this.listBoxListaAquisicoes.FormattingEnabled = true;
            this.listBoxListaAquisicoes.Location = new System.Drawing.Point(23, 416);
            this.listBoxListaAquisicoes.Name = "listBoxListaAquisicoes";
            this.listBoxListaAquisicoes.Size = new System.Drawing.Size(266, 82);
            this.listBoxListaAquisicoes.TabIndex = 15;
            this.listBoxListaAquisicoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxListaAquisicoes_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(20, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aquisiçoes: ";
            // 
            // listBoxListaArrendamentos
            // 
            this.listBoxListaArrendamentos.FormattingEnabled = true;
            this.listBoxListaArrendamentos.Location = new System.Drawing.Point(23, 302);
            this.listBoxListaArrendamentos.Name = "listBoxListaArrendamentos";
            this.listBoxListaArrendamentos.Size = new System.Drawing.Size(266, 82);
            this.listBoxListaArrendamentos.TabIndex = 13;
            this.listBoxListaArrendamentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxListaArrendamentos_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(20, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Arrendamentos:";
            // 
            // listBoxListaCasas
            // 
            this.listBoxListaCasas.FormattingEnabled = true;
            this.listBoxListaCasas.Location = new System.Drawing.Point(26, 180);
            this.listBoxListaCasas.Name = "listBoxListaCasas";
            this.listBoxListaCasas.Size = new System.Drawing.Size(266, 82);
            this.listBoxListaCasas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Casas:";
            // 
            // buttonCriarCliente
            // 
            this.buttonCriarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCriarCliente.Location = new System.Drawing.Point(217, 123);
            this.buttonCriarCliente.Name = "buttonCriarCliente";
            this.buttonCriarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCriarCliente.TabIndex = 9;
            this.buttonCriarCliente.Text = "Novo";
            this.buttonCriarCliente.UseVisualStyleBackColor = true;
            this.buttonCriarCliente.Click += new System.EventHandler(this.buttonCriarCliente_Click);
            // 
            // buttonGuardarDadosCliente
            // 
            this.buttonGuardarDadosCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuardarDadosCliente.Location = new System.Drawing.Point(73, 123);
            this.buttonGuardarDadosCliente.Name = "buttonGuardarDadosCliente";
            this.buttonGuardarDadosCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarDadosCliente.TabIndex = 8;
            this.buttonGuardarDadosCliente.Text = "Guardar";
            this.buttonGuardarDadosCliente.UseVisualStyleBackColor = true;
            this.buttonGuardarDadosCliente.Click += new System.EventHandler(this.buttonGuardarDadosCliente_Click);
            // 
            // buttonApagarCliente
            // 
            this.buttonApagarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonApagarCliente.Location = new System.Drawing.Point(2, 616);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(344, 25);
            this.buttonApagarCliente.TabIndex = 6;
            this.buttonApagarCliente.Text = "Apagar";
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            this.buttonApagarCliente.Click += new System.EventHandler(this.buttonApagarCliente_Click);
            // 
            // DataGridViewCliente
            // 
            this.DataGridViewCliente.AllowUserToAddRows = false;
            this.DataGridViewCliente.AllowUserToDeleteRows = false;
            this.DataGridViewCliente.AutoGenerateColumns = false;
            this.DataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn});
            this.DataGridViewCliente.DataSource = this.BindingSourceCliente;
            this.DataGridViewCliente.Location = new System.Drawing.Point(2, 65);
            this.DataGridViewCliente.MultiSelect = false;
            this.DataGridViewCliente.Name = "DataGridViewCliente";
            this.DataGridViewCliente.ReadOnly = true;
            this.DataGridViewCliente.Size = new System.Drawing.Size(344, 551);
            this.DataGridViewCliente.TabIndex = 7;
            this.DataGridViewCliente.SelectionChanged += new System.EventHandler(this.DataGridViewCliente_SelectionChanged);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.person_icon_1680;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(565, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGridViewCliente);
            this.Controls.Add(this.buttonApagarCliente);
            this.Controls.Add(this.groupBoxDetalhesClientes);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.comboBoxParametroDeFiltro);
            this.Controls.Add(this.textBoxCampoDeFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.groupBoxDetalhesClientes.ResumeLayout(false);
            this.groupBoxDetalhesClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCampoDeFiltro;
        private System.Windows.Forms.ComboBox comboBoxParametroDeFiltro;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.GroupBox groupBoxDetalhesClientes;
        private System.Windows.Forms.ListBox listBoxListaCasas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCriarCliente;
        private System.Windows.Forms.Button buttonGuardarDadosCliente;
        private System.Windows.Forms.ListBox listBoxListaAquisicoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxListaArrendamentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonApagarCliente;
        private System.Windows.Forms.TextBox textBoxMoradaCliente;
        private System.Windows.Forms.TextBox textBoxContactoCliente;
        private System.Windows.Forms.DataGridView DataGridViewCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxNIFCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource BindingSourceCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
    }
}