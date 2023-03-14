using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Pessoas
{
    internal class Pessoas
    {
        public string Nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public long telefone1 { get; set; }
        public long telefone2 { get; set; }

        public string ToString()
        {
            return this.Nome + ", "  + endereco+ ", "+email+ ", " +telefone1+ ", "+telefone2;
        }
    }
}
