namespace JobApplication.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        public int Location { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfApplication { get; set; }

        public int? ReferenceNumber { get; set; }

        [StringLength(100)]
        public string LinkedInContact { get; set; }

        public int? Status { get; set; }

        public virtual JobStatu JobStatu { get; set; }

        public virtual JobLocation JobLocation { get; set; }
    }
}
