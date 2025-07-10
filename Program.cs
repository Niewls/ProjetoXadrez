using ProjetoXadrez;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        System.Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

    Tela.ImprimirTabuleiro(partida.Tab);

    Console.ReadLine();
}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}

