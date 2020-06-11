namespace SampleMVVM.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consultation")]
    public partial class Consultation
    {
        public int ID { get; set; }

        [StringLength(60)]
        public string FIO { get; set; }

        [StringLength(30)]
        public string Subject { get; set; }

        public DateTime? Startime { get; set; }

        public DateTime? Endtime { get; set; }

        public byte? IsRecorded { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
