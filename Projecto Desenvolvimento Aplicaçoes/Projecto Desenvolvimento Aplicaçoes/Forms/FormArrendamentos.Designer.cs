namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class FormArrendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArrendamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.labelIDCasa = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelDonoCasa = new System.Windows.Forms.Label();
            this.listBoxListaArrendamentos = new System.Windows.Forms.ListBox();
            this.btnRemoverArrendamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCriarContrato = new System.Windows.Forms.Button();
            this.comboBoxlistaClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxisRenovavel = new System.Windows.Forms.CheckBox();
            this.numericUpDownDuraçaoArrendamento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuraçaoArrendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casa:";
            // 
            // labelIDCasa
            // 
            this.labelIDCasa.AutoSize = true;
            this.labelIDCasa.Location = new System.Drawing.Point(52, 19);
            this.labelIDCasa.Name = "labelIDCasa";
            this.labelIDCasa.Size = new System.Drawing.Size(45, 13);
            this.labelIDCasa.TabIndex = 1;
            this.labelIDCasa.Text = "ID Casa";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(52, 32);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(43, 13);
            this.labelMorada.TabIndex = 2;
            this.labelMorada.Text = "Morada";
            // 
            // labelDonoCasa
            // 
            this.labelDonoCasa.AutoSize = true;
            this.labelDonoCasa.Location = new System.Drawing.Point(52, 45);
            this.labelDonoCasa.Name = "labelDonoCasa";
            this.labelDonoCasa.Size = new System.Drawing.Size(60, 13);
            this.labelDonoCasa.TabIndex = 3;
            this.labelDonoCasa.Text = "Dono Casa";
            // 
            // listBoxListaArrendamentos
            // 
            this.listBoxListaArrendamentos.FormattingEnabled = true;
            this.listBoxListaArrendamentos.Location = new System.Drawing.Point(3, 68);
            this.listBoxListaArrendamentos.Name = "listBoxListaArrendamentos";
            this.listBoxListaArrendamentos.Size = new System.Drawing.Size(324, 277);
            this.listBoxListaArrendamentos.TabIndex = 4;
            // 
            // btnRemoverArrendamento
            // 
            this.btnRemoverArrendamento.Location = new System.Drawing.Point(3, 353);
            this.btnRemoverArrendamento.Name = "btnRemoverArrendamento";
            this.btnRemoverArrendamento.Size = new System.Drawing.Size(324, 23);
            this.btnRemoverArrendamento.TabIndex = 5;
            this.btnRemoverArrendamento.Text = "Remover";
            this.btnRemoverArrendamento.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.houseFamily;
            this.pictureBox1.Location = new System.Drawing.Point(535, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCriarContrato
            // 
            this.buttonCriarContrato.Location = new System.Drawing.Point(369, 276);
            this.buttonCriarContrato.Name = "buttonCriarContrato";
            this.buttonCriarContrato.Size = new System.Drawing.Size(200, 23);
            this.buttonCriarContrato.TabIndex = 17;
            this.buttonCriarContrato.Text = "Inserir";
            this.buttonCriarContrato.UseVisualStyleBackColor = true;
            // 
            // comboBoxlistaClientes
            // 
            this.comboBoxlistaClientes.FormattingEnabled = true;
            this.comboBoxlistaClientes.Location = new System.Drawing.Point(369, 249);
            this.comboBoxlistaClientes.Name = "comboBoxlistaClientes";
            this.comboBoxlistaClientes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxlistaClientes.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Arrendatário:";
            // 
            // checkBoxisRenovavel
            // 
            this.checkBoxisRenovavel.AutoSize = true;
            this.checkBoxisRenovavel.Location = new System.Drawing.Point(369, 208);
            this.checkBoxisRenovavel.Name = "checkBoxisRenovavel";
            this.checkBoxisRenovavel.Size = new System.Drawing.Size(78, 17);
            this.checkBoxisRenovavel.TabIndex = 14;
            this.checkBoxisRenovavel.Text = "Renovável";
            this.checkBoxisRenovavel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDuraçaoArrendamento
            // 
            this.numericUpDownDuraçaoArrendamento.Location = new System.Drawing.Point(369, 181);
            this.numericUpDownDuraçaoArrendamento.Name = "numericUpDownDuraçaoArrendamento";
            this.numericUpDownDuraçaoArrendamento.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownDuraçaoArrendamento.TabIndex = 13;
            this.numericUpDownDuraçaoArrendamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duração (meses):";
            // 
            // dateTimePickerInicioContrato
            // 
            this.dateTimePickerInicioContrato.Location = new System.Drawing.Point(369, 137);
            this.dateTimePickerInicioContrato.Name = "dateTimePickerInicioContrato";
            this.dateTimePickerInicioContrato.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicioContrato.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inicio do Contrato:";
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 386);
            this.Controls.Add(this.buttonCriarContrato);
            this.Controls.Add(this.comboBoxlistaClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxisRenovavel);
            this.Controls.Add(this.numericUpDownDuraçaoArrendamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerInicioContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoverArrendamento);
            this.Controls.Add(this.listBoxListaArrendamentos);
            this.Controls.Add(this.labelDonoCasa);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelIDCasa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormArrendamentos";
            this.Text = "Arrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuraçaoArrendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIDCasa;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelDonoCasa;
        private System.Windows.Forms.ListBox listBoxListaArrendamentos;
        private System.Windows.Forms.Button btnRemoverArrendamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCriarContrato;
        private System.Windows.Forms.ComboBox comboBoxlistaClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxisRenovavel;
        private System.Windows.Forms.NumericUpDown numericUpDownDuraçaoArrendamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicioContrato;
        private System.Windows.Forms.Label label2;
    }
}