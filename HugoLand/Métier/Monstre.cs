using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir les monstres dans le monde. 
    /// Date: 2016-09-14
    /// </summary>
    public static class Monstre
    {
        public static void CréerMonstre()
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var monstres = context.Set<Accès_aux_données.Monstre>();
                monstres.Add(new Accès_aux_données.Monstre() { Classes = null, Description = "", Heros = null, Id = 0, Items = null, LimiteX = 500, LimiteY = 500, Monstres = null, ObjetMondes = null });
                context.SaveChanges();
            }
        }

        public static void TuerMonstre()
        {

        }

        public static void ModifierMonstre()
        {

        }
    }
}
