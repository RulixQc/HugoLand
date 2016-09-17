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
        public static void CréerClasse(string nomClasse, string description, int statStr, int statDex, int statInt, int statVit, int mondeId)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var classe = context.Set<Accès_aux_données.Classe>();
                classe.Add(new Accès_aux_données.Classe() { NomClasse = nomClasse, Description = description, StatBaseStr = statStr, StatBaseDex = statDex, StatBaseInt = statInt, StatBaseVitalite = statVit, MondeId = mondeId });
                context.SaveChanges();
            }
        }

        public static void SupprimerClasse(int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Classe classe = context.Classes.Where(c => c.Id == id).FirstOrDefault();
                if (classe != null)
                    context.Classes.Remove(classe);
                context.SaveChanges();
            }
        }

        public static void ModifierClasse(int id, string nomClasse, string description, int statStr, int statDex, int statInt, int statVit, int mondeId)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Classe classe = context.Classes.Where(c => c.Id == id).FirstOrDefault();
                if (classe != null)
                {
                    classe.NomClasse = nomClasse;
                    classe.Description = description;
                    classe.StatBaseStr = statStr;
                    classe.StatBaseDex = statDex;
                    classe.StatBaseInt = statInt;
                    classe.StatBaseVitalite = statVit;
                    classe.MondeId = mondeId;
                }
                context.SaveChanges();
            }
        }

        public static List<Accès_aux_données.Classe> RetournerClassesParMonde(int mondeFiltreId)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                List<Accès_aux_données.Classe> classes = new List<Accès_aux_données.Classe>();
                foreach (Accès_aux_données.Classe classe in context.Classes)
                {
                    if (classe.MondeId == mondeFiltreId)
                    {
                        classes.Add(classe);
                    }
                }
                return classes;
            }
        }

        public static Accès_aux_données.Classe TrouverClasse(Accès_aux_données.Hero hero)
        {
            return hero.Classe;
        }
    }
}