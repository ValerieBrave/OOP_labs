namespace Lab12.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [StringLength(40)]
        public string file_id { get; set; }

        [StringLength(5)]
        public string format { get; set; }

        public float? file_size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return this.file_id + "." + this.format + ", " + this.file_size.ToString(); ;
        }
    }
}
