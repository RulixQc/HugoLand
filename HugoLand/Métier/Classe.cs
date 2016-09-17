using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir les classes associées aux héros du jeu. Chaque classe attribue des bonus/malus à un héros.
    /// Date: 2016-09-14
    /// </summary>
    public static class Classe
    {
        public static void CréerClasse(string nom, Accès_aux_données.Monde monde, int statBaseDex, int statBaseInt, int statBaseStr, int statBaseVitalite, string description)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var classes = context.Set<Accès_aux_données.Classe>();
                classes.Add(new Accès_aux_données.Classe() { Description = description, Monde = monde, Heros = null, MondeId = monde.Id, StatBaseDex = statBaseDex, StatBaseInt = statBaseInt, StatBaseStr = statBaseStr, StatBaseVitalite = statBaseVitalite, NomClasse = nom });
                context.SaveChanges();
            }
        }

        public static void SupprimerClasse()
        {
            // wat up squirrel-face
        }

        public static void ModifierClasse()
        {

        }

        public static void RetournerClassesParMonde(int clé)
        {

        }

        public static Accès_aux_données.Classe TrouverClasse(Accès_aux_données.Hero hero)
        {
            return hero.Classe;
        }
    }
}
