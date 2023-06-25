using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class Projeto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public Localizacao Localizacao { get; set; }
        public Dictionary<Empregado, int> HorasPorFuncionario { get; set; }

        public Projeto(string nome, int codigo, Localizacao localizacao)
        {
            Nome = nome;
            Codigo = codigo;
            Localizacao = localizacao;
            HorasPorFuncionario = new Dictionary<Empregado, int>();
        }

        public void AdicionarFuncionario(Empregado funcionario, int horas)
        {
            HorasPorFuncionario.Add(funcionario, horas);
        }
    }
}
