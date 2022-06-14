using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    internal class AnnonceurCard
    {
        
        private int[,] annonceur = new int[15, 5];

        BingoCard BINGOCARD = new BingoCard();
        
        public int[,] Annonceur { get => annonceur; set => annonceur = value; }

      
        public void Affichercardannonceur()
        {
            BINGOCARD.afficherBingo();
            
            for (int i = 0; i <15; i++)
            {
                for ( int j = 0; j < 5; j++)
                {
                    Console.Write(Annonceur[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void remplircartannonceurwithball(int numerotiree)
        {
           int i;

           if (numerotiree >= 1 && numerotiree <= 15)
           {
               for (i = 0; i < 15; i++)
               {
                 if(Annonceur[i, 0] == 0)
                 { 
                   Annonceur[i, 0] = numerotiree;
                   break;
                 }
               }

           }
           else if (numerotiree >= 16 && numerotiree <= 30)
           {
           for (i = 0; i < 15; i++)
           {
               if (Annonceur[i, 1] == 0)
               {
                   Annonceur[i, 1] = numerotiree;
                   break;
               }
           }

           }
           else if (numerotiree >= 31 && numerotiree <= 45)
           {
               for (i = 0; i < 15; i++)
               {
                 if (Annonceur[i, 2] == 0)
                 {
                     Annonceur[i, 2] = numerotiree;
                     break;
                 }
               }
           }
           else if (numerotiree >= 46 && numerotiree <= 60)
           {
               for (i = 0; i < 15; i++)
               {
                 if (Annonceur[i, 3] == 0)
                 {
                     Annonceur[i, 3] = numerotiree;
                     break;
                 }
               }
           }
           else if (numerotiree >= 61 && numerotiree <= 75)
           {
               for (i = 0; i < 15; i++)
               {
                  if (Annonceur[i, 4] == 0)
                  {
                      Annonceur[i, 4] = numerotiree;
                      break;
                  }
               }
           }
            
        }
    }

}
