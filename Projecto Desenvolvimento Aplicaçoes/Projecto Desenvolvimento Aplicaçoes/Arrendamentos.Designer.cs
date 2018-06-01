namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class Arrendamentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIDCasa = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelDonoCasa = new System.Windows.Forms.Label();
            this.listBoxListaArrendamentos = new System.Windows.Forms.ListBox();
            this.btnRemoverArrendamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDuraçaoArrendamento = new System.Windows.Forms.NumericUpDown();
            this.checkBoxisRenovavel = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxlistaClientes = new System.Windows.Forms.ComboBox();
            this.buttonCriarContrato = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuraçaoArrendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casa:";
            // 
            // labelIDCasa
            // 
            this.labelIDCasa.AutoSize = true;
            this.labelIDCasa.Location = new System.Drawing.Point(52, 26);
            this.labelIDCasa.Name = "labelIDCasa";
            this.labelIDCasa.Size = new System.Drawing.Size(45, 13);
            this.labelIDCasa.TabIndex = 1;
            this.labelIDCasa.Text = "ID Casa";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(52, 39);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(43, 13);
            this.labelMorada.TabIndex = 2;
            this.labelMorada.Text = "Morada";
            // 
            // labelDonoCasa
            // 
            this.labelDonoCasa.AutoSize = true;
            this.labelDonoCasa.Location = new System.Drawing.Point(52, 52);
            this.labelDonoCasa.Name = "labelDonoCasa";
            this.labelDonoCasa.Size = new System.Drawing.Size(60, 13);
            this.labelDonoCasa.TabIndex = 3;
            this.labelDonoCasa.Text = "Dono Casa";
            // 
            // listBoxListaArrendamentos
            // 
            this.listBoxListaArrendamentos.FormattingEnabled = true;
            this.listBoxListaArrendamentos.Location = new System.Drawing.Point(12, 68);
            this.listBoxListaArrendamentos.Name = "listBoxListaArrendamentos";
            this.listBoxListaArrendamentos.Size = new System.Drawing.Size(264, 186);
            this.listBoxListaArrendamentos.TabIndex = 4;
            // 
            // btnRemoverArrendamento
            // 
            this.btnRemoverArrendamento.Location = new System.Drawing.Point(12, 265);
            this.btnRemoverArrendamento.Name = "btnRemoverArrendamento";
            this.btnRemoverArrendamento.Size = new System.Drawing.Size(264, 23);
            this.btnRemoverArrendamento.TabIndex = 5;
            this.btnRemoverArrendamento.Text = "Remover";
            this.btnRemoverArrendamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCriarContrato);
            this.groupBox1.Controls.Add(this.comboBoxlistaClientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxisRenovavel);
            this.groupBox1.Controls.Add(this.numericUpDownDuraçaoArrendamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerInicioContrato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(283, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 287);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio do Contrato:";
            // 
            // dateTimePickerInicioContrato
            // 
            this.dateTimePickerInicioContrato.Location = new System.Drawing.Point(10, 58);
            this.dateTimePickerInicioContrato.Name = "dateTimePickerInicioContrato";
            this.dateTimePickerInicioContrato.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicioContrato.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duração (meses):";
            // 
            // numericUpDownDuraçaoArrendamento
            // 
            this.numericUpDownDuraçaoArrendamento.Location = new System.Drawing.Point(10, 102);
            this.numericUpDownDuraçaoArrendamento.Name = "numericUpDownDuraçaoArrendamento";
            this.numericUpDownDuraçaoArrendamento.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownDuraçaoArrendamento.TabIndex = 3;
            this.numericUpDownDuraçaoArrendamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxisRenovavel
            // 
            this.checkBoxisRenovavel.AutoSize = true;
            this.checkBoxisRenovavel.Location = new System.Drawing.Point(10, 129);
            this.checkBoxisRenovavel.Name = "checkBoxisRenovavel";
            this.checkBoxisRenovavel.Size = new System.Drawing.Size(78, 17);
            this.checkBoxisRenovavel.TabIndex = 4;
            this.checkBoxisRenovavel.Text = "Renovável";
            this.checkBoxisRenovavel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Arrendatãrio:";
            // 
            // comboBoxlistaClientes
            // 
            this.comboBoxlistaClientes.FormattingEnabled = true;
            this.comboBoxlistaClientes.Location = new System.Drawing.Point(10, 170);
            this.comboBoxlistaClientes.Name = "comboBoxlistaClientes";
            this.comboBoxlistaClientes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxlistaClientes.TabIndex = 6;
            // 
            // buttonCriarContrato
            // 
            this.buttonCriarContrato.Location = new System.Drawing.Point(10, 197);
            this.buttonCriarContrato.Name = "buttonCriarContrato";
            this.buttonCriarContrato.Size = new System.Drawing.Size(200, 23);
            this.buttonCriarContrato.TabIndex = 7;
            this.buttonCriarContrato.Text = "Inserir";
            this.buttonCriarContrato.UseVisualStyleBackColor = true;
            // 
            // Arrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoverArrendamento);
            this.Controls.Add(this.listBoxListaArrendamentos);
            this.Controls.Add(this.labelDonoCasa);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelIDCasa);
            this.Controls.Add(this.label1);
            this.Name = "Arrendamentos";
            this.Text = "Arrendamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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