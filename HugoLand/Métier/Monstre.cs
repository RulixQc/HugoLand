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
        public static void CréerMonstre(string nom, int niveau, int xParam, int yParam, int statPV, float dmgMin, float dmgMax, int mondeId, int imageId, byte[] rowVersion)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var monstres = context.Set<Accès_aux_données.Monstre>();
                monstres.Add(new Accès_aux_données.Monstre() { Nom = nom, Niveau = niveau, x = xParam, y = yParam, StatPV = statPV, StatDmgMin = dmgMin, StatDmgMax = dmgMax, MondeId = mondeId, ImageId = imageId, RowVersion = rowVersion });
                context.SaveChanges();
            }
        }

        public static void TuerMonstre(int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Monstre monstre = context.Monstres.Where(m => m.Id == id).FirstOrDefault();
                if (monstre != null)
                    context.Monstres.Remove(monstre);
                context.SaveChanges();
            }
        }

        public static void ModifierMonstre(int id, string nom, int niveau, int xParam, int yParam, int statPV, float dmgMin, float dmgMax, int mondeId, int imageId, byte[] rowVersion)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Monstre monstre = context.Monstres.Where(m => m.Id == id).FirstOrDefault();
                if (monstre != null)
                {
                    monstre.Nom = nom;
                    monstre.Niveau = niveau;
                    monstre.x = xParam;
                    monstre.y = yParam;
                    monstre.StatPV = statPV;
                    monstre.StatDmgMin = dmgMin;
                    monstre.StatDmgMax = dmgMax;
                    monstre.MondeId = mondeId;
                    monstre.ImageId = imageId;
                    monstre.RowVersion = rowVersion;
                }
                context.SaveChanges();
            }
        }
    }
}