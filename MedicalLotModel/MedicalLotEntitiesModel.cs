using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MedicalLotModel
{
    public partial class MedicalLotEntitiesModel : DbContext
    {
        public MedicalLotEntitiesModel()
            : base("name=MedicalLotEntitiesModel")
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Specialization)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.Doctor)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.Patient)
                .WillCascadeOnDelete();
        }
    }
}
