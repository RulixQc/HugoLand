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
            /*CompteJoueur.SupprimerJoueur("Username");
            CompteJoueur.SupprimerJoueur("Username");
            CompteJoueur.SupprimerJoueur("Username");
            CompteJoueur.CréerJoueur("David", "Girouard", "dgirouard@hugoland.com", "RulixQc", "Password01$");
            CompteJoueur.CréerJoueur("Olivier", "Rouillard", "orouillard@hugoland.com", "Holyverz", "Password01$");
            CompteJoueur.CréerJoueur("Yanik", "Lyth", "ylyth@hugoland.com", "LuckyStreak", "Password01$");*/
            /*Console.WriteLine("Les joueurs:");
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                try
                {
                    foreach(Accès_aux_données.CompteJoueur joueur in context.CompteJoueurs)
                    {
                        Console.WriteLine("Username: " + joueur.NomUtilisateur + "\tPassword: " + joueur.Password);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR WITH CLASSES: " + ex.InnerException.Message);
                }
            }*/
            //Hero.CréerHéros("David");
            /*Console.WriteLine("Mes héros:");
            foreach(Accès_aux_données.Hero hero in Hero.ListerHéros())
            {
                Console.WriteLine(hero.NomHero);
            }*/
            //Hero.SupprimerHéros(0);
            //Console.ReadKey();
        }
    }
}
