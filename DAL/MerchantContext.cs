using MerchantWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MerchantWebAPI.DAL
{
    public class MerchantContext : DbContext
    {
        public MerchantContext():base("MerchantContext")
        {

        }

        public DbSet<Merchant> Merchants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>().HasKey(t => t.merchant_id); //primary key defination  
            base.OnModelCreating(modelBuilder);
        }   
    }
}