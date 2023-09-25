using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cpf = textBox2.Text;
            DateTime date = calendar.SelectionStart.Date;
            double preco = 0;
            bool possuiDoencaCronica = false;
            string doencaCronica = "";
            string medicoSelecionado = "";

            if (!string.IsNullOrEmpty(outrasDoencas.Text))
                possuiDoencaCronica = true;

            if (!checkBox1.Checked)
                if (!checkBox2.Checked &&
                    !checkBox3.Checked &&
                    !checkBox4.Checked &&
                    string.IsNullOrEmpty(outrasDoencas.Text))
                {
                    MessageBox.Show("Se possui doença cronica deve marcar uma opção, ou marcar que não possui nenhuma doença", "Cadastro inválido");
                    return;
                }
                
            if (checkBox2.Checked)
            {
                doencaCronica += $"| {checkBox2.Text} | ";
                possuiDoencaCronica = true;
            }

            if (checkBox3.Checked)
            {
                doencaCronica += $"| {checkBox3.Text} | ";
                possuiDoencaCronica = true;
            }
            if (checkBox4.Checked)
            {
                doencaCronica += $"| {checkBox4.Text} | ";
                possuiDoencaCronica = true;
            }

            if (!string.IsNullOrEmpty(outrasDoencas.Text))
            {
                doencaCronica += $"| {outrasDoencas.Text} | ";
                possuiDoencaCronica = true;
            }


            if (radioButton1.Checked == true)
            {
                preco += 300.00;
            }
            if (radioButton2.Checked == true)
            {
                preco += 500.00;
            }
            if (radioButton3.Checked == true)
            {
                preco += 800.00;
            }
            if (radioButton4.Checked == true)
            {
                preco += 600.00;
            }
            if (radioButton5.Checked == true)
            {
                preco += 500.00;
            }
            if (radioButton6.Checked == true)
            {
                preco += 400.00;
            }
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("O campo médico é obrigatório!", "Cadastro inválido");
                return;
            }
            if(comboBox1.SelectedItem.Equals("João - Oftamologista"))
            {
                preco += 900.00;
                medicoSelecionado = "João";
            }
            if (comboBox1.SelectedItem.Equals("Marcos - Ortopedista"))
            {
                preco += 1000.00;
                medicoSelecionado = "Marcos";
            }
            if (comboBox1.SelectedItem.Equals("Gabriel - Pediatra"))
            {
                preco += 1200.00;
                medicoSelecionado = "Gabriel";
            }

            Program.pacientes.Add(new Paciente(nome, cpf, date, preco, doencaCronica, possuiDoencaCronica, medicoSelecionado));
            MessageBox.Show("Cadastrado Com Sucesso");
            LimparCampos();
        }

        public void LimparCampos()
        {
            foreach(Control control in Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if(control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                outrasDoencas.Enabled = false;
                checkBox4.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;

                outrasDoencas.Text = "";
                checkBox4.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Checked = false;
            }    
            else
            {
                outrasDoencas.Enabled = true;
                checkBox4.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
