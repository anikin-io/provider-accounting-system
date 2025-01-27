﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaiderEF;

#nullable disable

namespace ProvaiderEF.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231221225845_RemoveInstallment")]
    partial class RemoveInstallment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContractEmployee", b =>
                {
                    b.Property<int>("ContractsContractId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("ContractsContractId", "EmployeesEmployeeId");

                    b.HasIndex("EmployeesEmployeeId");

                    b.ToTable("ContractEmployee");
                });

            modelBuilder.Entity("ContractEquipment", b =>
                {
                    b.Property<int>("ContractsContractId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentsEquipmentId")
                        .HasColumnType("int");

                    b.HasKey("ContractsContractId", "EquipmentsEquipmentId");

                    b.HasIndex("EquipmentsEquipmentId");

                    b.ToTable("ContractEquipment");
                });

            modelBuilder.Entity("ProvaiderEF.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"));

                    b.Property<string>("ConnectionAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubscriberId")
                        .HasColumnType("int");

                    b.Property<string>("SubscriberLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubscriberPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscribеrId")
                        .HasColumnType("int");

                    b.Property<int?>("TariffId")
                        .HasColumnType("int");

                    b.HasKey("ContractId");

                    b.HasIndex("SubscriberId");

                    b.HasIndex("TariffId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("ProvaiderEF.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProvaiderEF.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SellingCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EquipmentId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("ProvaiderEF.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.HasIndex("ContractId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ProvaiderEF.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("InvoiceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ContractId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ProvaiderEF.InvoiceService", b =>
                {
                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("InvoiceService", (string)null);
                });

            modelBuilder.Entity("ProvaiderEF.PotentialSubscriber", b =>
                {
                    b.Property<int>("PotentialSubscriberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PotentialSubscriberId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PotentialSubscriberId");

                    b.ToTable("PotentialSubscribers");
                });

            modelBuilder.Entity("ProvaiderEF.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("PotentialSubscriberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TariffId")
                        .HasColumnType("int");

                    b.HasKey("RequestId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("PotentialSubscriberId");

                    b.HasIndex("TariffId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("ProvaiderEF.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<decimal?>("ServiceCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ProvaiderEF.Subscriber", b =>
                {
                    b.Property<int>("SubscriberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriberId"));

                    b.Property<string>("FirstNameSubscriber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastNameSubscriber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleNameSubscriber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportSubscriber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSubscriber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriberId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("ProvaiderEF.Tariff", b =>
                {
                    b.Property<int>("TariffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TariffId"));

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<decimal>("TariffCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TariffDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TariffName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TariffId");

                    b.ToTable("Tariffs");
                });

            modelBuilder.Entity("ProvaiderEF.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("ContractId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ContractEmployee", b =>
                {
                    b.HasOne("ProvaiderEF.Contract", null)
                        .WithMany()
                        .HasForeignKey("ContractsContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContractEquipment", b =>
                {
                    b.HasOne("ProvaiderEF.Contract", null)
                        .WithMany()
                        .HasForeignKey("ContractsContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentsEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProvaiderEF.Contract", b =>
                {
                    b.HasOne("ProvaiderEF.Subscriber", "Subscriber")
                        .WithMany("Contracts")
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Tariff", "Tariff")
                        .WithMany("Contracts")
                        .HasForeignKey("TariffId");

                    b.Navigation("Subscriber");

                    b.Navigation("Tariff");
                });

            modelBuilder.Entity("ProvaiderEF.Event", b =>
                {
                    b.HasOne("ProvaiderEF.Contract", "Contract")
                        .WithMany("Events")
                        .HasForeignKey("ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("ProvaiderEF.Invoice", b =>
                {
                    b.HasOne("ProvaiderEF.Contract", "Contract")
                        .WithMany("Invoices")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Employee", "Employee")
                        .WithMany("Invoices")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Contract");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProvaiderEF.InvoiceService", b =>
                {
                    b.HasOne("ProvaiderEF.Invoice", "Invoice")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Service", "Service")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ProvaiderEF.Request", b =>
                {
                    b.HasOne("ProvaiderEF.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");

                    b.HasOne("ProvaiderEF.PotentialSubscriber", "PotentialSubscriber")
                        .WithMany("Requests")
                        .HasForeignKey("PotentialSubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaiderEF.Tariff", "Tariff")
                        .WithMany("Requests")
                        .HasForeignKey("TariffId");

                    b.Navigation("Equipment");

                    b.Navigation("PotentialSubscriber");

                    b.Navigation("Tariff");
                });

            modelBuilder.Entity("ProvaiderEF.Transaction", b =>
                {
                    b.HasOne("ProvaiderEF.Contract", "Contract")
                        .WithMany("Transactions")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("ProvaiderEF.Contract", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Invoices");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ProvaiderEF.Employee", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("ProvaiderEF.Invoice", b =>
                {
                    b.Navigation("InvoiceServices");
                });

            modelBuilder.Entity("ProvaiderEF.PotentialSubscriber", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("ProvaiderEF.Service", b =>
                {
                    b.Navigation("InvoiceServices");
                });

            modelBuilder.Entity("ProvaiderEF.Subscriber", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("ProvaiderEF.Tariff", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
