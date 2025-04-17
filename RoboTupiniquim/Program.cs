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
            InicializarArea();
            
            while (true)
            {
                Console.Clear();
                AtualizarArea();
                ExibirArea();
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
                    MoverParaFrente();
                }


            }
        }

        private static void MoverParaFrente()
        {
            char direcao = direcoes[direcaoAtual];

            if (direcao== 'N' && y < tamanho -1)
                y++; // Norte: sobe no grid (aumenta Y)

            else if (direcao == 'S' && y > 0)
                y--; // Sul: desce no grid (diminui Y)
            else if (direcao == 'L' && x < tamanho-1)
                x++; // Leste: direita
            else if (direcao == 'O' && x > 0)
                x--; // Oeste: esquerda
        }

        private static void InicializarArea()
        {
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                    area[l, c] = '.';
            }
        }

        private static void ExibirArea()
        {
            for (int linha = tamanho - 1; linha >= 0; linha--)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                    Console.Write(area[linha, coluna] + " ");

                Console.WriteLine();
            }
        }

        private static void AtualizarArea()
        {
            InicializarArea();
            area[y, x] = ObterSimboloDirecao();
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
