using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChurchApp
{
    public class AplicacionDbContext: DbContext
    {
        public DbSet<Modelo> Integrantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Church.db");
    }

}