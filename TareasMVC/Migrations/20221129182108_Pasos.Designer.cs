// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TareasMVC;

#nullable disable

namespace TareasMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221129182108_Pasos")]
    partial class Pasos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TareasMVC.Entidades.Paso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<Guid?>("PasoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Realizado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PasoId");

                    b.ToTable("Pasos");
                });

            modelBuilder.Entity("TareasMVC.Entidades.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("TareasMVC.Entidades.Paso", b =>
                {
                    b.HasOne("TareasMVC.Entidades.Paso", null)
                        .WithMany("Pasos")
                        .HasForeignKey("PasoId");
                });

            modelBuilder.Entity("TareasMVC.Entidades.Paso", b =>
                {
                    b.Navigation("Pasos");
                });
#pragma warning restore 612, 618
        }
    }
}
