using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoLand.Métier;
using HugoLand.Présentation;

namespace HugoLand
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: 
    /// Date: 2016-09-14
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("==================== WELCOME TO HUGOLAND V1.0 ====================");
            Console.WriteLine("==================================================================");
            while (true)
            {
                Console.Write("Command: ");
                switch (Console.ReadLine())
                {
                    case "user_create":
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        Console.Write("Firstname: ");
                        string firstname = Console.ReadLine();
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        CompteJoueur.CréerJoueur(firstname, name, email, username, password);
                        Console.WriteLine("user_created");
                        break;
                    case "user_delete":
                        Console.Write("Username: ");
                        string username2 = Console.ReadLine();
                        CompteJoueur.SupprimerJoueur(username2);
                        Console.WriteLine("user_deleted");
                        break;
                    case "user_list":
                        Console.WriteLine("Users:");
                        Afficher.AfficherJoueurs();
                        break;
                    case "add_item":
                        Console.Write();
                        break;
                    case "create_world":
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        Console.Write("Limite X: ");
                        int x = 0;
                        int y = 0;
                        int.TryParse(Console.ReadLine(), out x);
                        Console.Write("Limite Y: ");
                        int.TryParse(Console.ReadLine(), out y);
                        Monde.CréerMonde(null, description, x, y);
                        break;
                    case "list_world":
                        foreach(Accès_aux_données.Monde monde in Monde.RetournerMondes())
                        {
                            Console.WriteLine("ID: " + monde.Id + "\tDescription: " + monde.Description + "\tLimite X: " + monde.LimiteX + "\tLimite Y: " + monde.LimiteY);
                        }
                        break;
                    case "delete_world":
                        Console.Write("ID: ");
                        int id = 0;
                        int.TryParse(Console.ReadLine(), out id);
                        Monde.SupprimerMonde(id);
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "help":
                        Console.WriteLine("***** HELP *****");
                        Console.WriteLine("user_create\nuser_list\nuser_delete\nclear\nexit\nhelp");
                        Console.WriteLine("****************");
                        break;
                    default:
                        Console.WriteLine("unknown_command");
                        break;
                }
            }
        }
    }
}
