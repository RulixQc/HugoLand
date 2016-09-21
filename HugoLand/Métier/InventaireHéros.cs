using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir l’inventaire d’un héros. Lorsqu’un héros possède ramasse/achète un item, la position x, y de cet item est assigné à zéro. 
    /// Date: 2016-09-14
    /// </summary>
    public static class InventaireHéros
    {
        public static void AjouterItem(int idHero, int idItem)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Hero hero = context.Heros.Where(h => h.Id == idHero).FirstOrDefault();
                Accès_aux_données.Item item = context.Items.Where(x => x.Id == idItem).FirstOrDefault();
                if (hero != null && item != null)
                {
                    var inventaireHero = context.Set<Accès_aux_données.InventaireHero>();
                    inventaireHero.Add(new Accès_aux_données.InventaireHero() {Item = item});
                }

            }

        }

        public static void SupprimerItem(int idhero, int idItem)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.InventaireHero item = context.InventaireHeroes.Where(i => i.IdHero == idhero && i.ItemId == idItem).FirstOrDefault();
                if (item != null)
                {
                    context.InventaireHeroes.Remove(item);
                    context.SaveChanges();
                }

            }
        }

    }
}
