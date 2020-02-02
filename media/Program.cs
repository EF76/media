using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine(" Gestion de la Mediatheque");
            Console.WriteLine("1 - Afficher les livres de la médiathèque");
            Console.WriteLine("2 - Ajouter un livre au catalogue de la médiathèque");
            Console.WriteLine("3 - Supprimer un livre du catalogue de la médiathèque");
            Console.WriteLine("4 - Ajouter un membre à la médiathèque");
            Console.WriteLine("5 - Supprimer un membre de la médiathèque");
            Console.WriteLine("6 - Afficher tous les membres de la médiathèque");

            Console.WriteLine("7 - Attribuer un emprunt de livre à un membre");
            Console.WriteLine("8 - Rendu de livre par un membre de la médiathèque");
            Console.WriteLine("9 - Afficher tous les emprunts en cours");
            Console.WriteLine("0 - Sortir");
        }

        static void Main(string[] args)
        {
            int choix;
            
            choix = -1;
            while (choix != 0)
            {
                menu();
                Console.WriteLine("Votre choix ? ");
                choix = Int32.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine(" A Faire");
                        break;
                    case 2:
                        Console.WriteLine(" A Faire");
                        break;
                    case 3:
                        Console.WriteLine(" A Faire");
                        break;
                    case 4:
                        Console.WriteLine(" A Faire");
                        break;
                    case 5:
                        Console.WriteLine(" A Faire");
                        break;
                    case 6:
                        Console.WriteLine(" A Faire");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(" A Faire");
                        break;
                    case 8:
                        Console.WriteLine(" A Faire");
                        break;
                    case 9:
                        Console.WriteLine(" A Faire");
                        break;

                }
            }
            Console.WriteLine("Bye Bye!");
            Console.ReadLine();


        }
    }
}
