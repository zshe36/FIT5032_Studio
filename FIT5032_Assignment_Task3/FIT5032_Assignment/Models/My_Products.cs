using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_Assignment.Models
{
    public partial class My_Products : DbContext
    {
        public My_Products()
            : base("name=My_Products")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<FIT5032_Assignment.Models.Email> Emails { get; set; }
    }
}
