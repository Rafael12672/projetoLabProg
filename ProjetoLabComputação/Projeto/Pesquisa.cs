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
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            ListarTodosPacientes();
        }

        public void ListarTodosPacientes()
        {
            listBox1.Items.Clear();
            foreach (var pessoa in Program.pessoas)
            {
                if(!pessoa.PossuiDoencaCronica)
                 {
                    listBox1.Items.Add("Nome: " + pessoa.Nome + " CPF: " + pessoa.Cpf + " Data Agendada: " + pessoa.Date.ToString("dd/MM/yyyy") +
                    " Valor da Consulta: R$" + pessoa.Preco.ToString("0.00"));
                } else
                {
                    listBox1.Items.Add("Nome: " + pessoa.Nome + " CPF: " + pessoa.Cpf + " Data Agendada: " + pessoa.Date.ToString("dd/MM/yyyy") +
                    " Valor da Consulta: R$" + pessoa.Preco.ToString("0.00") + " Doença(s) Crônica(s): " + pessoa.DoencaCronica);
                }
            }
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var pessoa in Program.pessoas)
            {
                if (pessoa.Nome.Equals(textBox1.Text))
                {
                    if (!pessoa.PossuiDoencaCronica)
                    {
                        listBox1.Items.Add("Nome: " + pessoa.Nome + " CPF: " + pessoa.Cpf + " Data Agendada: " + pessoa.Date.ToString("dd/MM/yyyy") +
                        " Valor da Consulta: R$" + pessoa.Preco.ToString("0.00"));
                    } else
                    {
                        listBox1.Items.Add("Nome: " + pessoa.Nome + " CPF: " + pessoa.Cpf + " Data Agendada: " + pessoa.Date.ToString("dd/MM/yyyy") +
                        " Valor da Consulta: R$" + pessoa.Preco.ToString("0.00") + " Doença(s) Crônica(s): " + pessoa.DoencaCronica);
                    }
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListarTodosPacientes();
        }
    }
}
