static class Robo
{
    public static int posicaoX;
    public static int posicaoY;
    public static char direcao;

    public static void Explorar(char[] instrucoes)
    {
        for (int i = 0; i < instrucoes.Length; i++)
        {
            char instrucoesAtual = instrucoes[i];

            if (instrucoesAtual == 'E')
                VirarEsquerda();

            if (instrucoesAtual == 'D')
                VirarDireita();

            else if (instrucoesAtual == 'M')
                Mover();
        }
    }

    public static void VirarEsquerda()
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

    public static void VirarDireita()
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

    public static void Mover()
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

    public static void ExibirCoordenadas()
    {
        Console.WriteLine($"Posição final do Robô: {Robo.posicaoX} {Robo.posicaoY} {Robo.direcao}");
        Console.ReadLine();
    }

}
