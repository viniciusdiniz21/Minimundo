using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class Dependente : Pessoa
    {
        public char Sexo { get; set; }

        public Dependente(string nome, string dataNascimento, char sexo)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }
    }
}
