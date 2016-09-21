using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir les bonus/malus d’un item. 
    /// Date: 2016-09-14
    /// </summary>
    public static class EffetItem
    {
        public static void AjouterEffet(int idItem, int valeurEffet, int typeEffet)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.Item item = context.Items.Where(i => i.Id == idItem).FirstOrDefault();
                item.EffetItems.Add(new Accès_aux_données.EffetItem {ValeurEffet= valeurEffet, TypeEffet = typeEffet });
                context.SaveChanges();

            }

    }

        public static void SupprimerEffet(int idItem, int idEffet)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.EffetItem effet = context.EffetItems.Where(y => y.ItemId == idItem && y.Id == idEffet).FirstOrDefault();
                if (effet != null)
                {
                    context.EffetItems.Remove(effet);
                    context.SaveChanges();
                }

            }
        }

        public static void ModifierEffet(int idItem, int idEffet, int valeurEffet, int typeEffet)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.EffetItem effet = context.EffetItems.Where(y => y.ItemId == idItem && y.Id == idEffet).FirstOrDefault();
                if (effet != null)
                {
                    effet.TypeEffet = typeEffet;
                    effet.ValeurEffet = valeurEffet;
                    context.SaveChanges();
                }

            }

        }
    }
}
