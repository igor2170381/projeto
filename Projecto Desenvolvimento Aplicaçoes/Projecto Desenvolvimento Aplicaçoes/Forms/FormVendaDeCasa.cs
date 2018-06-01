using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormVenda_de_Casa : Form
    {
        private ModeloIMODAContainer context = new ModeloIMODAContainer();

        public FormVenda_de_Casa(ModeloIMODAContainer context)
        {
            InitializeComponent();

            this.context = context;
        }
    }
}