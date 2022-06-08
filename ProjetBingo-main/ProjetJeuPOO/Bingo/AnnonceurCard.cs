using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    internal class AnnonceurCard
    {
        // List<int> annnceur = new List<int>();

        private int[,] annonceur = new int[14,4];

        BingoCard BINGOCARD = new BingoCard();

        public int[,] Annonceur { get => annonceur; set => annonceur = value; }

        public void Remplircardannonceur()
        {
            int a;
            int i, j;
            for (i = 0; i <Annonceur.Length; i++)
            {
                for (j = 0; j < Annonceur.Length; j++)
                {
                    

                }

            }

        }
        public void Affichercardannonceur()
        {
            
            int i, j;
            for (i = 0; i <Annonceur.Length; i++)
            {
                for (j = 0; j <Annonceur.Length; j++)
                {
                    Console.WriteLine(Annonceur[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //BINGOCARD.afficherBingo();
        //int i;

        //for (i=0;i<15;i++)
        //{
        //    annnceur.Add(0);

        //}
        //foreach (int a in annnceur)
        //{
        //    Console.WriteLine(a);
        //}
        //Console.WriteLine();
    }


    
}
