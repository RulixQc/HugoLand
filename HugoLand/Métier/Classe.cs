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
        public static int CréerClasse(string nom, Accès_aux_données.Monde monde)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                /*try
                {*/
                    //context.TableName.AddObject(TableEntityInstance);
                    var classes = context.Set<Accès_aux_données.Classe>();
                    classes.Add(new Accès_aux_données.Classe() { Description = "", Id = 0, Monde = monde, Heros = null, MondeId = 0, StatBaseDex = 0, StatBaseInt = 0, StatBaseStr = 0, StatBaseVitalite = 0,NomClasse = nom });
                    context.SaveChanges();
                /*}
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        Console.WriteLine("ERROR WITH CLASSES: " + ex.InnerException.Message);
                    else
                        Console.WriteLine("ERROR WITH CLASSES2: " + ex.Message);
                }*/
            }
            return 0;
        }

        public static void SupprimerClasse()
        {

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
