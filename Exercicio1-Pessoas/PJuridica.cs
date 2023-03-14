using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Pessoas
{
    internal class PJuridica : Pessoas
    {
        public string cnpj { get; set; }
        public string nomefantasia { get; set; }

        public string ToString()
        {
            return base.ToString()+ "| " +nomefantasia+ " - " +cnpj ;
        }
    }
}
