using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiGrafosLinhaAerea
{
    class Rota
    {
        internal Rota proxima;
        Aeroporto de, para;
        string aux;
        int horaSaida, horaChegada;

        public Rota(string de, string para,int horaSaida,int horaChegada)
        {
            this.de = new Aeroporto(de);
            this.para = new Aeroporto(para);
            this.horaChegada = horaChegada;
            this.horaSaida = horaSaida;
        }
    }
}
