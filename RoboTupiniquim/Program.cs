namespace RoboTupiniquim
{
    internal class Program
    {
        static int tamanho = 5;
        static char[,] area = new char[tamanho, tamanho];
        static void Main(string[] args)
        {
            ExibirArea();
            int linha = 0;
            int coluna = 0;
            area[linha, coluna] = '>';

            while (true)
            {
                Console.Clear();
                ExibirPrimeriraPosicaoRobo();

                Console.WriteLine("\nDigite a direção D (Direite), E (Esquerda) ou S (Sair):");
                string comando = Console.ReadLine().ToUpper();
                MoverRoboDireiraEsqueda(ref linha, ref coluna, comando);

                if (comando == "S")
                    break;

            }

            Console.ReadLine();

        }

        private static int MoverRoboDireiraEsqueda(ref int linha,  ref int coluna, string comando)
        {
                        area[linha, coluna] = '.';

            if (comando == "D" && coluna < tamanho - 1)
                coluna++;
            else if (comando == "E" && coluna > 0)
                coluna--;

            if (comando == "E")
                area[linha, coluna] = '<';
            else
                area[linha, coluna] = '>';
            return coluna;
        }

        private static void ExibirArea()
        {
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    area[l, c] = '.';

            }

        }

        private static void ExibirPrimeriraPosicaoRobo()
        {
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    Console.Write(area[l, c] + " ");

                Console.WriteLine();
            }
        }
    }
}
