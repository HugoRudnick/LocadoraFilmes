﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Locadora.Modelos
{
    public class LocadoraDBContext : DbContext
    {

        public LocadoraDBContext(DbContextOptions<LocadoraDBContext> options) : base(options)
        {

        }
        //base.OnModelCreating(modelBuilder);

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Locacoes> Locacoes { get; set; }
        public DbSet<Generos> generos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //    modelBuilder.Entity<Usuarios>()
        //        .Property(e => e.Usuario)
        //        .IsUnicode(false);

        //}

    }
}
