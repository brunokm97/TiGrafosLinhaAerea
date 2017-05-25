using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiGrafosLinhaAerea
{
    class Aeroporto
    {
        internal string nomeAeroporto;
        


        public Aeroporto(string nomeAeroporto)
        {
            this.nomeAeroporto = nomeAeroporto;
        }

        internal Aeroporto Proximo
        {
            get
            {
                return proximo;
            }

            set
            {
                proximo = value;
            }
        }
    }
}
