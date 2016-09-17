using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de stocker les informations relatives à un monde (carte) dans lequel évoluera le jeu. Cette carte spécifie les limites x, y du monde.
    /// Date: 2016-09-14
    /// </summary>
    public static class Monde
    {
        public static void CréerMonde()
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var mondes = context.Set<Accès_aux_données.Monde>();
                mondes.Add(new Accès_aux_données.Monde() { Classes = null, Description = "", Heros = null, Id = 0, Items = null, LimiteX = 500, LimiteY = 500, Monstres = null, ObjetMondes = null });
                context.SaveChanges();
            }
        }

        public static void SupprimerMonde()
        {
            //FUCK OFF
        }

        public static void ChangerLimites(int limiteX, int limiteY)
        {
            
        }

        public static void ChangerDescription(string description)
        {

        }

        public static void RetournerMondes()
        {

        }
    }
}
