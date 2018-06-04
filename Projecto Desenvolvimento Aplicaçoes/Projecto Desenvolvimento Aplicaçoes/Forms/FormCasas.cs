using Projecto_Desenvolvimento_Aplicaçoes.Classes;
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

            (from Casa in context.Casas
             orderby Casa.Localidade
             select Casa).Load();

            DataGridViewCasa.DataSource = context.Casas.ToList();
            DataGridViewCasa.AutoGenerateColumns = false;
            comboBoxProprietárioDaCasa.DataSource = context.Clientes.ToList();
            comboBoxProprietárioDaCasa.DropDownStyle = ComboBoxStyle.DropDownList;

            groupBoxArrendamento.Enabled = false;
            groupBoxVenda.Enabled = false;
        }

        private void buttonGerirLimpezas_Click(object sender, EventArgs e)
        {
            FormLimpezas FormLimpezas = new FormLimpezas(context, (Casa)DataGridViewCasa.CurrentRow.DataBoundItem);
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
            
            if(buttonNovaCasa.Text == "Nova")
            {
                DataGridViewCasa.CurrentCell = DataGridViewCasa.Rows[DataGridViewCasa.Rows.Count - 1].Cells[0];

                textBoxLocalidadeCasa.Text = null;
                textBoxRuaCasa.Text = null;
                textBoxAndarCasa.Text = null;
                textBoxNumeroCasa.Text = null;

                checkBoxArrendavel.Checked = false;
                checkBoxArrendavel.Enabled = true;
                checkBoxVendavel.Checked = false;
                checkBoxVendavel.Enabled = true;

                if (checkBoxArrendavel.Checked == false && checkBoxVendavel.Checked == false)
                {
                    groupBoxArrendamento.Enabled = false;
                    groupBoxVenda.Enabled = false;
                }

                numericUpDownAreaDaCasa.Value = 0;
                numericUpDownAssoalhadasDaCasa.Value = 0;
                numericUpDownWCDaCasa.Value = 0;
                numericUpDownPisosDaCasa.Value = 0;

                textBoxComissaoArrendamento.Text = null;
                textBoxComissãoBaseVenda.Text = null;
                textBoxValorBaseArrendamento.Text = null;
                textBoxValorBaseVenda.Text = null;

                DataGridViewCasa.Enabled = false;

                buttonNovaCasa.Text = "Cancelar";
                buttonApagarCasa.Enabled = false;
                buttonGerirLimpezas.Enabled = false;
            }
            else
            {
                DataGridViewCasa.CurrentCell = DataGridViewCasa.Rows[DataGridViewCasa.Rows.Count - 1].Cells[0];
                DataGridViewCasa.DataSource = context.Casas.ToList();
                DataGridViewCasa.Enabled = true;
                buttonNovaCasa.Text = "Nova";
                buttonApagarCasa.Enabled = true;
                buttonGerirLimpezas.Enabled = true;
            }
            

        }

        private void buttonGuardarDetalhes_Click(object sender, EventArgs e)
        {
            bool IsValid = Utilities.ValidateString(textBoxLocalidadeCasa.Text, true)
                           && Utilities.ValidateString(textBoxRuaCasa.Text, true)
                           && Utilities.ValidateInt(textBoxAndarCasa.Text,20)
                           && Utilities.ValidateInt(textBoxNumeroCasa.Text, 1000);

            if (IsValid)
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
                        Proprietario = (Cliente)comboBoxProprietárioDaCasa.SelectedItem,
                        ValorBaseMes = int.Parse(textBoxValorBaseArrendamento.Text),
                        Comissao = int.Parse(textBoxComissaoArrendamento.Text),
                    };

                    context.Casas.Add(casaArrendavel);
                    context.SaveChanges();
                    buttonNovaCasa.Text = "Novo";
                    DataGridViewCasa.DataSource = context.Casas.ToList();
                    DataGridViewCasa.Enabled = true;
                    MessageBox.Show("Casa Arrendável criada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Proprietario = (Cliente)comboBoxProprietárioDaCasa.SelectedItem,
                        ValorBaseVenda = int.Parse(textBoxValorBaseVenda.Text),
                        ValorComissao = int.Parse(textBoxComissãoBaseVenda.Text)
                    };

                    context.Casas.Add(casaVendavel);
                    context.SaveChanges();
                    buttonNovaCasa.Text = "Novo";
                    DataGridViewCasa.DataSource = context.Casas.ToList();
                    DataGridViewCasa.Enabled = true;
                    MessageBox.Show("Casa vendável criada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Casa novaCasa = new Casa
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
                        Proprietario = (Cliente)comboBoxProprietárioDaCasa.SelectedItem
                    };

                    context.Casas.Add(novaCasa);
                    context.SaveChanges();
                    buttonNovaCasa.Text = "Novo";
                    DataGridViewCasa.DataSource = context.Casas.ToList();
                    DataGridViewCasa.Enabled = true;
                    MessageBox.Show("Casa criada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verifique os valores introduzidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DataGridViewCasa_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewCasa.CurrentRow.DataBoundItem.GetType().BaseType == typeof(CasaArrendavel))
            {
                CasaArrendavel casaarrendavelselecionada = (CasaArrendavel)DataGridViewCasa.CurrentRow.DataBoundItem;
                textBoxValorBaseVenda.Text = null;
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
                textBoxValorBaseArrendamento.Text = casaarrendavelselecionada.ValorBaseMes.ToString();
                textBoxComissaoArrendamento.Text = casaarrendavelselecionada.Comissao.ToString();
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

        private void buttonApagarCasa_Click(object sender, EventArgs e)
        {
            if(DataGridViewCasa.CurrentRow.DataBoundItem == null)
            {
                Casa casaSelecionada = (Casa)DataGridViewCasa.CurrentRow.DataBoundItem;
                context.Casas.Remove(casaSelecionada);
                context.SaveChanges();

                buttonNovaCasa.Enabled = true;
            }
            
        }

        private void buttonVerVenda_Click(object sender, EventArgs e)
        {
            FormVenda_de_Casa FormVendaDeCasa = new FormVenda_de_Casa(context, (CasaVendavel)DataGridViewCasa.CurrentRow.DataBoundItem);
            FormVendaDeCasa.ShowDialog();
        }

        private void buttonVerECriarArrendamento_Click(object sender, EventArgs e)
        {
            FormArrendamentos FormArrendamentos = new FormArrendamentos(context, (CasaArrendavel)DataGridViewCasa.CurrentRow.DataBoundItem);
            FormArrendamentos.ShowDialog();
        }
    }
}