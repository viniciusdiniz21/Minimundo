using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimundo
{
    public class Localizacao
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public Localizacao(string rua, string bairro, string cidade)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
