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
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var pessoa in Program.pessoas)
            {
                listBox1.Items.Add("Nome: " + pessoa.Nome + " CPF: " + pessoa.Cpf + " Data Agendada: " + pessoa.Date + " Valor da Consulta: " + pessoa.Preco);
            }
        }
    }
}
