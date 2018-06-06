using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormArrendamentos : Form
    {
        public ModeloIMODAContainer context;
        public CasaArrendavel casaSelecionada;

        public FormArrendamentos(ModeloIMODAContainer context, CasaArrendavel casaSelecionada)
        {
            InitializeComponent();
            this.context = context;
            this.casaSelecionada = casaSelecionada;
            listBoxListaArrendamentos.DataSource = casaSelecionada.Arrendamentos.ToList();
            comboBoxArrendatario.DataSource = context.Clientes.ToList();
            
            labelIDCasa.Text = casaSelecionada.IdCasa.ToString();
            labelMorada.Text = casaSelecionada.Localidade;
            labelDonoCasa.Text = casaSelecionada.Proprietario.ToString();

        }

        private void buttonCriarContrato_Click(object sender, System.EventArgs e)
        {
            Arrendamento novoArrendamento = new Arrendamento
            {
                InicioContrato = dateTimePickerInicioContrato.Value,
                DuracaoMeses = int.Parse(numericUpDownDuraçaoArrendamento.Text),
                Renovavel = bool.Parse(checkBoxisRenovavel.Checked.ToString()),
                Arrendatario = (Cliente)comboBoxArrendatario.SelectedItem,
                CasaArrendavel = casaSelecionada
            };

            if (comboBoxArrendatario.SelectedItem.ToString() == labelDonoCasa.Text)
            {
                MessageBox.Show("O proprietário não pode arrendar a sua própria casa", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                context.Arrendamentos.Add(novoArrendamento);
                context.SaveChanges();
                listBoxListaArrendamentos.DataSource = casaSelecionada.Arrendamentos.ToList();
                MessageBox.Show("Arrendamento efetuado com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnRemoverArrendamento_Click(object sender, System.EventArgs e)
        {
            Arrendamento arrendamentoSelecionado = (Arrendamento)listBoxListaArrendamentos.SelectedItem;
            if(arrendamentoSelecionado.CasaArrendavel != null)
            {
                MessageBox.Show("Não pode apagar um arrendamento", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                context.Arrendamentos.Remove(arrendamentoSelecionado);
                context.SaveChanges();
                listBoxListaArrendamentos.DataSource = casaSelecionada.Arrendamentos.ToList();
            }
        }
    }
}