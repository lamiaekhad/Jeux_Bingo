using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Deck
    {
        public static Card[] deck = new Card[52];
        public static ArrayList myCards = new ArrayList();

        public static void FillDeck()
        {
            int index = 0;
            foreach (string suit in Card.SuitsArray)
            {
                for (int value = 2; value <= 14; value++)
                {
                    Card card = new Card(value, suit);
                    deck[index] = card;
                    index++;
                }
            }
        }
    
        public static void Addtoarraylist()
        {
            for (int i = 0; i < 52; i++)
            {
                myCards.Add(deck[i].Value + "  " + deck[i].Suit);
            }
        }
        public static void tirercarte()
        {
            Addtoarraylist();
            Random random = new Random();
            var rand = random.Next(myCards.Count);
            //retirer la carte du deck
            myCards.Remove(myCards[rand]);
            Console.WriteLine(myCards[rand]);
        }
      
    }
}
