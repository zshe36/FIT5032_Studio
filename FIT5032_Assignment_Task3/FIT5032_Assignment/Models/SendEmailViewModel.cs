using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Assignment.Models
{

    public class SendEmailViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string ToEmail { get; set; }

        [Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter the contents")]
        public string Contents { get; set; }

        public HttpPostedFileBase Upload { get; set; }
    }

    /*
    public partial class SendEmailViewModel : DbContext
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string ToEmail { get; set; }

        [Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter the contents")]
        public string Contents { get; set; }

        public HttpPostedFileBase Upload { get; set; }

        public SendEmailViewModel()
            : base("name=SendEmailViewModel")
        {

        }
        
        public virtual DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
    */
}
