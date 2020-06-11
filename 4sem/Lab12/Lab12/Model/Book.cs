namespace Lab12.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [Key]
        [StringLength(100)]
        public string title { get; set; }

        [StringLength(30)]
        public string author { get; set; }

        [StringLength(40)]
        public string file_id { get; set; }

        public int? pages { get; set; }

        public int? year { get; set; }

        public virtual Author Authors { get; set; }

        public virtual File Files { get; set; }

        public override string ToString()
        {
            return this.title + ", "+this.author+", "+this.year.ToString()+"г, "+this.pages.ToString()+"стр.";
        }
    }
}
