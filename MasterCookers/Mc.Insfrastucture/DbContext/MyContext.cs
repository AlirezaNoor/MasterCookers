﻿
using CookesCategores;
using Mc.Domin.Cookes;
using Mc.Insfrastucture.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Mc.Insfrastucture.DbContext
{
    public class MyContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<CookesCategores.CookesCategores> cookescategores { get; set; }
        public DbSet<Cookes> Cookess { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CookesCategoresMapping());
            modelBuilder.ApplyConfiguration(new CookesMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}