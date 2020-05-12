﻿using EFCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebAPI.Data
{
   public class HeroiContext : DbContext
   {
      public DbSet<Heroi> Herois { get; set; }
      public DbSet<Batalha> Batalhas { get; set; }
      public DbSet<Arma> Armas { get; set; }
      public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
      public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Password=Epadrao00;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=TI000185");
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<HeroiBatalha>(entity =>
         {
            entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
         });
      }
   }
}
