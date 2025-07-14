using ProjetoXadrez;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        try
        {
            Console.Clear();
            Tela.ImprimirPartida(partida);

            System.Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.Tab.GetPeca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

            System.Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);
            partida.RealizaJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            System.Console.WriteLine(e.Message);
            Console.ReadLine(); 
        }
    }
    Console.ReadLine();
}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}

