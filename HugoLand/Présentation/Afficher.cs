using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Présentation
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Permet d'afficher le contenu des données de chaque objet
    /// Date: 2016-09-14
    /// </summary>
    public static class Afficher
    {

        public static void AfficherMonde()
        {

        }

        public static void AfficherMonstre()
        {

        }

        public static void AfficherObjectmonde()
        {

        }

        public static void AfficherJoueurs()
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                try
                {
                    foreach (Accès_aux_données.CompteJoueur joueur in context.CompteJoueurs)
                    {
                        Console.WriteLine("Username: " + joueur.NomUtilisateur + "\tPassword: " + joueur.Password + "\tFullname: " + joueur.Prenom + " " + joueur.Nom);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR WITH CLASSES: " + ex.InnerException.Message);
                }
            }
        }

        public static void AfficherItem()
        {

        }

        public static void AfficherEffetItem()
        {

        }

        public static void AfficherHéro()
        {

        }

        public static void AfficherClasses()
        {

        }

    }
}
