using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard 
    {
        private int numbre1;
        private char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' }; 
        private int[,] matrix = new int[5,5];
        private Random random = new Random();

        public char[] BingoLetters { get => bingoLetters; set => bingoLetters = value; }
        public Random Random { get => random; set => random = value; }
        public int Numbre1 { get => numbre1; set => numbre1 = value; }
        public int[,] Matrix { get => matrix; set => matrix = value; }

        public void remplirCard()
        {
            AfficherNombresCardB();
            AfficherNombresCardI();
            AfficherNombresCardN();
            AfficherNombresCardG();
            AfficherNombresCardO();
        }

        public void afficherBingo()
        {
            Console.WriteLine(bingoLetters[0] + "\t" + bingoLetters[1] + "\t" + bingoLetters[2] + "\t" + bingoLetters[3] + "\t" + bingoLetters[4]);

        }
        public void visualiserCarte()
        {
            //affichage bingo card
            afficherBingo();


            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

      

        public void AfficherNombresCardB()
        {
            int randresult;
            
            int i=0;
            
            for (i = 0; i < 5; i++)
            {
                do
                {
                    randresult = Random.Next(1,15);

                } while (executerconditionB(randresult));

                Matrix[i, 0] = randresult;
              
            }
          
        }
        public bool executerconditionB(int numbertovalid)
        {
            int i = 0;
            

            bool exist = false;

            for (i = 0; i < 5; i++)
            {
                if (Matrix[i, 0] == numbertovalid)
                {
                    exist = true;
                }

            }
            return exist;

        }
        public void AfficherNombresCardI()
        {
            int randresult;

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                do
                {
                    randresult = Random.Next(16,30);

                } while (executerconditionI(randresult));
                Matrix[i, 1] = randresult;

            }

        }

   
        public bool executerconditionI(int numbertovalid)
        {
            int i = 0;

            bool exist = false;

            for (i = 0; i < 5; i++)
            {
                if (Matrix[i, 1] == numbertovalid)
                {
                    exist = true;
                }

            }
            return exist;

        }

        public void AfficherNombresCardN()
        {
            int randresult;

            int i = 0;
            int free = 0;
            for (i = 0; i < 5; i++)
            {
                do
                {
                    randresult = Random.Next(31, 45);

                } while (executerconditionN(randresult));
                Matrix[i, 2] = randresult;
                Matrix[2, 2] = free;
              

            }

        }

        public bool executerconditionN(int numbertovalid)
        {
            int i = 0;

            bool exist = false;

            for (i = 0; i < 5; i++)
            {
                if (Matrix[i, 2] == numbertovalid)
                {
                    exist = true;
                }

            }
            return exist;

        }
        public void AfficherNombresCardG()
        {
            int randresult;

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                do
                {
                    randresult = Random.Next(46,60);

                } while (executerconditionG(randresult));
                Matrix[i, 3] = randresult;

            }

        }

        public bool executerconditionG(int numbertovalid)
        {
            int i = 0;

            bool exist = false;

            for (i = 0; i < 5; i++)
            {
                if (Matrix[i, 3] == numbertovalid)
                {
                    exist = true;
                }

            }
            return exist;

        }
        public void AfficherNombresCardO()
        {
            int randresult;

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                do
                {
                    randresult = Random.Next(61, 75);

                } while (executerconditionO(randresult));
                Matrix[i, 4] = randresult;

            }

        }

        public bool executerconditionO(int numbertovalid)
        {
            int i = 0;

            bool exist = false;

            for (i = 0; i < 5; i++)
            {
                if (Matrix[i, 4] == numbertovalid)
                {
                    exist = true;
                }

            }
            return exist;

        }
   
    }
}
