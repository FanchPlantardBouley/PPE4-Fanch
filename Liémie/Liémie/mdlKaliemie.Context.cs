﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Liémie
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class connectkaliemie : DbContext
    {
        public connectkaliemie()
            : base("name=connectkaliemie")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<badge> badge { get; set; }
        public virtual DbSet<categ_soins> categ_soins { get; set; }
        public virtual DbSet<categorie_indisponibilite> categorie_indisponibilite { get; set; }
        public virtual DbSet<chambre_forte> chambre_forte { get; set; }
        public virtual DbSet<convalescence> convalescence { get; set; }
        public virtual DbSet<indisponibilite> indisponibilite { get; set; }
        public virtual DbSet<infirmiere> infirmiere { get; set; }
        public virtual DbSet<infirmiere_badge> infirmiere_badge { get; set; }
        public virtual DbSet<lieu_convalescence> lieu_convalescence { get; set; }
        public virtual DbSet<patient> patient { get; set; }
        public virtual DbSet<personne> personne { get; set; }
        public virtual DbSet<personne_login> personne_login { get; set; }
        public virtual DbSet<soins> soins { get; set; }
        public virtual DbSet<soins_visite> soins_visite { get; set; }
        public virtual DbSet<temoignage> temoignage { get; set; }
        public virtual DbSet<token> token { get; set; }
        public virtual DbSet<type_soins> type_soins { get; set; }
        public virtual DbSet<visite> visite { get; set; }
        public virtual DbSet<administrateur> administrateur { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
