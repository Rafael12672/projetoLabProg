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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font SmallFont = new Font("Arial", 30);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = SmallFont;
            label2.Text = DateTime.Now.ToString();
        }

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ficha cadastro = new Ficha();
            cadastro.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisaDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();
            pesquisa.ShowDialog();
        }
    }
}
