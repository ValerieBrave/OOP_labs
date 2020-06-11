namespace SampleMVVM.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<Consultation> Consultation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultation>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Consultation>()
                .Property(e => e.Subject)
                .IsUnicode(false);
        }
    }
}
