using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using p1_ap1_wilkins_20170289.Entidades;

namespace p1_ap1_wilkins_20170289.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\p1_ap1_wilkins_20170289.db");
        }
    }
}