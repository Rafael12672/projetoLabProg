using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Pessoa
    {
        private string nome;
        private string cpf;
        private DateTime date;
        private double preco;
        
        

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Preco { get => preco; set => preco = value; }

        
    }
}
