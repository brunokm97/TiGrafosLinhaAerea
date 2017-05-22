using System.IO;


namespace TiGrafosLinhaAerea
{
    class ManipulaArquivo
    {
        public int[] a = new int[1000000];
        int posicao = 0;


        public ManipulaArquivo()
        {
            importArquivo();
        }
        void importArquivo()
        {
            StreamReader leitor = new StreamReader("C:/Users/bruno/Google Drive/PUC/12017/GRAFOS/TiGrafosLinhaAerea/TiGrafosLinhaAerea/Ordena.txt");
            string atual = leitor.ReadLine();

            while(atual != null)
            {
                a[posicao] = int.Parse(atual);
                posicao++;
                atual = leitor.ReadLine();
            }
            leitor.Close();
        }
    }
}
