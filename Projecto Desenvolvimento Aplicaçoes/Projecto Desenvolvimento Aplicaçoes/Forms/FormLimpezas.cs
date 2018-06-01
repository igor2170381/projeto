using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormLimpezas : Form
    {
        private ModeloIMODAContainer context = new ModeloIMODAContainer();

        public FormLimpezas(ModeloIMODAContainer context)
        {
            InitializeComponent();
            this.context = context;
        }
    }
}