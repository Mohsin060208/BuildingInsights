namespace Insights.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InsightsDBEntities : DbContext
    {
        public InsightsDBEntities()
            : base("name=InsightsModel")
        {
        }

        public virtual DbSet<Mechanics> Mechanics { get; set; }
        public virtual DbSet<YearlyRecordBook> YearlyRecordBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mechanics>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
