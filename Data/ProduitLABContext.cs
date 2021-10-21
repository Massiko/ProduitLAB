using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProduitLAB.Models;

namespace ProduitLAB.Data
{
    public class ProduitLABContext : DbContext
    {
        public ProduitLABContext (DbContextOptions<ProduitLABContext> options)
            : base(options)
        {
        }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<GarantieP> GarantiePs { get; set; }
        public DbSet<CotisationP> CotisationPs { get; set; }
        public DbSet<LienGP> LienGPs { get; set; }
        public DbSet<LienCP> LienCPs { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Produit>().ToTable("Produit");
            modelBuilder.Entity<GarantieP>().ToTable("GarantieP");
            modelBuilder.Entity<LienGP>().ToTable("LienGP");
            modelBuilder.Entity<CotisationP>().ToTable("CotisationP");
            modelBuilder.Entity<LienCP>().ToTable("LienCP");
        }
    }
}
