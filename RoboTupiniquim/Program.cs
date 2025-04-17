namespace RoboTupiniquim
{
    internal class Program
    {
        static int tamanho = 5;
        static char[,] area = new char[tamanho, tamanho];
        // Direções possíveis em sentido horário: N, L, S, O
        static char[] direcoes = { 'N', 'L', 'S', 'O' };
        static int direcaoAtual = 0;

        // Posição inicial do robô
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            ExibirArea();
            
            while (true)
            {
                Console.Clear();
                ExibirPrimeriraPosicaoRobo();
                Console.WriteLine($"\nPosição atual: ({x},{y},{direcoes[direcaoAtual]})");
                Console.WriteLine("Digite os comandos (E, D, M) ou S para sair:");
                string comandos = Console.ReadLine().ToUpper();

                if (comandos == "S")
                    break;

                ExecutarComandos(comandos);

            }

            Console.ReadLine();

        }

        private static void ExecutarComandos(string comandos)
        {
            for (int i = 0; i < comandos.Length; i++)

            {
                char c = comandos[i];
                if (c == 'E')
                    direcaoAtual = (direcaoAtual + 3) % 4; //girar a esquerda

                else if (c == 'D')
                    direcaoAtual = (direcaoAtual + 1) % 4; // girar a direita

                else if (c == 'M')
                {
                    if (direcoes[direcaoAtual] == 'N')
                    {

                        if (y < tamanho - 1) y++;
                    }

                    else if (direcoes[direcaoAtual] == 'S')
                    {
                        if (y > 0) ;y--;
                    }
                    else if (direcoes[direcaoAtual] == 'L')
                    {
                        if (x < tamanho - 1) x++;
                    }
                    else if (direcoes[direcaoAtual] == '0')
                    {
                        if (x > 0) ; x--;
                    }
                }
                   

            }
        }

        private static void ExibirArea()
        {
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    area[l, c] = '.';

            }
            area[y, x] = ObterSimboloDirecao();

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

        static char ObterSimboloDirecao()
        {
            if (direcoes[direcaoAtual] == 'N')
                return '↑';
            else if (direcoes[direcaoAtual] == 'S')
                return '↓';
            else if (direcoes[direcaoAtual] == 'L')
                return '→';
            else if (direcoes[direcaoAtual] == 'O')
                return '←';
            else
                return '?';
        }
    }
}
