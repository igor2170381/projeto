using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormArrendamentos : Form
    {
        private ModeloIMODAContainer context = new ModeloIMODAContainer();

        public FormArrendamentos(ModeloIMODAContainer context)
        {
            InitializeComponent();
            this.context = context;
        }
    }
}