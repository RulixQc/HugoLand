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
        public static void CréerMonde(List<Accès_aux_données.Classe> classes, string description, int Lx, int Ly)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var mondes = context.Set<Accès_aux_données.Monde>();
                mondes.Add(new Accès_aux_données.Monde() { Classes = classes, Description = description, Heros = null, Items = null, LimiteX = Lx, LimiteY = Ly, Monstres = null, ObjetMondes = null });
                context.SaveChanges();
            }
        }

        public static void SupprimerMonde(int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Monde monde = context.Mondes.Where(m => m.Id == id).FirstOrDefault();
                if (monde != null)
                    context.Mondes.Remove(monde);
                context.SaveChanges();
            }
        }

        public static void ChangerLimites(int limiteX, int limiteY, int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Monde monde = context.Mondes.Where(m => m.Id == id).FirstOrDefault();
                if (monde != null)
                {
                    monde.LimiteX = limiteX;
                    monde.LimiteY = limiteY;
                }
                context.SaveChanges();
            }
        }

        public static void ChangerDescription(string description, int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Monde monde = context.Mondes.Where(m => m.Id == id).FirstOrDefault();
                if (monde != null)
                    monde.Description = description;
                context.SaveChanges();
            }
        }

        public static List<Accès_aux_données.Monde> RetournerMondes()
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                List<Accès_aux_données.Monde> mondes = new List<Accès_aux_données.Monde>();
                foreach (Accès_aux_données.Monde monde in context.Mondes)
                {
                    mondes.Add(monde);
                }
                return mondes;
            }
        }
    }
}