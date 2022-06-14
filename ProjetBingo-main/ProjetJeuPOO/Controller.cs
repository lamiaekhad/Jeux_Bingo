using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Controller program = new Controller();
            program.selectchoice();
        }

        string nomutilisateur;
        private void AfficherMenu()
        {
            Console.WriteLine("Veillez saisir votre nom:  ");
            nomutilisateur = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Menu jeux: ");
            Console.WriteLine();
            Console.WriteLine("1. Bingo");
            Console.WriteLine("2. Simili Black Jack");
            Console.WriteLine("3. Le Pendu");
            Console.WriteLine();
            Console.Write("Bonjour "+ nomutilisateur + " fait ton choix: ");
            Console.WriteLine();

        }
        private void selectchoice()
        {
            int option = 0;
            do
            {
                AfficherMenu();
                dochoice();
                

            } while (option > 3 || option < 1);
            

        }
        private void dochoice()
        {
            Bingocontroller Bingo = new Bingocontroller();

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                  Bingo.selectchoiceBingo();
                    break;

                case "2":

                    break;

                case "3":

                    break;

            }
           
        }

      
    }
}
