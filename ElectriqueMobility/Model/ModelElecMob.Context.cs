﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectriqueMobility.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class electricmobilityEntities : DbContext
    {
        public electricmobilityEntities()
            : base("name=electricmobilityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<produit> produit { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
    }
}
