using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Stock_Master_DataAccess.Models;

namespace Stock_Master_DataAccess.DataContext
{
    public partial class StockManagementContext : DbContext
    {
        public StockManagementContext()
        {
        }

        public StockManagementContext(DbContextOptions<StockManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; } = null!;
        public virtual DbSet<Subject> Subject { get; set; } = null!;
        public virtual DbSet<Bank> Bank { get; set; } = null!;

        public virtual DbSet<SM_CATEGORY> SM_CATEGORY { get; set; } = null!;
        public virtual DbSet<SM_ITEMS> SM_ITEMS { get; set; } = null!;
        public virtual DbSet<SM_SUPPLIERS> SM_SUPPLIERS { get; set; } = null!;
        public virtual DbSet<SM_INVENTORY_DETAILS> SM_PREFIX { get; set; } = null!;
        public virtual DbSet<SM_USER_TYPES> SM_USER_TYPES { get; set; } = null!;
        public virtual DbSet<SM_USER> SM_USER { get; set; } = null!;
        public virtual DbSet<SM_GRN> SM_GRN { get; set; } = null!;
        public virtual DbSet<SM_GRN_DETAILS> SM_GRN_DETAILS { get; set; } = null!;
        public virtual DbSet<SM_INVENTORY> SM_INVENTORY { get; set; } = null!;
        public virtual DbSet<SM_INVENTORY> SM_PATIENTS { get; set; } = null!;
        public virtual DbSet<SM_INVENTORY_DETAILS> SM_INVENTORY_DETAILS { get; set; } = null!;
        public virtual DbSet<SM_DOCTOR_DETAILS> SM_DOCTOR_DETAILS { get; set; } = null!;
        public virtual DbSet<SM_STOCK_OUT> SM_STOCK_OUT { get; set; } = null!;
        public virtual DbSet<SM_PATIENT_DETAILS> SM_PATIENT_DETAILS { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:HBIZ-LP215;Initial Catalog=StockManagement;User ID=StockManagement;Integrated Security=false;Password=StockManagement");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Table1>(entity =>
        //    {
        //        entity.Property(e => e.Id).IsFixedLength();

        //        entity.Property(e => e.Test).IsFixedLength();
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SM_INVENTORY_DETAILS>()
                .HasOne(p => p.SM_PATIENTS)
                .WithMany(b => b.SM_INVENTORY_DETAILS)
                .HasForeignKey(p => p.Patient_ID)
                .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SM_INVENTORY_DETAILS>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.Used_By)
                .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
