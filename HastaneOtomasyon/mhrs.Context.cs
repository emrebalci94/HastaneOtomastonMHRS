﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneOtomasyon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MhrsDBEntities1 : DbContext
    {
        public MhrsDBEntities1()
            : base("name=MhrsDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<Ilaclar> Ilaclar { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<PersonelIzin> PersonelIzin { get; set; }
        public virtual DbSet<PersonelTip> PersonelTip { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<Recete> Recete { get; set; }
        public virtual DbSet<ReceteIlac> ReceteIlac { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
