using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiGrafosLinhaAerea
{
    class ListaArquivo
    {
        Aeroporto primeiro, ultimo;
        public ListaArquivo(string aeroporto)
        {
           
        }
        internal void insereLinha(string de,string para,int hora)
        {
            if(primeiro == null)
            {
                primeiro = new Aeroporto(de);
                primeiro.proximo = null;
            }
            else
            {
                Aeroporto aux = primeiro;

                while(aux.proximo != null)
                {
                    aux.proximo = aux;
                }
                Aeroporto inserido = new Aeroporto(de);
                //devera ser manipulada na lista de aeroportos
            }
        }

    }
}
