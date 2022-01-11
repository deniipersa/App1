namespace MedicalLotModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(50)]
        public string DoctorFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string DoctorLastName { get; set; }

        [StringLength(50)]
        public string Rank { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
