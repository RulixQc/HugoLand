using HugoLand.Métier;
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
            foreach (Accès_aux_données.Monde monde in Monde.RetournerMondes())
            {
                Console.WriteLine("ID: " + monde.Id + "\tDescription: " + monde.Description + "\tLimite X: " + monde.LimiteX + "\tLimite Y: " + monde.LimiteY);
            }
        }

        public static void AfficherMonstre()
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                foreach (Accès_aux_données.Monstre monstre in context.Monstres)
                {
                    Console.WriteLine("ID: " + monstre.Id + "\tNom: " + monstre.Nom + "\tNiveau: " + monstre.Niveau + "\tHP: " + monstre.StatPV);
                }
            }
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
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                foreach (Accès_aux_données.Item item in context.Items)
                {
                    Console.WriteLine("ID: " + item.Id + "\tNom: " + item.Nom + "\tDescription: " + item.Description + "\tValeur: " + Math.Round((double)item.ValeurArgent, 0).ToString() + "$\tNiveau: " + item.Niveau);
                }
            }
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
