using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_mvc.Models.Config
{
    public class ContextBase : DbContext
    {

        private readonly IConfiguration Configuration;

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnectionString"));
            }
        }

        public DbSet<FundoCapital> FundoCapital { get; set; }
        //public DbSet<ErroInesperado> ErroInesperados { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new ClienteMap());
        //    modelBuilder.ApplyConfiguration(new ProdutoMap());
        //}
    }
}