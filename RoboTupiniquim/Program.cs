namespace RoboTupiniquim
{
    internal class Program
    {
        static int tamanho = 5;
        static char[,] area = new char[tamanho, tamanho];
        static void Main(string[] args)
        {
            

            ExibirArea();
            Console.ReadLine();
        }

        private static void ExibirArea()
        {
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    area[l, c] = '.';

            }

            area[0, 0] = '>';

            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    Console.Write(area[l, c] + " ");

                Console.WriteLine();
            }
        }
    }
}
