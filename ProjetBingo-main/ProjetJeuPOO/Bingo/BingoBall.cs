using System;
using System.Collections.Generic;
using System.Text;

//Classe représentant un objet boule 

namespace ProjetJeuPOO.Bingo
{
    class BingoBall
    {
        private int number;
        private char letter;  // À utiliser ou à ne pas utiliser, ça dépend de votre approche
        
        public int Number { get => number; set => number = value; }
        public char Letter { get => letter; set => letter = value; }

        public BingoBall(int numeroball)
        {
            this.number = numeroball;
        }
        public BingoBall()
        {
        }
    }
}
