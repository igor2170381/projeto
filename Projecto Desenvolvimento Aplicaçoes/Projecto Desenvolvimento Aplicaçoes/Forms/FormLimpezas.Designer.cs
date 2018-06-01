namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class FormLimpezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLimpezas));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxListaLimpezas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxDetalhesLimpeza = new System.Windows.Forms.ListBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInserirLimpezas = new System.Windows.Forms.Button();
            this.numericUpDownQuantidadeLimpezas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoDeServiço = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEmitirFatura = new System.Windows.Forms.Button();
            this.dateTimePickerDataFatura = new System.Windows.Forms.DateTimePicker();
            this.buttonCriarFatura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidadeLimpezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base: ";
            // 
            // listBoxListaLimpezas
            // 
            this.listBoxListaLimpezas.FormattingEnabled = true;
            this.listBoxListaLimpezas.Location = new System.Drawing.Point(12, 46);
            this.listBoxListaLimpezas.Name = "listBoxListaLimpezas";
            this.listBoxListaLimpezas.Size = new System.Drawing.Size(247, 368);
            this.listBoxListaLimpezas.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDetalhesLimpeza);
            this.groupBox1.Controls.Add(this.labelValorUnitario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonInserirLimpezas);
            this.groupBox1.Controls.Add(this.numericUpDownQuantidadeLimpezas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTipoDeServiço);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(265, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Limpeza";
            // 
            // listBoxDetalhesLimpeza
            // 
            this.listBoxDetalhesLimpeza.FormattingEnabled = true;
            this.listBoxDetalhesLimpeza.Location = new System.Drawing.Point(5, 117);
            this.listBoxDetalhesLimpeza.Name = "listBoxDetalhesLimpeza";
            this.listBoxDetalhesLimpeza.Size = new System.Drawing.Size(538, 303);
            this.listBoxDetalhesLimpeza.TabIndex = 7;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.Location = new System.Drawing.Point(102, 78);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(0, 13);
            this.labelValorUnitario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Unitário: ";
            // 
            // buttonInserirLimpezas
            // 
            this.buttonInserirLimpezas.Location = new System.Drawing.Point(434, 26);
            this.buttonInserirLimpezas.Name = "buttonInserirLimpezas";
            this.buttonInserirLimpezas.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirLimpezas.TabIndex = 4;
            this.buttonInserirLimpezas.Text = "Inserir";
            this.buttonInserirLimpezas.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantidadeLimpezas
            // 
            this.numericUpDownQuantidadeLimpezas.Location = new System.Drawing.Point(346, 28);
            this.numericUpDownQuantidadeLimpezas.Name = "numericUpDownQuantidadeLimpezas";
            this.numericUpDownQuantidadeLimpezas.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownQuantidadeLimpezas.TabIndex = 3;
            this.numericUpDownQuantidadeLimpezas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantitade";
            // 
            // comboBoxTipoDeServiço
            // 
            this.comboBoxTipoDeServiço.FormattingEnabled = true;
            this.comboBoxTipoDeServiço.Location = new System.Drawing.Point(78, 27);
            this.comboBoxTipoDeServiço.Name = "comboBoxTipoDeServiço";
            this.comboBoxTipoDeServiço.Size = new System.Drawing.Size(197, 21);
            this.comboBoxTipoDeServiço.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serviço:";
            // 
            // buttonEmitirFatura
            // 
            this.buttonEmitirFatura.Location = new System.Drawing.Point(12, 427);
            this.buttonEmitirFatura.Name = "buttonEmitirFatura";
            this.buttonEmitirFatura.Size = new System.Drawing.Size(246, 23);
            this.buttonEmitirFatura.TabIndex = 3;
            this.buttonEmitirFatura.Text = "Emitir Fatura";
            this.buttonEmitirFatura.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataFatura
            // 
            this.dateTimePickerDataFatura.Location = new System.Drawing.Point(12, 456);
            this.dateTimePickerDataFatura.Name = "dateTimePickerDataFatura";
            this.dateTimePickerDataFatura.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerDataFatura.TabIndex = 4;
            // 
            // buttonCriarFatura
            // 
            this.buttonCriarFatura.Location = new System.Drawing.Point(181, 453);
            this.buttonCriarFatura.Name = "buttonCriarFatura";
            this.buttonCriarFatura.Size = new System.Drawing.Size(77, 23);
            this.buttonCriarFatura.TabIndex = 5;
            this.buttonCriarFatura.Text = "Criar";
            this.buttonCriarFatura.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.clean;
            this.pictureBox1.Location = new System.Drawing.Point(740, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormLimpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCriarFatura);
            this.Controls.Add(this.dateTimePickerDataFatura);
            this.Controls.Add(this.buttonEmitirFatura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxListaLimpezas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLimpezas";
            this.Text = "Limpezas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidadeLimpezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxListaLimpezas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoDeServiço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelValorUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInserirLimpezas;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidadeLimpezas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDetalhesLimpeza;
        private System.Windows.Forms.Button buttonEmitirFatura;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFatura;
        private System.Windows.Forms.Button buttonCriarFatura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}