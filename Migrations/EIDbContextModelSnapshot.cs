﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebDev.Persistence;

namespace WebDev.Migrations
{
    [DbContext(typeof(EIDbContext))]
    partial class EIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebDev.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<int>("MunicipioId");

                    b.Property<string>("Nombre");

                    b.Property<string>("NumeroContacto");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebDev.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("WebDev.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Celular");

                    b.Property<string>("Clabe");

                    b.Property<string>("Colonia");

                    b.Property<string>("Curp");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaContratacion");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<DateTime?>("FechaTerminacion");

                    b.Property<string>("Nombre");

                    b.Property<string>("NumeroSeguroSocial");

                    b.Property<string>("Puesto");

                    b.Property<decimal>("SueldoBase");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("WebDev.Models.Locker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Alto");

                    b.Property<int>("Ancho");

                    b.Property<int>("Largo");

                    b.Property<string>("Nombre");

                    b.Property<int>("PrecioUnitario");

                    b.Property<int>("SucursalId");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Locker");
                });

            modelBuilder.Entity("WebDev.Models.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("WebDev.Models.PromoCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("Expiracion");

                    b.Property<DateTime>("FechaAlta");

                    b.Property<int>("Tipo");

                    b.Property<int?>("UsuarioCreadorId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioCreadorId");

                    b.ToTable("PromoCodes");
                });

            modelBuilder.Entity("WebDev.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Colonia");

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Sucursal");
                });

            modelBuilder.Entity("WebDev.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<decimal>("Descuento");

                    b.Property<DateTime>("FechaCompra");

                    b.Property<decimal>("Iva");

                    b.Property<int>("PromoCodeId");

                    b.Property<decimal>("Subtotal");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PromoCodeId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("WebDev.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FechaFinal");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<int>("LockerId");

                    b.Property<int>("TicketId");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("LockerId");

                    b.HasIndex("TicketId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("WebDev.Models.Cliente", b =>
                {
                    b.HasOne("WebDev.Models.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebDev.Models.Empleado", b =>
                {
                    b.HasOne("WebDev.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebDev.Models.Locker", b =>
                {
                    b.HasOne("WebDev.Models.Sucursal", "Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebDev.Models.PromoCode", b =>
                {
                    b.HasOne("WebDev.Models.Empleado", "UsuarioCreador")
                        .WithMany()
                        .HasForeignKey("UsuarioCreadorId");
                });

            modelBuilder.Entity("WebDev.Models.Ticket", b =>
                {
                    b.HasOne("WebDev.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebDev.Models.PromoCode", "PromoCode")
                        .WithMany()
                        .HasForeignKey("PromoCodeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebDev.Models.Venta", b =>
                {
                    b.HasOne("WebDev.Models.Locker", "Locker")
                        .WithMany()
                        .HasForeignKey("LockerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebDev.Models.Ticket", "Ticket")
                        .WithMany("Ventas")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}