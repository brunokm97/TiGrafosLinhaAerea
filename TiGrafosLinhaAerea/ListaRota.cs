namespace TiGrafosLinhaAerea
{
    class ListaRota
    {
        Rota primeiro, ultimo;
        // lista rota item proximo(contem aeroporto saida,chegada,hora chegada,hora saida)

        public ListaRota(Aeroporto de, Aeroporto para,int horarioSaida,int horarioChegada)
        {
            
        }
        internal void insereRota(string de, string para,int horarioSaida, int horarioChegada)
        {
            if(primeiro == null)
            {
                primeiro = new Rota(de, para, horarioSaida, horarioChegada);
                primeiro.proxima = null;
                ultimo = primeiro;
            }
            else
            {
                Rota aux = primeiro;
                while(aux.proxima == null)
                {
                    aux = aux.proxima;
                }
                Rota inserido = new Rota(de, para, horarioSaida, horarioChegada);
                aux.proxima = inserido;
            }
        }
    }
}
