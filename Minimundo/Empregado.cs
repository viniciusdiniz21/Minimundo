using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class Empregado : Pessoa
    {
        public double Salario { get; set; }
        public string Escolaridade { get; set; }
        public string Cargo { get; set; }

        public Empregado(string nome, string dataNascimento, double salario, string escolaridade, string cargo)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
            Escolaridade = escolaridade;
            Cargo = cargo;
        }
    }
}
