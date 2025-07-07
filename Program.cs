using ProjetoXadrez;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

try
{
    Tabuleiro tab = new(8, 8);

    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

    Tela.ImprimirTabuleiro(tab);

    Console.ReadLine();
}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}

