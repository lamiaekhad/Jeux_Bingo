using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class BlackJackController
    {
        public void MenuBlackJack()
        {
            Console.WriteLine("1- Tirer une carte");
            Console.WriteLine("2- Conserver la mise");
        }

        public void selectchoiceBJ()
        {

            int option1 = 0;
            do
            {
                MenuBlackJack();
                DoChoiceBJ();

            } while (option1 > 2 || option1 < 1);
        }
        public void DoChoiceBJ()
        {
            string choix2 = Console.ReadLine();
            switch (choix2)
            {
                case "1":
                    Deck.FillDeck();
                    Deck.tirercarte();
                    break;

                case "2":
                   
                    break;


                default:
                    Console.WriteLine("choix non valide");
                    break;
            }
        }

    }
}
