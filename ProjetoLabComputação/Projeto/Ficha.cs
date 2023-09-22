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
            Pessoa P = new Pessoa();
            P.Nome = textBox1.Text;
            P.Cpf = textBox2.Text;
            DateTime startDate = monthCalendar1.SelectionStart.Date;
            startDate = P.Date;
            if(radioButton1.Checked == true)
            {
                P.Preco += 300.00;
            }
            if (radioButton2.Checked == true)
            {
                P.Preco += 500.00;
            }
            if (radioButton1.Checked == true)
            {
                P.Preco += 800.00;
            }
            if (radioButton1.Checked == true)
            {
                P.Preco += 600.00;
            }
            if (radioButton1.Checked == true)
            {
                P.Preco += 500.00;
            }
            if (radioButton1.Checked == true)
            {
                P.Preco += 400.00;
            }
            if(comboBox1.Items.Equals("João"))
            {
                P.Preco += 900.00;
            }
            if (comboBox1.Items.Equals("Marcos"))
            {
                P.Preco += 1000.00;
            }
            if (comboBox1.Items.Equals("Gabriel"))
            {
                P.Preco += 1200.00;
            }
            Program.pessoas.Add(P);
            lblTest.Text = startDate.ToString();
            MessageBox.Show("Cadastrado Com Sucesso");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
