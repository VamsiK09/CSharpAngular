namespace JobApplication.Services
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobModel : DbContext
    {
        public JobModel()
            : base("name=JobModel")
        {
        }

        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobLocation> JobLocations { get; set; }
        public virtual DbSet<JobStatu> JobStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobLocation>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.JobLocation)
                .HasForeignKey(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobStatu>()
                .HasMany(e => e.Jobs)
                .WithOptional(e => e.JobStatu)
                .HasForeignKey(e => e.Status);
        }
    }
}
