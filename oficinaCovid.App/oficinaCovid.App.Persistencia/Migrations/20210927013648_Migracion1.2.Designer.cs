﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210927013648_Migracion1.2")]
    partial class Migracion12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("oficinaCovid.App.Dominio.Diagnostico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaFinAislamiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("fiasAislamiento")
                        .HasColumnType("int");

                    b.Property<bool>("infectado")
                        .HasColumnType("bit");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("sintomasid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.HasIndex("sintomasid");

                    b.ToTable("diagnosticos");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Disponibilidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Oficinaid")
                        .HasColumnType("int");

                    b.Property<bool>("disponible")
                        .HasColumnType("bit");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("Oficinaid");

                    b.ToTable("horasDisponibles");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Gobernacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroOficinas")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("gobernaciones");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Oficina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Gobernacionid")
                        .HasColumnType("int");

                    b.Property<int>("aforo")
                        .HasColumnType("int");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("secretarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Gobernacionid");

                    b.HasIndex("secretarioid");

                    b.ToTable("oficinas");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.OficinaVisitante", b =>
                {
                    b.Property<int>("oficinaId")
                        .HasColumnType("int");

                    b.Property<int>("visitanteId")
                        .HasColumnType("int");

                    b.HasKey("oficinaId", "visitanteId");

                    b.HasIndex("visitanteId");

                    b.ToTable("oficinaVisitante");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.SintomasCovid", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("desaliento")
                        .HasColumnType("bit");

                    b.Property<bool>("dificultadRespirar")
                        .HasColumnType("bit");

                    b.Property<bool>("dolorGarganta")
                        .HasColumnType("bit");

                    b.Property<bool>("fiebre")
                        .HasColumnType("bit");

                    b.Property<bool>("perdidaGusto")
                        .HasColumnType("bit");

                    b.Property<bool>("perdidaOlfato")
                        .HasColumnType("bit");

                    b.Property<bool>("tosSeca")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("sintomas");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.GobernadorAsesor", b =>
                {
                    b.HasBaseType("oficinaCovid.App.Dominio.Persona");

                    b.Property<int?>("Oficinaid")
                        .HasColumnType("int");

                    b.Property<string>("rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Oficinaid");

                    b.HasDiscriminator().HasValue("GobernadorAsesor");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.PersonalAseo", b =>
                {
                    b.HasBaseType("oficinaCovid.App.Dominio.Persona");

                    b.Property<int?>("Gobernacionid")
                        .HasColumnType("int");

                    b.Property<DateTime>("horaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horaSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Gobernacionid");

                    b.HasDiscriminator().HasValue("PersonalAseo");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.PersonalProveedor", b =>
                {
                    b.HasBaseType("oficinaCovid.App.Dominio.Persona");

                    b.Property<int?>("Gobernacionid")
                        .HasColumnType("int")
                        .HasColumnName("PersonalProveedor_Gobernacionid");

                    b.Property<string>("nombreEmpresa")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PersonalProveedor_nombreEmpresa");

                    b.Property<string>("servicioRealizado")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Gobernacionid");

                    b.HasDiscriminator().HasValue("PersonalProveedor");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.SecretarioDespacho", b =>
                {
                    b.HasBaseType("oficinaCovid.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("SecretarioDespacho");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Diagnostico", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("oficinaCovid.App.Dominio.SintomasCovid", "sintomas")
                        .WithMany()
                        .HasForeignKey("sintomasid");

                    b.Navigation("persona");

                    b.Navigation("sintomas");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Disponibilidad", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Oficina", null)
                        .WithMany("horasDisponibles")
                        .HasForeignKey("Oficinaid");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Oficina", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Gobernacion", null)
                        .WithMany("oficinas")
                        .HasForeignKey("Gobernacionid");

                    b.HasOne("oficinaCovid.App.Dominio.SecretarioDespacho", "secretario")
                        .WithMany()
                        .HasForeignKey("secretarioid");

                    b.Navigation("secretario");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.OficinaVisitante", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Oficina", "oficina")
                        .WithMany()
                        .HasForeignKey("oficinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("oficinaCovid.App.Dominio.GobernadorAsesor", "visitante")
                        .WithMany()
                        .HasForeignKey("visitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oficina");

                    b.Navigation("visitante");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.GobernadorAsesor", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Oficina", null)
                        .WithMany("visitantes")
                        .HasForeignKey("Oficinaid");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.PersonalAseo", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Gobernacion", null)
                        .WithMany("aseadores")
                        .HasForeignKey("Gobernacionid");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.PersonalProveedor", b =>
                {
                    b.HasOne("oficinaCovid.App.Dominio.Gobernacion", null)
                        .WithMany("proveedores")
                        .HasForeignKey("Gobernacionid");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Gobernacion", b =>
                {
                    b.Navigation("aseadores");

                    b.Navigation("oficinas");

                    b.Navigation("proveedores");
                });

            modelBuilder.Entity("oficinaCovid.App.Dominio.Oficina", b =>
                {
                    b.Navigation("horasDisponibles");

                    b.Navigation("visitantes");
                });
#pragma warning restore 612, 618
        }
    }
}
