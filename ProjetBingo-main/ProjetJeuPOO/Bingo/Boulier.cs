using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier
    {
        private List<BingoBall> balls = new List<BingoBall>();
      
        internal List<BingoBall> Balls { get => balls; set => balls = value; }

        public Boulier()
        {
            genererball();
        }

        private void genererball()
        {
            for(int i = 1; i < 76; i++)
            {
                this.add(new BingoBall(i));
            }
        }
        public void add(BingoBall element)
        {
            this.balls.Add(element);
        }
        public BingoBall getRanbomBall()
        {
            Random random = new Random();
            var rand = random.Next(balls.Count);
            BingoBall bingoball = this.balls[rand];
            //retirer une boule du boulier
            balls.Remove(bingoball);
            //affichage le numero de la boule
            Console.WriteLine();
            Console.WriteLine("Boule:  "+ bingoball.Number);
            Console.WriteLine();
            return bingoball;
        }
       
        public int getSize()
        {
            return 0;
          
        }

        public bool isEmpty()
        {
            return true;
        }

        public void restartBoulier()
        {
            return  ;
        }
    }
}
