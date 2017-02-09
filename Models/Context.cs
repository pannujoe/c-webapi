using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Models
{
    public class Context : DbContext
    {
        internal object Reason;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=172.17.1.96;Database=HD;User Id=hsingh;Password=Manu0723");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasKey(e => e.UserId)
                    .HasName("userId");

                entity.Property(e => e.FName)
                    .HasColumnName("fname");

                entity.Property(e => e.LName)
                    .HasColumnName("lname");

                entity.Property(e => e.Email)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasColumnName("password");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted");

            });

            modelBuilder.Entity<Reasons>(entity =>
            {
                entity.ToTable("reasons");

                entity.HasKey(e => e.ReasonId)
                    .HasName("reasonId");

                entity.Property(e => e.ReasonsName)
                    .HasColumnName("reasonName");

            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.ToTable("positions");

                entity.HasKey(e => e.PositionId)
                    .HasName("positionId");

                entity.Property(e => e.PositionName)
                    .HasColumnName("positionName");

            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("logs");

                entity.HasKey(e => e.LogId)
                    .HasName("logId");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contactId");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId");

                entity.Property(e => e.PositionId)
                    .HasColumnName("positionId");

            });

            modelBuilder.Entity<LogInfo>(entity =>
            {
                entity.HasKey(e => e.InfoId)
                    .HasName("InfoId");

            });

        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<Positions> Positions{ get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<LogInfo> LogInfo { get; set; }


    }
}
