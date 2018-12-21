﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaTecnicaCi2Libreria2018.Contextos;

namespace PruebaTecnicaCi2Libreria2018.Migrations
{
    [DbContext(typeof(ContextoDeDatos))]
    [Migration("20181221023901_CreacionDeBaseDeDatos")]
    partial class CreacionDeBaseDeDatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PruebaTecnicaCi2Libreria2018.Modelos.Tarea", b =>
                {
                    b.Property<Guid>("GuTareaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BolEstado");

                    b.Property<DateTime>("DatFechaCreacion");

                    b.Property<DateTime>("DatFechaVencimineto");

                    b.Property<int>("IntFkUserId");

                    b.Property<string>("StrDescripcion")
                        .HasMaxLength(200);

                    b.HasKey("GuTareaId");

                    b.HasIndex("IntFkUserId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("PruebaTecnicaCi2Libreria2018.Modelos.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PruebaTecnicaCi2Libreria2018.Modelos.Tarea", b =>
                {
                    b.HasOne("PruebaTecnicaCi2Libreria2018.Modelos.User", "ObjUser")
                        .WithMany("ColTarea")
                        .HasForeignKey("IntFkUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
