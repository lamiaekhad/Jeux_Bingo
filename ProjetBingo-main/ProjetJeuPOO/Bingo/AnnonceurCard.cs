using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    internal class AnnonceurCard
    {
        // List<int> annnceur = new List<int>();

        private int[,] annonceur = new int[15, 5];

        BingoCard BINGOCARD = new BingoCard();

        public int[,] Annonceur { get => annonceur; set => annonceur = value; }

        public void Remplircardannonceur()
        {
            
            int i, j;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Annonceur[i, j] = 0;

                }
            }

        }
        public void Affichercardannonceur()
        {
            Remplircardannonceur();
            BINGOCARD.afficherBingo();
            int i, j;
            for (i = 0; i <15; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(Annonceur[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }

    
}
