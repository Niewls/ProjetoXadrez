using ProjetoXadrez.tabuleiro;

namespace ProjetoXadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.GetPeca(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    System.Console.Write(tab.GetPeca(i, j) + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}