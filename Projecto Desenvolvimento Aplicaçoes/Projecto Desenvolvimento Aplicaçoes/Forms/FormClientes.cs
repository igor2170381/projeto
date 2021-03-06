﻿using Projecto_Desenvolvimento_Aplicaçoes.Classes;
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

            buttonFiltrar.Enabled = false;

            //Mostra primeiro index da combobox ao inicar
            comboBoxParametroDeFiltro.SelectedIndex = 0;

            //if(textBoxNomeCliente.TextLength != 0 || textBoxContactoCliente.TextLength !=0 || textBoxMoradaCliente.TextLength != 0)
            //{
            //    buttonCriarCliente.Enabled = false;
            //}
         
            //if (DataGridViewCliente.DataSource == null)
            //{
            //    buttonGuardarDadosCliente.Enabled = true;
            //    textBoxNIFCliente.Enabled = true;
            //    textBoxNomeCliente.Enabled = true;
            //    textBoxMoradaCliente.Enabled = true;
            //    textBoxContactoCliente.Enabled = true;
            //    textBoxCampoDeFiltro.Enabled = true;
            //    buttonFiltrar.Enabled = true;
            //    buttonApagarCliente.Enabled = true;
            //}
            //else
            //{
            //    buttonGuardarDadosCliente.Enabled = false;
            //    textBoxNIFCliente.Enabled = false;
            //    textBoxNomeCliente.Enabled = false;
            //    textBoxMoradaCliente.Enabled = false;
            //    textBoxContactoCliente.Enabled = false;
            //    textBoxCampoDeFiltro.Enabled = false;
            //    buttonFiltrar.Enabled = false;
            //    buttonApagarCliente.Enabled = false;

                
            //}
  
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            if (buttonCriarCliente.Text == "Novo")
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

                listBoxListaCasas.DataSource = null;
                listBoxListaArrendamentos.DataSource = null;
                listBoxListaAquisicoes.DataSource = null;

                Cliente novoCliente = new Cliente
                {
                };

                context.Clientes.Add(novoCliente);

                DataGridViewCliente.CurrentCell = DataGridViewCliente.Rows[DataGridViewCliente.Rows.Count - 1].Cells[0];

                buttonGuardarDadosCliente.Enabled = true;
                buttonApagarCliente.Enabled = false;
                buttonCriarCliente.Text = "Cancelar";
                Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
                listBoxListaArrendamentos.DataSource = clienteSelecionado.Arrendamentos.ToList();
                listBoxListaAquisicoes.DataSource = clienteSelecionado.Aquisicoes.ToList();
            }
            else
            {
                buttonCriarCliente.Text = "Novo";
                buttonApagarCliente.Enabled = true;
                DataGridViewCliente.Enabled = true;
                textBoxCampoDeFiltro.Enabled = true;
                //remover campo  vazio
                Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                context.Clientes.Remove(clienteSelecionado);
                listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
                listBoxListaArrendamentos.DataSource = clienteSelecionado.Arrendamentos.ToList();
                listBoxListaAquisicoes.DataSource = clienteSelecionado.Aquisicoes.ToList();
            }
        }

        private void buttonGuardarDadosCliente_Click(object sender, EventArgs e)
        {
            bool IsValid = Utilities.ValidateString(textBoxNIFCliente.Text, true)
                           && Utilities.ValidateString(textBoxNomeCliente.Text, false)
                           && Utilities.ValidateString(textBoxMoradaCliente.Text, true)
                           && Utilities.ValidateString(textBoxContactoCliente.Text, true);

            if (IsValid)
            {
                if (buttonCriarCliente.Text == "Cancelar")
                {
                    context.SaveChanges();
                    MessageBox.Show("Cliente gravado com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttonCriarCliente.Enabled = true;
                    buttonCriarCliente.Text = "Novo";
                    Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                    listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
                    listBoxListaArrendamentos.DataSource = clienteSelecionado.Arrendamentos.ToList();
                    listBoxListaAquisicoes.DataSource = clienteSelecionado.Aquisicoes.ToList();
                }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Cliente editado com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttonCriarCliente.Enabled = true;
                    Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                    listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
                    listBoxListaArrendamentos.DataSource = clienteSelecionado.Arrendamentos.ToList();
                    listBoxListaAquisicoes.DataSource = clienteSelecionado.Aquisicoes.ToList();
                }
            }
            else
            {
                MessageBox.Show("Verifique os valores introduzidos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DataGridViewCliente.Enabled = true;
            textBoxCampoDeFiltro.Enabled = true;
            buttonApagarCliente.Enabled = true;
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
                Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
                if (clienteSelecionado.Aquisicoes.Count == 0 && clienteSelecionado.Arrendamentos.Count == 0 && clienteSelecionado.Casas.Count == 0)
                {
                    context.Clientes.Remove(clienteSelecionado);
                    context.SaveChanges();
                    BindingSourceCliente.DataSource = context.Clientes.Local.ToBindingList();
                    MessageBox.Show("Cliente criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não pode apagar um cliente com casas", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                                                                 where Cliente.Nome.Contains(campoFiltro) 
                                                                 select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaNome.ToList();

                    break;

                case "NIF":
                    IEnumerable<Cliente> resultadoPesquisaNIF = from Cliente in context.Clientes
                                                                where Cliente.NIF.Contains(campoFiltro)
                                                                select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaNIF.ToList();
                    break;

                case "Contacto":
                    IEnumerable<Cliente> resultadoPesquisaContacto = from Cliente in context.Clientes
                                                                     where Cliente.Contacto.Contains(campoFiltro)
                                                                     select Cliente;

                    DataGridViewCliente.DataSource = resultadoPesquisaContacto.ToList();
                    break;

                case "Morada":
                    IEnumerable<Cliente> resultadoPesquisaMorada = from Cliente in context.Clientes
                                                                   where Cliente.Morada.Contains(campoFiltro)
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
                buttonCriarCliente.Enabled = false;
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
                buttonFiltrar.Enabled = false;
            }
        }

        private void DataGridViewCliente_SelectionChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)DataGridViewCliente.CurrentRow.DataBoundItem;
            if (clienteSelecionado.Casas != null)
            {
                listBoxListaCasas.DataSource = clienteSelecionado.Casas.ToList();
            }
            else
            {
                listBoxListaCasas.DataSource = null;
                listBoxListaAquisicoes.DataSource = null;
                listBoxListaArrendamentos.DataSource = null;
            }

            if (clienteSelecionado.Aquisicoes != null)
            {
                listBoxListaAquisicoes.DataSource = clienteSelecionado.Aquisicoes.ToList();
            }

            if (clienteSelecionado.Arrendamentos != null)
            {
                listBoxListaArrendamentos.DataSource = clienteSelecionado.Arrendamentos.ToList();
            }
            else
            {
                listBoxListaArrendamentos.DataSource = null;
                listBoxListaAquisicoes.DataSource = null;
                listBoxListaCasas.DataSource = null;
            }
        }
        private void listBoxListaCasas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormCasas FormCasas = new FormCasas(context);
            FormCasas.ShowDialog();
        }

        private void listBoxListaArrendamentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormArrendamentos FormArrendamentos = new FormArrendamentos(context, (CasaArrendavel)listBoxListaArrendamentos.SelectedItem);
            FormArrendamentos.ShowDialog();
        }

        private void listBoxListaAquisicoes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormVenda_de_Casa FormVendaDeCasa = new FormVenda_de_Casa(context, (CasaVendavel)listBoxListaAquisicoes.SelectedItem);
            FormVendaDeCasa.ShowDialog();
        }
    }
}