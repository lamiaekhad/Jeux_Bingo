using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
     class Bingocontroller
    {
        AnnonceurCard Annonceur = new AnnonceurCard();
        
        BingoCard card = new BingoCard();
        BingoCard card2 = new BingoCard();
        BingoCard card3 = new BingoCard();
        BingoCard card4 = new BingoCard();

        BingoCard bingocard = new BingoCard();
        public Bingocontroller() { }
        public void MenuBingo()
        {
            Console.WriteLine("Choisir l'option suivante :");
            Console.WriteLine();
            Console.WriteLine("1. Initialiser une nouvelle partie");
            Console.WriteLine("2. Visualiser une des cartes du joueur");
            Console.WriteLine("3. Visualiser la carte de l’annonceur");
            Console.WriteLine("4. Tirez une boule");
            Console.WriteLine("5. Fin de partie");
            Console.ReadKey();
        }

        public void selectchoiceBingo()
        {
            Console.Clear();
            int option1 = 0;
            do
            {
                MenuBingo();
                DoChoiceBingo();

            } while (option1 > 5 || option1 < 1);

        }

        public void DoChoiceBingo()
        {
            string choix2 = Console.ReadLine();

                switch (choix2)
                {
                    case "1":
                        InitierPartie();

                        break;

                    case "2":
                         showcard();

                        break;

                    case "3":
                         Annonceur.Affichercardannonceur();

                        break;

                    case "4":

                        break;

                    case "5":

                        break;
                }

        }
      

        public void InitierPartie()
        {
            QuantiteOfCard();
        }

        public void QuantiteOfCard()
        {
            Console.Clear();
           

            int quantite;
            Console.WriteLine("Combiem de cartes desirez-vous : (max de 4)");
            quantite = int.Parse(Console.ReadLine());

            if (quantite == 1)
            {
                card.remplirCard();
                
            }
            else if (quantite == 2)
            {
                card.remplirCard();
                card2.remplirCard();
            }
            else if (quantite == 3)
            {
                card.remplirCard();
                card2.remplirCard();
                card3.remplirCard();
                
            }
            else if (quantite == 4)
            {
                card.remplirCard();
                card2.remplirCard();
                card3.remplirCard();
                card4.remplirCard();
            }
            Console.ReadKey();
        }

        public void showcard()
        {
            int choice;
            Console.Write("Quelle carte voulez vous voir: ");
            choice = int.Parse(Console.ReadLine());
            
            
            if (choice == 1)
            {
                card.visualiserCarte();

            }
            else if (choice == 2)
            {
             
                card2.visualiserCarte();
            }
            else if (choice == 3)
            {
               
                card3.visualiserCarte();

            }
            else if (choice== 4)
            {
                
                card4.visualiserCarte();
            }
            Console.ReadKey();
        }

    }
}
