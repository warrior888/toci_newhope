﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Halkidiki.Dal.Interfaces
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class halkidikiEntities : DbContext
    {
        public halkidikiEntities()
            : base("name=halkidikiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<appuser> appuser { get; set; }
        public virtual DbSet<language> language { get; set; }
        public virtual DbSet<occupation> occupation { get; set; }
        public virtual DbSet<translation> translation { get; set; }
        public virtual DbSet<word> word { get; set; }
        public virtual DbSet<wordfrequency> wordfrequency { get; set; }
        public virtual DbSet<cmc> cmc { get; set; }
        public virtual DbSet<logtime> logtime { get; set; }
        public virtual DbSet<source> source { get; set; }
        public virtual DbSet<spokensentence> spokensentence { get; set; }
        public virtual DbSet<translationtag> translationtag { get; set; }
        public virtual DbSet<wordlearninghistory> wordlearninghistory { get; set; }
    }
}
