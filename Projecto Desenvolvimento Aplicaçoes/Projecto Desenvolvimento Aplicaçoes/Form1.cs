using System;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class Form1 : Form
    {
        private ModeloIMODAContainer context = null;

        public Form1()
        {
            InitializeComponent();
            context = new ModeloIMODAContainer();
        }

        private void btnGerirClientes_Click(object sender, EventArgs e)
        {
            FormClientes FormClientes = new FormClientes(context);
            FormClientes.ShowDialog();
        }

        private void btnGerirCasas_Click(object sender, EventArgs e)
        {
            FormCasas FormCasas = new FormCasas(context);
            FormCasas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}