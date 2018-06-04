using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class FormLimpezas : Form
    {
        public ModeloIMODAContainer context;
        public Casa casaselecionada;
        int valorunitario = 0;

        public FormLimpezas(ModeloIMODAContainer context,Casa casaselecionada)
        {
            InitializeComponent();
            this.context = context;

            this.casaselecionada = casaselecionada;

            listBoxListaLimpezas.DataSource = casaselecionada.Limpezas.ToList();
            if (listBoxListaLimpezas.SelectedItem == null)
            {
                comboBoxTipoDeServiço.Enabled = false;
                numericUpDownQuantidadeLimpezas.Enabled = false;
                buttonInserirLimpezas.Enabled = false;
            }
           
        }

        private void buttonCriarLimpezas_Click(object sender, System.EventArgs e)
        {
            
            Limpeza novalimpeza = new Limpeza
            {
                Data = dateTimePickerDataLimpeza.Value,
                Casa = casaselecionada
            };
            
            context.Limpezas.Add(novalimpeza);
            context.SaveChanges();

            listBoxListaLimpezas.DataSource = casaselecionada.Limpezas.ToList();

        }

        private void buttonInserirLimpezas_Click(object sender, EventArgs e)
        {
            int valortotal = decimal.ToInt32(numericUpDownQuantidadeLimpezas.Value) * valorunitario;

            Limpeza limpezaselecionada = (Limpeza)listBoxListaLimpezas.SelectedItem;


            Servico novoServico = new Servico
            {
                Unidades = decimal.ToInt32(numericUpDownQuantidadeLimpezas.Value),
                Descricao = comboBoxTipoDeServiço.SelectedItem.ToString(),
                Valor = valortotal,
                Limpeza = limpezaselecionada
            };
            
            context.Servicos.Add(novoServico);
            context.SaveChanges();

            listBoxListaLimpezas.DataSource = limpezaselecionada.Servicos.ToList();
        }

        private void comboBoxTipoDeServiço_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            switch (comboBoxTipoDeServiço.SelectedIndex)
            {
                case 0:
                    valorunitario = 10 ;
                    break;

                case 1:
                    valorunitario = 20;
                    break;

                case 2:
                    valorunitario = 40;
                    break;

                case 3:
                    valorunitario = 100;
                    break;

                case 4:
                    valorunitario = 200;
                    break;

            }

            labelValorUnitario.Text = valorunitario + "€";
        }

        private void listBoxListaLimpezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxListaLimpezas.SelectedIndex == -1) { 

             Limpeza limpezaselecionada = (Limpeza)listBoxListaLimpezas.SelectedItem;

             listBoxDetalhesLimpeza.DataSource = limpezaselecionada.Servicos.ToList();

            }
            
        }

        private void buttonEmitirFatura_Click(object sender, EventArgs e)
        {

        }
    }
}