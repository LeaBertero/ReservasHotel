﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservasHotel.DB.Data;

#nullable disable

namespace ReservasHotel.DB.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220727151708_af_cuilUq")]
    partial class af_cuilUq
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Afiliado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cuil")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Cuil" }, "cuil_Uq")
                        .IsUnique();

                    b.ToTable("Afiliados");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Dia", b =>
                {
                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Cant_Huespedes")
                        .HasColumnType("int");

                    b.Property<bool>("Early")
                        .HasColumnType("bit");

                    b.Property<bool>("Late")
                        .HasColumnType("bit");

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("HabitacionId", "Fecha");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "HabitacionId", "Fecha" }, "diaIdHab_Uq")
                        .IsUnique();

                    b.ToTable("DiasReservas");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.EstadoPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EstadosDePago");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Habitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("N_DeHabitacion")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Privilegio", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Privilegios");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AfiliadoId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("EstadoPagoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AfiliadoId");

                    b.HasIndex("EstadoPagoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Legajo")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PrivilegioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PrivilegioId");

                    b.HasIndex(new[] { "NombreUsuario" }, "NUsuario_Uq")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Dia", b =>
                {
                    b.HasOne("ReservasHotel.DB.Data.Entidades.Habitacion", null)
                        .WithMany("Dias")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservasHotel.DB.Data.Entidades.Reserva", null)
                        .WithMany("diasRes")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Reserva", b =>
                {
                    b.HasOne("ReservasHotel.DB.Data.Entidades.Afiliado", null)
                        .WithMany("Rva")
                        .HasForeignKey("AfiliadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservasHotel.DB.Data.Entidades.EstadoPago", null)
                        .WithMany("reservas")
                        .HasForeignKey("EstadoPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservasHotel.DB.Data.Entidades.Usuario", null)
                        .WithMany("Reservas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Usuario", b =>
                {
                    b.HasOne("ReservasHotel.DB.Data.Entidades.Privilegio", null)
                        .WithMany("usuarios")
                        .HasForeignKey("PrivilegioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Afiliado", b =>
                {
                    b.Navigation("Rva");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.EstadoPago", b =>
                {
                    b.Navigation("reservas");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Habitacion", b =>
                {
                    b.Navigation("Dias");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Privilegio", b =>
                {
                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Reserva", b =>
                {
                    b.Navigation("diasRes");
                });

            modelBuilder.Entity("ReservasHotel.DB.Data.Entidades.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
