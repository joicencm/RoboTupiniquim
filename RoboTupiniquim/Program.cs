namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string posicaoIncicial = "3 3 L";
            string comando = "MMDMMDMDDM";

            string[] coordenadasIniciais = posicaoIncicial.Split(' ');

            int posicaoX = Convert.ToInt32(coordenadasIniciais[0]); 
            int posicaoY = Convert.ToInt32(coordenadasIniciais[1]);
            char direcao = Convert.ToChar(coordenadasIniciais[2]);

            char[] instrucoes = comando.ToCharArray();

            for(int i = 0; i <instrucoes.Length; i++)
            {
                char instrucoesAtual = instrucoes[i];

                if (instrucoesAtual == 'E')
                {
                    if (direcao == 'N')
                        direcao = 'O';
                    else if (direcao == 'O')
                        direcao = 'S';
                    else if (direcao == 'S')
                        direcao = 'l';
                    else if (direcao == 'L')
                        direcao = 'N';
                }

                if (instrucoesAtual == 'D')
                {
                    if (direcao == 'N')
                        direcao = 'L';
                    else if (direcao == 'L')
                        direcao = 'S';
                    else if (direcao == 'S')
                        direcao = 'O';
                    else if (direcao == 'O')
                        direcao = 'N';
                    
                   
                }

                else if (instrucoesAtual == 'M')
                {
                    if (direcao == 'N')
                        posicaoY++;
                    else if (direcao == 'S')
                        posicaoY--;
                    else if (direcao == 'O')
                        posicaoX--;
                    else if (direcao == 'L')
                        posicaoX++;
                }
            }

            Console.WriteLine($"Posição final do Robô: {posicaoX} {posicaoY} {direcao}");
            Console.ReadLine();
        }

    }
}
