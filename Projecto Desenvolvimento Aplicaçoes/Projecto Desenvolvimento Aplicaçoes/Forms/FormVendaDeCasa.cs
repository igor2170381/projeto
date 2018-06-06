using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormVenda_de_Casa : Form
    {
        public ModeloIMODAContainer context;
        public CasaVendavel casaSelecionada;
        

        public FormVenda_de_Casa(ModeloIMODAContainer context, CasaVendavel casaSelecionada)
        {
            InitializeComponent();

            this.context = context;
            this.casaSelecionada = casaSelecionada;
            comboBoxComprador.DataSource = context.Clientes.ToList();

            labelProprietário.Text = casaSelecionada.Proprietario.ToString();
            labelValorBaseVenda.Text = casaSelecionada.ValorBaseVenda.ToString() + " €";
            labelValorComissao.Text = casaSelecionada.ValorComissao.ToString() + " €";


            if (casaSelecionada.Venda == null)
            {
                dateTimePickerDatadaVenda.Enabled = true;
                textBoxValorNegociado.Enabled = true;
                textBoxValorComissao.Enabled = true;
                comboBoxComprador.Enabled = true;
                buttonEfetivarVenda.Enabled = true;
                labelEstadoDeVenda.Text = "Em curso";
            }
            else
            {
                dateTimePickerDatadaVenda.Enabled = false;
                textBoxValorNegociado.Enabled = false;
                textBoxValorComissao.Enabled = false;
                comboBoxComprador.Enabled = false;
                buttonEfetivarVenda.Enabled = false;
                labelEstadoDeVenda.Text = "Vendida";
            }
        }

        private void buttonEfetivarVenda_Click(object sender, System.EventArgs e)
        {
            Venda novaVenda = new Venda
            {
                DataVenda = dateTimePickerDatadaVenda.Value,
                ValorNegociado = int.Parse(textBoxValorNegociado.Text),
                ComissaoNegociada = int.Parse(textBoxValorComissao.Text),
                Comprador = (Cliente)comboBoxComprador.SelectedItem,
                CasaVendavel = casaSelecionada
            };

            
            if (comboBoxComprador.SelectedItem.ToString() == labelProprietário.Text)
            {
                MessageBox.Show("O proprietário não pode comprar a sua própria casa", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                context.Vendas.Add(novaVenda);
                context.SaveChanges();
                dateTimePickerDatadaVenda.Enabled = false;
                textBoxValorNegociado.Enabled = false;
                textBoxValorComissao.Enabled = false;
                comboBoxComprador.Enabled = false;
                buttonEfetivarVenda.Enabled = false;
                labelEstadoDeVenda.Text = "Vendida";
                MessageBox.Show("Venda efetuada com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

           
        }
    }
}