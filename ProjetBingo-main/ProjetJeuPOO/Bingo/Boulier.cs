using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier
    {
        public void add(BingoBall element)
        {
         
        }

        public BingoBall getRanbomBall()
        {
            return null;
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
