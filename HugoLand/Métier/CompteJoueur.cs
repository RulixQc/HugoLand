using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de créer les paramètres de connexion du joueur. Une fois connecté, le joueur se connectera et sélectionnera le héros avec lequel il désire jouer.
    /// Date: 2016-09-14
    /// </summary>
    public static class CompteJoueur
    {
        public static void CréerJoueur(string prénom, string nom, string courriel, string nomUtilisateur, string motDePasse, ICollection<Accès_aux_données.Hero> heros = null, int typeUtilisateur = 0)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var joueurs = context.Set<Accès_aux_données.CompteJoueur>();
                joueurs.Add(new Accès_aux_données.CompteJoueur() { Prenom = prénom, Nom = nom, Courriel = courriel, NomUtilisateur = nomUtilisateur, Password = motDePasse, Heros = heros, TypeUtilisateur = typeUtilisateur });
                context.SaveChanges();
            }
        }

        public static void SupprimerJoueur(string nomUtilisateur)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var joueurs = context.Set<Accès_aux_données.CompteJoueur>();
                joueurs.Remove(joueurs.FirstOrDefault(j => j.NomUtilisateur == nomUtilisateur));
                context.SaveChanges();
            }
        }

        public static void ModiferParamètres()
        {

        }

        public static void ValiderConnexion()
        {

        }
    }
}
