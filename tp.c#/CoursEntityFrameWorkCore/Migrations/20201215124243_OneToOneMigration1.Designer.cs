// <auto-generated />
using System;
using CoursEntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoursEntityFrameWorkCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201215124243_OneToOneMigration1")]
    partial class OneToOneMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CoursEntityFrameWorkCore.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ville");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("code_postal");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("rue");

                    b.HasKey("Id");

                    b.ToTable("adresses");
                });

            modelBuilder.Entity("CoursEntityFrameWorkCore.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nom");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("prenom");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("telephone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("personnes");
                });

            modelBuilder.Entity("CoursEntityFrameWorkCore.Models.Person", b =>
                {
                    b.HasOne("CoursEntityFrameWorkCore.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
