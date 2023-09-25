using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            foreach (var pessoa in Program.pacientes)
            {
                comboBox1.Items.Add(pessoa.Nome);
            }
        }

        private Paciente PacienteSelecionado()
        {
            Paciente p = null;
            List<Paciente> pacientes = Program.pacientes;
            foreach (var paciente in pacientes)
            {
                if (paciente.Nome == comboBox1.SelectedItem.ToString())
                {
                    p = paciente;
                }
            }

            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente p = PacienteSelecionado();
            p.Consultado = true;
            MessageBox.Show("Consulta finalizada!");
            Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Paciente> pacientes = Program.pacientes;
            for(int i = 0; i < pacientes.Count; i++)
            {
                if (comboBox1.SelectedIndex == i)
                    dadosPaciente.Text = $"Nome: {pacientes[i].Nome}\nCPF: {pacientes[i].Cpf}\nDoenças Crônicas: {pacientes[i].DoencaCronica}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = Program.pacientes;
            Paciente p = null;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("É preciso preencher a receita", "Campo Faltante");
                return;
            }

            foreach(var paciente in pacientes)
            {
                if(paciente.Nome == comboBox1.SelectedItem.ToString())
                {
                    p = paciente; 
                    break;
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            saveFileDialog.Title = "Salvar arquivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string conteudo = "";
                conteudo += $"Médico da consulta - {p.MedicoConsulta}\n";
                conteudo += $"Nome do paciente - {p.Nome}";
                conteudo += $"\n====================================================\n";
                conteudo += $"Receita:\n\n{textBox2.Text}";
                conteudo += $"\n====================================================\n";
                conteudo += $"Sintomas:\n\n{textBox1.Text}";
                conteudo += $"\n====================================================";
                File.WriteAllText(filePath, conteudo);
            }
            MessageBox.Show("Receita gerada com sucesso!", "Recita gerada");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
