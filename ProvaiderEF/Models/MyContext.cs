using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Logging;

namespace ProvaiderEF
{
    public class MyContext: DbContext
    {
        public DbSet<Subscriber> Subscribers { get; set; } = null!;
        public DbSet<Contract> Contracts { get; set; } = null!;
        public DbSet<Equipment> Equipments { get; set; } = null!;
        public DbSet<Tariff> Tariffs { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<PotentialSubscriber> PotentialSubscribers { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;


        public DbSet <MasterStatistic> MasterStatistics { get; set; } = null!;
        public DbSet<TariffArchive> TariffArchives { get; set; } = null!;
        

        public MyContext()
        {
            //перезапись бд
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProvaiderDbConnection"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //промежуточная таблица с доп столбцом через FluentAPI
            modelBuilder
            .Entity<Invoice>()
            .HasMany(i => i.Services)
            .WithMany(s => s.Invoices)
            .UsingEntity<InvoiceService>(
               j => j
                .HasOne(pt => pt.Service)
                .WithMany(t => t.InvoiceServices)
                .HasForeignKey(pt => pt.ServiceId),
            j => j
                .HasOne(pt => pt.Invoice)
                .WithMany(p => p.InvoiceServices)
                .HasForeignKey(pt => pt.InvoiceId),
            j =>
            {
                j.HasKey(t => new { t.InvoiceId, t.ServiceId });
                j.ToTable("InvoiceService");
            });

            //триггеры
            modelBuilder.Entity<Invoice>()
                .ToTable(tb => tb.HasTrigger("trg_InsertInvoice_UpdateMasterStatistics"));

            modelBuilder.Entity<Tariff>()
                .ToTable(tb => tb.HasTrigger("trg_TariffArchive"));

            //индексы
            modelBuilder.Entity<PotentialSubscriber>()
                .HasIndex(e => e.PhoneNumber);
            modelBuilder.Entity<Request>()
                .HasIndex(e => e.RequestDate);
            modelBuilder.Entity<Request>()
                .HasIndex(r => r.RequestStatus);
            modelBuilder.Entity<Subscriber>()
                .HasIndex(s => s.PhoneSubscriber);
        }
    }
}
