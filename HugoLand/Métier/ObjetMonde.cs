using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLand.Métier
{

    /// <summary>
    /// Auteurs: David Girouard, Olivier Rouillard, Yanik Lyth
    /// Description: Cette table permet de définir les éléments du décor dans le monde. Par exemple, cette table définira un rocher, de l’eau, etc. à une position x, y.
    /// Date: 2016-09-14
    /// </summary>
    public static class ObjetMonde
    {
        public static void CréerObjet(int xParam, int yParam, string description, int typeObjet, int mondeId)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                var objmonde = context.Set<Accès_aux_données.ObjetMonde>();
                objmonde.Add(new Accès_aux_données.ObjetMonde() { x = xParam, y = yParam, Description = description, TypeObjet = typeObjet, MondeId = mondeId });
                context.SaveChanges();
            }
        }

        public static void SupprimerObjet(int id)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.ObjetMonde objMonde = context.ObjetMondes.Where(o => o.Id == id).FirstOrDefault();
                if (objMonde != null)
                    context.ObjetMondes.Remove(objMonde);
                context.SaveChanges();
            }
        }

        public static void ChangerDescription(int id, string description)
        {
            using (Accès_aux_données.Entities context = new Accès_aux_données.Entities())
            {
                Accès_aux_données.ObjetMonde objMonde = context.ObjetMondes.Where(o => o.Id == id).FirstOrDefault();
                if (objMonde != null)
                    objMonde.Description = description;
                context.SaveChanges();
            }
        }
    }
}