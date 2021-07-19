using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//using CrudFornec.Data.Extensions;
//using CrudFornec.Data.Mappings;
using CrudFornec.Domain.Entities;

namespace CrudFornec.Data.Content
{
    public class CrudFornecContext : DbContext
    {
        public CrudFornecContext(DbContextOptions<CrudFornecContext> option)
            : base(option) {}

        #region "DbSets"
        public DbSet<Fornecedor> Fornecedor { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserMap());

            //modelBuilder.ApplyGlobalConfigurations();
            //modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
