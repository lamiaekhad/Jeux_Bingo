using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo 
{
     class Bingocontroller 
    {
        AnnonceurCard Annonceur = new AnnonceurCard();
        BingoCard card;
        BingoCard card2;
        BingoCard card3;
        BingoCard card4;
        Boulier boulier = new Boulier();
        BingoBall ball;

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
        }

        public void selectchoiceBingo()
        {
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
               QuantiteOfCard();
               break;

               case "2":
               showcard();
               break;
               
               case "3":
               Annonceur.Affichercardannonceur();
               break;

               case "4":
               docase4();
               break;

               case "5":
                finpartie();
               break;

               default:
               Console.WriteLine("choix non valide");
               break;
            }
        }
      
        public void docase4()
        {
            //tirer un boule du boulier
            ball = boulier.getRanbomBall();
            // retier les boules de la carte joueur
            card.retier(ball.Number);
            card2.retier(ball.Number);
            card3.retier(ball.Number);
            card4.retier(ball.Number);
            //BINGO gagner
            if (quantite == 1)
            {
                card.gagnerpartie();

            }else if(quantite == 2)
            {
                card.gagnerpartie();
                card2.gagnerpartie();

            }
            else if (quantite == 3)
            {
                card.gagnerpartie();
                card2.gagnerpartie();
                card3.gagnerpartie();

            }
            else if (quantite == 4)
            {
                card.gagnerpartie();
                card2.gagnerpartie();
                card3.gagnerpartie();
                card4.gagnerpartie();
            }
            // remplir carte annonceur
            Annonceur.remplircartannonceurwithball(ball.Number);
        }
        int quantite;
        public void QuantiteOfCard()
        {
            
            //creer les cartes
            card = new BingoCard();
            card2 = new BingoCard();
            card3 = new BingoCard();
            card4 = new BingoCard();
            // faire choix de nombre de carte a jouer
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
            else
            {
                Console.WriteLine();
                Console.WriteLine("choix non valide");
                Console.WriteLine();
            }
        }

        public void showcard()
        {
            //visualiser les cartes
            int choice;
            Console.Write("Quelle carte voulez vous voir: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1 )
            {
                card.visualiserCarte();
            }
            else if (choice == 2 )
            {
                card2.visualiserCarte();
            }
            else if (choice == 3 )
            {
               card3.visualiserCarte();
            }
            else if (choice == 4)
            {
               card4.visualiserCarte();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("choix non valide");
                Console.WriteLine();
            }
        }

        public void finpartie()
        {
            Console.WriteLine( "1- Demarer une nouvelle partie");
            Console.WriteLine("2- Devenir au menu principal");
            Console.WriteLine();
            string choix2 = Console.ReadLine();

            switch (choix2)
            {
                case "1":
                    QuantiteOfCard();
                    break;

                case "2":
                    Controller control = new Controller();
                    control.selectchoice();
                    break;
            }
         
        }
    }
}
