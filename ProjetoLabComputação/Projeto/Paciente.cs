using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Paciente
    {
        private string nome;
        private string cpf;
        private DateTime date;
        private double preco;
        private bool possuiDoencaCronica;
        private string doencaCronica;

        public Paciente(string nome, string cpf, DateTime date, double preco, string doencaCronica, bool possuiDoencaCronica)
        {
            Nome = nome;
            Cpf = cpf;
            Date = date;
            Preco = preco;
            DoencaCronica = doencaCronica;
            PossuiDoencaCronica = possuiDoencaCronica;

        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Preco { get => preco; set => preco = value; }
        public string DoencaCronica { get => doencaCronica; set => doencaCronica = value; }
        public bool PossuiDoencaCronica { get => possuiDoencaCronica; set => possuiDoencaCronica = value; }
    }
}
