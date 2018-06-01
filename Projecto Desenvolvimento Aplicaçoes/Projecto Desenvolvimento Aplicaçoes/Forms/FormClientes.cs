using Projecto_Desenvolvimento_Aplicaçoes.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormClientes : Form
    {
        public ModeloIMODAContainer context;

        public FormClientes(ModeloIMODAContainer context)
        {
            InitializeComponent();

            this.context = context;
            //carrega as casas pertencentes aos clientes
            //listBoxListaCasas.DataSource = context.Casas.ToList();

            (from Cliente in context.Clientes
             orderby Cliente.Nome
             select Cliente).Load();
            BindingSourceCliente.DataSource = context.Clientes.Local.ToBindingList();
            DataGridViewCliente.AutoGenerateColumns = false;

            //Mostra primeiro index da combobox ao inicar
            comboBoxParametroDeFiltro.SelectedIndex = 0;

            //if(textBoxNomeCliente.TextLength != 0 || textBoxContactoCliente.TextLength !=0 || textBoxMoradaCliente.TextLength != 0)
            //{
            //    buttonCriarCliente.Enabled = false;
            //}
         
            if (DataGridViewCliente.DataSource == null)
            {
                buttonGuardarDadosCliente.Enabled = false;
                textBoxNIFCliente.Enabled = false;
                textBoxNomeCliente.Enabled = false;
                textBoxMoradaCliente.Enabled = false;
                textBoxContactoCliente.Enabled = false;
                buttonFiltrar.Enabled = false;
                buttonApagarCliente.Enabled = false;
            }
            else
            {
                buttonGuardarDadosCliente.Enabled = true;
                textBoxNIFCliente.Enabled = true;
                textBoxNomeCliente.Enabled = true;
                textBoxMoradaCliente.Enabled = true;
                textBoxContactoCliente.Enabled = true;
                buttonFiltrar.Enabled = true;
                buttonApagarCliente.Enabled = true;
            }
  
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {

            textBoxNIFCliente.Text = null;
            textBoxNomeCliente.Text = null;
            textBoxMoradaCliente.Text = null;
            textBoxContactoCliente.Text = null;

            textBoxNIFCliente.Enabled = true;
            textBoxNomeCliente.Enabled = true;
            textBoxMoradaCliente.Enabled = true;
            textBoxContactoCliente.Enabled = true;
 
            textBoxCampoDeFiltro.Enabled = false;

            DataGridViewCliente.Enabled = false;

            Cliente novoCliente = new Cliente
            {
                //NIF = textBoxNIFCliente.Text,
                //Nome = textBoxNomeCliente.Text,
                //Morada = textBoxMoradaCliente.Text,
                //Contacto = textBoxContactoCliente.Text
            };

            context.Clientes.Add(novoCliente);

            DataGridViewCliente.CurrentCell = DataGridViewCliente.Rows[DataGridViewCliente.Rows.Count - 1].Cells[0];

            buttonCriarCliente.Enabled = false;
            buttonGuardarDadosCliente.Enabled = true;
        }

        private void buttonGuardarDadosCliente_Click(object sender, EventArgs e)
        {
            bool IsValid = Utilities.ValidateString(textBoxNIFCliente.Text, true)
                           && Utilities.ValidateString(textBoxNomeCliente.Text, false)
                           && Utilities.ValidateString(textBoxMoradaCliente.Text, true)
                           && Utilities.ValidateString(textBoxContactoCliente.Text, true);

            if (IsValid)
            {

                context.SaveChanges();
                MessageBox.Show("Cliente gravado com sucesso", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonCriarCliente.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nao foi possivel criar um novo cliente, verifique a informaçao introduzida e tente novamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DataGridViewCliente.Enabled = true;
            textBoxCampoDeFiltro.Enabled = false;
        }

        //bloquear botao novo quando se esta a editar textboxes

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            if(DataGridViewCliente.CurrentCell == null)
            {
                MessageBox.Show("Não existem clientes", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente clienteselecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                context.Clientes.Remove(clienteselecionado);
                context.SaveChanges();

                buttonCriarCliente.Enabled = true;
            }

        }
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

            //quando filtrado nao atualiza as textboxes

            //----------------------------------DUVIDAS---------------------------------
            //depois de filtrar mudar texto do botao filtrar e desbloquear textboxes e botoes

            buttonCriarCliente.Enabled = false;

            string campoFiltro = textBoxCampoDeFiltro.Text;
            string parametroPesquisa = comboBoxParametroDeFiltro.Text;

            if (campoFiltro.Length == 0)
            {
                return;
            }
            
            switch (parametroPesquisa)
            {
                case "Nome":
                    IEnumerable<Cliente> resultadoPesquisaNome = from Cliente in context.Clientes
                                                                 where Cliente.Nome == campoFiltro
                                                                 select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaNome.ToList();

                    break;

                case "NIF":
                    IEnumerable<Cliente> resultadoPesquisaNIF = from Cliente in context.Clientes
                                                                where Cliente.NIF == campoFiltro
                                                                select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaNIF.ToList();
                    break;

                case "Contacto":
                    IEnumerable<Cliente> resultadoPesquisaContacto = from Cliente in context.Clientes
                                                                     where Cliente.Contacto == campoFiltro
                                                                     select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaContacto.ToList();
                    break;

                case "Morada":
                    IEnumerable<Cliente> resultadoPesquisaMorada = from Cliente in context.Clientes
                                                                   where Cliente.Morada == campoFiltro
                                                                   select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaMorada.ToList();
                    break;
            }
        }

        private void textBoxCampoDeFiltro_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCampoDeFiltro.TextLength != 0)
            {
                buttonFiltrar.Enabled = true;
            }

            if (textBoxCampoDeFiltro.TextLength == 0)
            {
                DataGridViewCliente.DataSource = BindingSourceCliente;

                textBoxNomeCliente.Enabled = true;
                textBoxNIFCliente.Enabled = true;
                textBoxContactoCliente.Enabled = true;
                textBoxMoradaCliente.Enabled = true;
                buttonApagarCliente.Enabled = true;
                buttonGuardarDadosCliente.Enabled = true;
                buttonCriarCliente.Enabled = true;
                buttonFiltrar.Enabled = true;
            }
        }

        private void DataGridViewCliente_SelectionChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
            listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
        }

        private void listBoxListaCasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxListaCasas.SelectedItem.GetType().BaseType == typeof(CasaVendavel))
            {
                if (context.Vendas.ToList().Count != 0)
                {
                    CasaVendavel casaSelecionada = (CasaVendavel)listBoxListaCasas.SelectedItem;

                    listBoxListaAquisicoes.DataSource = casaSelecionada.Venda.ToString();
                    listBoxListaArrendamentos.DataSource = null;

                }
                listBoxListaArrendamentos.DataSource = null;
            }
            else if (listBoxListaCasas.SelectedItem.GetType().BaseType == typeof(CasaArrendavel))
            {

                CasaArrendavel casaSelecionada = (CasaArrendavel)listBoxListaCasas.SelectedItem;

                listBoxListaArrendamentos.DataSource = casaSelecionada.Arrendamento.ToList();
                listBoxListaAquisicoes.DataSource = null;
            }

            else if (listBoxListaCasas.SelectedItem.GetType().BaseType == typeof(Casa))
            {
                listBoxListaArrendamentos.DataSource = null;
                listBoxListaAquisicoes.DataSource = null;
            }
        }
        private void listBoxListaCasas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormCasas FormCasas = new FormCasas(context);
            FormCasas.ShowDialog();
        }

        private void listBoxListaArrendamentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormArrendamentos FormArrendamentos = new FormArrendamentos(context);
            FormArrendamentos.ShowDialog();
        }

        private void listBoxListaAquisicoes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormVenda_de_Casa FormVendaDeCasa = new FormVenda_de_Casa(context);
            FormVendaDeCasa.ShowDialog();
        }
        
    }
}