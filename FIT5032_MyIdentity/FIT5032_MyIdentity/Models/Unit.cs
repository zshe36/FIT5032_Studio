namespace FIT5032_MyIdentity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string Descrption { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
