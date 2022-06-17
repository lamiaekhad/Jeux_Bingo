using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Card 
    { 
        public int Value;
        public static string[] SuitsArray = new string[] { "♥", "♦", "♣", "♠" };
        public string Suit;

        public Card() { }
        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public Card(string input)
        {
            string tempValue = "";
            string suitSentence = "";
            switch (Value)
            {
                case 11:
                    tempValue = "J";
                    break;
                case 12:
                    tempValue = "Q";
                    break;
                case 13:
                    tempValue = "K";
                    break;
                case 14:
                    tempValue = "Ace";
                    break;
                default:
                    tempValue = Value.ToString();
                    break;
            }
            switch (Suit)
            {
                case "Hearts":
                    suitSentence = " of Hearts";
                    break;
                case "Diamonds":
                    suitSentence = " of Diamonds";
                    break;
                case "Clubs":
                    suitSentence = " of Clubs";
                    break;
                case "Spades":
                    suitSentence = " of Spades";
                    break;
            }
            input = tempValue + suitSentence;
        }

    }
}
