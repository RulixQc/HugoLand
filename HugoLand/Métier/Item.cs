using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet les items que peuvent utiliser les héros. Lorsqu’un joueur met un item dans son inventaire, la position x, y de l’item est mise à zéro.
    /// Date: 2016-09-14
    /// </summary>
    public static class Item
    {
        public static void CréerItem(string Description, ICollection<Accès_aux_données.EffetItem> effet, int imageid,
            ICollection<Accès_aux_données.InventaireHero> invHe, Accès_aux_données.Monde monde, int mondeid, int niveau, string nom, int poids, int quantite,
            bool ramasse, int reqForce, int reqDex, int reqEnd, int reqInt, int reqNiv, byte[] rowVersion, decimal valeur)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var items = context.Set<Accès_aux_données.Item>();
                items.Add(new Accès_aux_données.Item()
                {
                    x = 0,
                    y = 0,
                    Description = Description,
                    EffetItems = effet,
                    ImageId = imageid,
                    InventaireHeroes = invHe,
                    Monde = monde,
                    MondeId = mondeid,
                    Niveau = niveau,
                    Nom = nom,
                    Poids = poids,
                    Quantite = quantite,
                    Ramasse = ramasse,
                    ReqDexterite = reqDex,
                    ReqEndurance = reqEnd,
                    ReqForce = reqForce,
                    ReqIntelligence = reqInt,
                    ReqNiveau = reqNiv,
                    RowVersion = rowVersion,
                    ValeurArgent = valeur
                });
                context.SaveChanges();
            }
        }

        public static void SupprimerItem(Accès_aux_données.Item item)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                if (item != null)
                    context.Items.Remove(item);
                context.SaveChanges();
            }
        }

        public static void ModifierQuantité(Accès_aux_données.Item item, int quantite)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                if (item != null)
                    item.Quantite = quantite;
                context.SaveChanges();
            }
        }
    }
}
