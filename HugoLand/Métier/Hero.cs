using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir le héros d’un joueur.  
    /// Date: 2016-09-14
    /// </summary>
    public static class Hero
    {
        public static void CréerHéros(string nom)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                try
                {
                    var result = context.CreateHero(nom, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, false);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }

        public static void SupprimerHéros(int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                context.DeleteHero(id);
            }
        }

        public static void ModifierValeurs()
        {
            
        }

        public static void RetournerProximité(ref Accès_aux_données.ObjetMonde objetMonde, ref Accès_aux_données.Monstre monstre, ref Accès_aux_données.Item item, ref Accès_aux_données.Hero héro)
        {
            
        }

        public static List<Accès_aux_données.Hero> ListerHéros()
        {
            List<Accès_aux_données.Hero> heros = new List<Accès_aux_données.Hero>();
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                foreach(Accès_aux_données.Hero hero in context.Heros)
                {
                    heros.Add(hero);
                }
            }
            return heros;
        }

        public static void DéplacerHéros()
        {

        }
    }
}
