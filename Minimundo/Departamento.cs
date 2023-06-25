using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public abstract class Departamento
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public Empregado Gerente { get; set; }
        public DateTime DataInicioGerencia { get; set; }
        public List<Localizacao> Localizacoes { get; set; }
        public List<Projeto> Projetos { get; set; }

        public Departamento(string nome, int numero, Empregado gerente, DateTime dataInicioGerencia)
        {
            Nome = nome;
            Numero = numero;
            Gerente = gerente;
            DataInicioGerencia = dataInicioGerencia;
            Localizacoes = new List<Localizacao>();
            Projetos = new List<Projeto>();
        }

        public void AdicionarLocalizacao(Localizacao localizacao)
        {
            Localizacoes.Add(localizacao);
        }

        public void AdicionarProjeto(Projeto projeto)
        {
            Projetos.Add(projeto);
        }
    }
}
