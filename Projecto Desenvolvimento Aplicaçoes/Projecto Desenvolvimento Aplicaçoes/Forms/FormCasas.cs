using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormCasas : Form
    {
        public ModeloIMODAContainer context;

        public FormCasas(ModeloIMODAContainer context)
        {
            InitializeComponent();

            this.context = context;

            DataGridViewCasa.DataSource = context.Casas.ToList();

            comboBoxProprietárioDaCasa.DataSource = context.Clientes.ToList();
            comboBoxProprietárioDaCasa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonGerirLimpezas_Click(object sender, EventArgs e)
        {
            FormLimpezas FormLimpezas = new FormLimpezas(context);
            FormLimpezas.ShowDialog();
        }

        private void checkBoxArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArrendavel.Checked == true)
            {
                checkBoxVendavel.Checked = false;
                groupBoxVenda.Enabled = false;
                groupBoxArrendamento.Enabled = true;
            }
            //if (checkBoxArrendavel.Checked == false)
            //{
            //    checkBoxVendavel.Checked = false;
            //    checkBoxVendavel.Enabled = true;
            //    groupBoxArrendamento.Enabled = false;
            //}
        }

        private void checkBoxVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVendavel.Checked == true)
            {
                checkBoxArrendavel.Checked = false;
                groupBoxArrendamento.Enabled = false;
                groupBoxVenda.Enabled = true;
            }
            //if (checkBoxVendavel.Checked == false)
            //{
            //    //checkBoxArrendavel.Checked = false;
            //    checkBoxArrendavel.Enabled = true;
            //    groupBoxVenda.Enabled = false;
            //}
        }

        private void buttonNovaCasa_Click(object sender, EventArgs e)
        {
            buttonNovaCasa.Text = "Cancelar";

            DataGridViewCasa.CurrentCell = DataGridViewCasa.Rows[DataGridViewCasa.Rows.Count - 1].Cells[0];

            textBoxLocalidadeCasa.Text = null;
            textBoxRuaCasa.Text = null;
            textBoxAndarCasa.Text = null;
            textBoxNumeroCasa.Text = null;

            checkBoxArrendavel.Checked = false;
            checkBoxArrendavel.Enabled = true;
            groupBoxArrendamento.Enabled = false;

            checkBoxVendavel.Checked = false;
            checkBoxVendavel.Enabled = true;
            groupBoxArrendamento.Enabled = false;

            numericUpDownAreaDaCasa.Value = 0;
            numericUpDownAssoalhadasDaCasa.Value = 0;
            numericUpDownWCDaCasa.Value = 0;
            numericUpDownPisosDaCasa.Value = 0;

            textBoxComissaoArrendamento.Text = null;
            textBoxComissãoBaseVenda.Text = null;
            textBoxValorBaseArrendamento.Text = null;
            textBoxValorBaseVenda.Text = null;

            DataGridViewCasa.Enabled = false;
        }

        private void buttonGuardarDetalhes_Click(object sender, EventArgs e)
        {
            if (checkBoxArrendavel.Checked == true)
            {

                CasaArrendavel casaArrendavel = new CasaArrendavel
                {
                    Localidade = textBoxLocalidadeCasa.Text,
                    Rua = textBoxRuaCasa.Text,
                    Numero = Int32.Parse(textBoxNumeroCasa.Text),
                    Andar = Int32.Parse(textBoxAndarCasa.Text),
                    Area = numericUpDownAreaDaCasa.Value,
                    NumeroAssoalhadas = Decimal.ToInt32(numericUpDownAssoalhadasDaCasa.Value),
                    NumeroWC = Decimal.ToInt32(numericUpDownWCDaCasa.Value),
                    NumeroPisos = Decimal.ToInt32(numericUpDownPisosDaCasa.Value),
                    Tipo = comboBoxTipoDeCasa.SelectedItem.ToString(),
                    Cliente = (Cliente)comboBoxProprietárioDaCasa.SelectedItem,
                    ValorBaseMes = int.Parse(textBoxValorBaseArrendamento.Text),
                    Comissao = int.Parse(textBoxComissaoArrendamento.Text),   
                };

                context.Casas.Add(casaArrendavel);
                context.SaveChanges();
                buttonNovaCasa.Text = "Novo";
                DataGridViewCasa.DataSource = null;
                DataGridViewCasa.DataSource = context.Casas.ToList();
                DataGridViewCasa.Enabled = true;
            }
            else if (checkBoxVendavel.Checked == true)
            {
                
                CasaVendavel casaVendavel = new CasaVendavel
                {
                    Localidade = textBoxLocalidadeCasa.Text,
                    Rua = textBoxRuaCasa.Text,
                    Numero = Int32.Parse(textBoxNumeroCasa.Text),
                    Andar = Int32.Parse(textBoxAndarCasa.Text),
                    Area = numericUpDownAreaDaCasa.Value,
                    NumeroAssoalhadas = Decimal.ToInt32(numericUpDownAssoalhadasDaCasa.Value),
                    NumeroWC = Decimal.ToInt32(numericUpDownWCDaCasa.Value),
                    NumeroPisos = Decimal.ToInt32(numericUpDownPisosDaCasa.Value),
                    Tipo = comboBoxTipoDeCasa.SelectedItem.ToString(),
                    Cliente = (Cliente)comboBoxProprietárioDaCasa.SelectedItem,
                    ValorBaseVenda = int.Parse(textBoxValorBaseVenda.Text),
                    ValorComissao = int.Parse(textBoxComissãoBaseVenda.Text)
                };
                
                context.Casas.Add(casaVendavel);
                context.SaveChanges();
                buttonNovaCasa.Text = "Novo";
                DataGridViewCasa.DataSource = null;
                DataGridViewCasa.DataSource = context.Casas.ToList();
                DataGridViewCasa.Enabled = true;

            }
            else
            {
                Casa novaCasas = new Casa
                {
                    Localidade = textBoxLocalidadeCasa.Text,
                    Rua = textBoxRuaCasa.Text,
                    Numero = Int32.Parse(textBoxNumeroCasa.Text),
                    Andar = Int32.Parse(textBoxAndarCasa.Text),
                    Area = numericUpDownAreaDaCasa.Value,
                    NumeroAssoalhadas = Decimal.ToInt32(numericUpDownAssoalhadasDaCasa.Value),
                    NumeroWC = Decimal.ToInt32(numericUpDownWCDaCasa.Value),
                    NumeroPisos = Decimal.ToInt32(numericUpDownPisosDaCasa.Value),
                    Tipo = comboBoxTipoDeCasa.Text,
                    Cliente = (Cliente)comboBoxProprietárioDaCasa.SelectedItem
                };

                context.Casas.Add(novaCasas);
                context.SaveChanges();
                buttonNovaCasa.Text = "Novo";
                DataGridViewCasa.DataSource = null;
                DataGridViewCasa.DataSource = context.Casas.ToList();
                DataGridViewCasa.Enabled = true;
            }
            
        }

        private void DataGridViewCasa_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewCasa.CurrentRow.DataBoundItem.GetType().BaseType == typeof(CasaArrendavel))
            {
                CasaArrendavel casaarrendavelselecionada = (CasaArrendavel)DataGridViewCasa.CurrentRow.DataBoundItem;
                textBoxValorBaseArrendamento.Text = null;
                textBoxComissãoBaseVenda.Text = null;

                checkBoxVendavel.Enabled = false;
                checkBoxArrendavel.Enabled = false;

                checkBoxArrendavel.Checked = true;

                textBoxLocalidadeCasa.Text = casaarrendavelselecionada.Localidade.ToString();
                textBoxRuaCasa.Text = casaarrendavelselecionada.Rua.ToString();
                textBoxNumeroCasa.Text = casaarrendavelselecionada.Numero.ToString();
                textBoxAndarCasa.Text = casaarrendavelselecionada.Andar.ToString();
                numericUpDownAreaDaCasa.Text = casaarrendavelselecionada.Area.ToString();
                numericUpDownAssoalhadasDaCasa.Text = casaarrendavelselecionada.NumeroAssoalhadas.ToString();
                numericUpDownPisosDaCasa.Text = casaarrendavelselecionada.NumeroPisos.ToString();
                numericUpDownWCDaCasa.Text = casaarrendavelselecionada.NumeroWC.ToString();
                comboBoxTipoDeCasa.Text = casaarrendavelselecionada.Tipo.ToString();
                textBoxComissaoArrendamento.Text = casaarrendavelselecionada.Comissao.ToString();
                textBoxComissãoBaseVenda.Text = casaarrendavelselecionada.ValorBaseMes.ToString();
            }
            else if (DataGridViewCasa.CurrentRow.DataBoundItem.GetType().BaseType == typeof(CasaVendavel))
            {
                CasaVendavel casavendavelselecionada = (CasaVendavel)DataGridViewCasa.CurrentRow.DataBoundItem;
                checkBoxArrendavel.Checked = false;
                checkBoxVendavel.Checked = true;

                textBoxValorBaseArrendamento.Text = "";
                textBoxComissaoArrendamento.Text = "";
                groupBoxVenda.Enabled = true;
                checkBoxVendavel.Enabled = false;
                checkBoxArrendavel.Enabled = false;

                textBoxLocalidadeCasa.Text = casavendavelselecionada.Localidade.ToString();
                textBoxRuaCasa.Text = casavendavelselecionada.Rua.ToString();
                textBoxNumeroCasa.Text = casavendavelselecionada.Numero.ToString();
                textBoxAndarCasa.Text = casavendavelselecionada.Andar.ToString();
                numericUpDownAreaDaCasa.Text = casavendavelselecionada.Area.ToString();
                numericUpDownAssoalhadasDaCasa.Text = casavendavelselecionada.NumeroAssoalhadas.ToString();
                numericUpDownPisosDaCasa.Text = casavendavelselecionada.NumeroPisos.ToString();
                numericUpDownWCDaCasa.Text = casavendavelselecionada.NumeroWC.ToString();
                comboBoxTipoDeCasa.Text = casavendavelselecionada.Tipo.ToString();
                textBoxComissãoBaseVenda.Text = casavendavelselecionada.ValorComissao.ToString();
                textBoxValorBaseVenda.Text = casavendavelselecionada.ValorBaseVenda.ToString();
            }
            else
            {
                Casa casaselecionada = (Casa)DataGridViewCasa.CurrentRow.DataBoundItem;
                checkBoxVendavel.Checked = false;
                checkBoxArrendavel.Checked = false;
                checkBoxVendavel.Enabled = false;
                checkBoxArrendavel.Enabled = false;

                textBoxValorBaseVenda.Text = "";
                textBoxValorBaseArrendamento.Text = "";
                textBoxComissaoArrendamento.Text = "";
                textBoxComissãoBaseVenda.Text = "";

                textBoxLocalidadeCasa.Text = casaselecionada.Localidade.ToString();
                textBoxRuaCasa.Text = casaselecionada.Rua.ToString();
                textBoxNumeroCasa.Text = casaselecionada.Numero.ToString();
                textBoxAndarCasa.Text = casaselecionada.Andar.ToString();
                numericUpDownAreaDaCasa.Text = casaselecionada.Area.ToString();
                numericUpDownAssoalhadasDaCasa.Text = casaselecionada.NumeroAssoalhadas.ToString();
                numericUpDownPisosDaCasa.Text = casaselecionada.NumeroPisos.ToString();
                numericUpDownWCDaCasa.Text = casaselecionada.NumeroWC.ToString();
                comboBoxTipoDeCasa.Text = casaselecionada.Tipo.ToString();

            }
        }
    }
}