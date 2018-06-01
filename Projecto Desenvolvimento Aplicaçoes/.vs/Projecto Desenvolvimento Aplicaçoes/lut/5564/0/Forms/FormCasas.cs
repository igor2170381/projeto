using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormCasas : Form
    {
        //private ModeloIMODAContainer context = new ModeloIMODAContainer();
        public ModeloIMODAContainer context;

        public FormCasas(ModeloIMODAContainer context)
        {
            InitializeComponent();
            this.context = context;

            /*  Cliente cliente = new Cliente();
              IEnumerable<Cliente> getNome = from Cliente in context.Clientes
                                             select Cliente; */

            comboBoxProprietárioDaCasa.DataSource = context.Clientes.ToList();
            //comboBoxProprietárioDaCasa.DisplayMember = "Nome";
            //comboBoxProprietárioDaCasa.ValueMember = "Nome";
            MessageBox.Show(context.Clientes.ToString());
            comboBoxProprietárioDaCasa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonGerirLimpezas_Click(object sender, EventArgs e)
        {
            FormLimpezas FormLimpezas = new FormLimpezas(context);
            FormLimpezas.ShowDialog();
        }

        private void buttonNovaCasa_Click(object sender, EventArgs e)
        {
            
            Casa novaCasa = new Casa
            {
                Localidade = textBoxLocalidadeCasa.Text,
                Rua = textBoxRuaCasa.Text,
                Numero = Int32.Parse(textBoxNumeroCasa.Text),
                Andar = Int32.Parse(textBoxAndarCasa.Text),
                Area = numericUpDownAreaDaCasa.Value,


                //muder decimal -> int os decimais abaixo
                NumeroAssoalhadas = Decimal.ToInt32(numericUpDownAssoalhadasDaCasa.Value),
                NumeroWC = Decimal.ToInt32(numericUpDownWCDaCasa.Value),
                NumeroPisos = Decimal.ToInt32(numericUpDownPisosDaCasa.Value),

                // Tipo =

            };

            context.Casas.Add(novaCasa);

            context.SaveChanges();
        }

        private void buttonGuardarDetalhes_Click(object sender, EventArgs e)
        {

        }
    }
}