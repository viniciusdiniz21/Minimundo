using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class DepartamentoEspecifico : Departamento
    {
        public Empregado Supervisor { get; set; }

        public DepartamentoEspecifico(string nome, int numero, Empregado supervisor, DateTime dataInicioGerencia)
            : base(nome, numero, supervisor, dataInicioGerencia)
        {
            Supervisor = supervisor;
        }
    }
}
