using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Pessoas
{
    internal class PFisica : Pessoas
    {

        public string cpf { get; set; }

        public string ToString()
        {
            return base.ToString() + " - " +"CPF "+ cpf;
        }
    }
}
