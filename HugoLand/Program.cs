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

        const string version = "1.3";

        static void Main(string[] args)
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("==================== WELCOME TO HUGOLAND V" + version + " ====================");
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
                        Console.Write("Nom: ");
                        string nomItem = Console.ReadLine();
                        Console.Write("Description: ");
                        string descriptionItem = Console.ReadLine();
                        Console.Write("Monde ID: ");
                        int mondeIdItem = 0;
                        int.TryParse(Console.ReadLine(), out mondeIdItem);
                        Console.Write("Image ID: ");
                        int imageIdItem = 0;
                        int.TryParse(Console.ReadLine(), out imageIdItem);
                        Console.Write("Niveau: ");
                        int niveauItem = 0;
                        int.TryParse(Console.ReadLine(), out niveauItem);
                        Console.Write("Poids: ");
                        int poidsItem = 0;
                        int.TryParse(Console.ReadLine(), out poidsItem);
                        Console.Write("Quantité: ");
                        int quantitéItem = 0;
                        int.TryParse(Console.ReadLine(), out quantitéItem);
                        Console.Write("Ramassé (true/false): ");
                        bool ramassé = false;
                        bool.TryParse(Console.ReadLine(), out ramassé);
                        Console.Write("Force requise: ");
                        int forceItem = 0;
                        int.TryParse(Console.ReadLine(), out forceItem);
                        Console.Write("Dextérité requise: ");
                        int dexItem = 0;
                        int.TryParse(Console.ReadLine(), out dexItem);
                        Console.Write("Endurance requise: ");
                        int endItem = 0;
                        int.TryParse(Console.ReadLine(), out endItem);
                        Console.Write("Intelligence requise: ");
                        int intItem = 0;
                        int.TryParse(Console.ReadLine(), out intItem);
                        Console.Write("Niveau requis: ");
                        int nivItem = 0;
                        int.TryParse(Console.ReadLine(), out nivItem);
                        Console.Write("Valeur ($): ");
                        decimal valItem = 0;
                        decimal.TryParse(Console.ReadLine(), out valItem);
                        Item.CréerItem(descriptionItem, null, imageIdItem, null, null, mondeIdItem, niveauItem, nomItem, poidsItem, quantitéItem, ramassé, forceItem, dexItem, endItem, intItem, nivItem, null, valItem);
                        break;
                    case "list_item":
                        Afficher.AfficherItem();
                        break;
                    case "create_world":
                        Console.Write("Description: ");
                        string descriptionMonde = Console.ReadLine();
                        Console.Write("Limite X: ");
                        int x = 0;
                        int y = 0;
                        int.TryParse(Console.ReadLine(), out x);
                        Console.Write("Limite Y: ");
                        int.TryParse(Console.ReadLine(), out y);
                        Monde.CréerMonde(null, descriptionMonde, x, y);
                        break;
                    case "list_world":
                        Afficher.AfficherMonde();
                        break;
                    case "delete_world":
                        Console.Write("ID: ");
                        int id = 0;
                        int.TryParse(Console.ReadLine(), out id);
                        Monde.SupprimerMonde(id);
                        break;
                    case "create_monster":
                        Console.Write("Nom: ");
                        string nomMonster = Console.ReadLine();
                        Console.Write("Niveau: ");
                        int niveauMonster = 0;
                        int.TryParse(Console.ReadLine(), out niveauMonster);
                        Console.Write("X: ");
                        int xMonster = 0;
                        int.TryParse(Console.ReadLine(), out xMonster);
                        Console.Write("Y: ");
                        int yMonster = 0;
                        int.TryParse(Console.ReadLine(), out yMonster);
                        Console.Write("HP: ");
                        int statPVMonster = 0;
                        int.TryParse(Console.ReadLine(), out statPVMonster);
                        Console.Write("Damage Max: ");
                        int statDamageMinMonster = 0;
                        int.TryParse(Console.ReadLine(), out statDamageMinMonster);
                        Console.Write("Damage Min: ");
                        int statDamageMaxMonster = 0;
                        int.TryParse(Console.ReadLine(), out statDamageMaxMonster);
                        Console.Write("Monde ID: ");
                        int mondeIdMonster = 0;
                        int.TryParse(Console.ReadLine(), out mondeIdMonster);
                        Console.Write("Image ID: ");
                        int imageIdMonster = 0;
                        int.TryParse(Console.ReadLine(), out imageIdMonster);
                        Monstre.CréerMonstre(nomMonster, niveauMonster, xMonster, yMonster, statPVMonster, statDamageMinMonster, statDamageMaxMonster, mondeIdMonster, imageIdMonster, null);
                        break;
                    case "delete_monster":
                        Console.Write("ID: ");
                        int idMonster = 0;
                        int.TryParse(Console.ReadLine(), out idMonster);
                        Monstre.TuerMonstre(idMonster);
                        break;
                    case "list_monster":
                        Afficher.AfficherMonstre();
                        break;
                    case "clear":
                        Console.Clear();
                        Console.WriteLine("==================================================================");
                        Console.WriteLine("==================== WELCOME TO HUGOLAND V" + version + " ====================");
                        Console.WriteLine("==================================================================");
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "help":
                        Console.WriteLine("***** HELP *****");
                        Console.WriteLine("user_create\nuser_list\nuser_delete\nadd_item\nlist_item\ncreate_world\ndelete_world\nlist_world\ncreate_monster\ndelete_monster\nlist_monster\nclear\nexit\nhelp");
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
