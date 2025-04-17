namespace RoboTupiniquim;

internal class Program
{
    static void Main(string[] args)
    {
        string posicaoIncicial = "3 3 L";
        string comando = "MMDMMDMDDM";

        string[] coordenadasIniciais = posicaoIncicial.Split(' ');

        Robo.posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
        Robo.posicaoY = Convert.ToInt32(coordenadasIniciais[1]);
        Robo.direcao = Convert.ToChar(coordenadasIniciais[2]);

        char[] instrucoes = comando.ToCharArray();

        Robo.Explorar(instrucoes);

        Robo.ExibirCoordenadas();

    }

}

