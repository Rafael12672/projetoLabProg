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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();

            foreach(var pessoa in Program.pacientes)
            {
                comboBox1.Items.Add(pessoa.Nome);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
