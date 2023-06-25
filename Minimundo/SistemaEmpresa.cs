using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class SistemaEmpresa
    {
        public List<Departamento> Departamentos { get; set; }
        public List<Empregado> Empregados { get; set; }

        public SistemaEmpresa()
        {
            Departamentos = new List<Departamento>();
            Empregados = new List<Empregado>();
        }

        public void AdicionarDepartamento(Departamento departamento)
        {
            Departamentos.Add(departamento);
        }

        public void AdicionarEmpregado(Empregado empregado)
        {
            Empregados.Add(empregado);
        }

        // Implemente aqui o menu e as funcionalidades do sistema
    }
}
