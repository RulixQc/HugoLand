//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HugoLand.Accès_aux_données
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.EffetItems = new HashSet<EffetItem>();
            this.InventaireHeroes = new HashSet<InventaireHero>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Nullable<int> x { get; set; }
        public Nullable<int> y { get; set; }
        public int Niveau { get; set; }
        public Nullable<decimal> ValeurArgent { get; set; }
        public decimal Poids { get; set; }
        public int ReqNiveau { get; set; }
        public int ReqForce { get; set; }
        public int ReqDexterite { get; set; }
        public int ReqIntelligence { get; set; }
        public int ReqEndurance { get; set; }
        public int MondeId { get; set; }
        public int Quantite { get; set; }
        public Nullable<int> ImageId { get; set; }
        public byte[] RowVersion { get; set; }
        public bool Ramasse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EffetItem> EffetItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventaireHero> InventaireHeroes { get; set; }
        public virtual Monde Monde { get; set; }
    }
}
