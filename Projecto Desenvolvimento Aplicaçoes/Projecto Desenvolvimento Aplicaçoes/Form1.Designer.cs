namespace Projecto_Desenvolvimento_Aplicaçoes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGerirCasas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerirClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerirCasas
            // 
            this.btnGerirCasas.BackgroundImage = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.house;
            this.btnGerirCasas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerirCasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirCasas.Location = new System.Drawing.Point(344, 260);
            this.btnGerirCasas.Name = "btnGerirCasas";
            this.btnGerirCasas.Size = new System.Drawing.Size(306, 273);
            this.btnGerirCasas.TabIndex = 1;
            this.btnGerirCasas.Text = "Gerir Casas";
            this.btnGerirCasas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerirCasas.UseVisualStyleBackColor = true;
            this.btnGerirCasas.Click += new System.EventHandler(this.btnGerirCasas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imo DA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.houseFamily;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGerirClientes
            // 
            this.btnGerirClientes.AutoSize = true;
            this.btnGerirClientes.BackgroundImage = global::Projecto_Desenvolvimento_Aplicaçoes.Properties.Resources.person_icon_1680;
            this.btnGerirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerirClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirClientes.Location = new System.Drawing.Point(12, 260);
            this.btnGerirClientes.Name = "btnGerirClientes";
            this.btnGerirClientes.Size = new System.Drawing.Size(306, 273);
            this.btnGerirClientes.TabIndex = 0;
            this.btnGerirClientes.Text = "Gerir Clientes";
            this.btnGerirClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerirClientes.UseVisualStyleBackColor = true;
            this.btnGerirClientes.Click += new System.EventHandler(this.btnGerirClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerirCasas);
            this.Controls.Add(this.btnGerirClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ImoDa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerirClientes;
        private System.Windows.Forms.Button btnGerirCasas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

