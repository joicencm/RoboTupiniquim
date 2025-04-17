namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 5;
            char[,] area = new char[tamanho, tamanho];

            for (int l = 0; l < tamanho; l++)
            {
                for( int c = 0; c < tamanho; c++)
                area[l, c] = '.';

            }

            area[0, 0] = '>';

            for(int l = 0; l <tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    Console.Write(area[l, c] + " ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
