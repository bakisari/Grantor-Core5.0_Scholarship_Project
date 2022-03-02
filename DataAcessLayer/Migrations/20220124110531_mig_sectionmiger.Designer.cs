﻿// <auto-generated />
using System;
using DataAcessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220124110531_mig_sectionmiger")]
    partial class mig_sectionmiger
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrate.About", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrate.City", b =>
                {
                    b.Property<int?>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Donor", b =>
                {
                    b.Property<int>("DonorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("DonorImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonorID");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Faculty", b =>
                {
                    b.Property<int?>("FacultyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityID")
                        .HasColumnType("int");

                    b.HasKey("FacultyID");

                    b.HasIndex("UniversityID");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Section", b =>
                {
                    b.Property<int?>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SectionID")
                        .HasColumnType("int");

                    b.Property<bool>("SiteShow")
                        .HasColumnType("bit");

                    b.Property<int?>("UniversityID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("SectionID");

                    b.HasIndex("UniversityID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrate.University", b =>
                {
                    b.Property<int?>("UniversityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniversityID");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Faculty", b =>
                {
                    b.HasOne("EntityLayer.Concrate.University", null)
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityID");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Section", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Faculty", "Faculty")
                        .WithMany("Sections")
                        .HasForeignKey("FacultyID");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Student", b =>
                {
                    b.HasOne("EntityLayer.Concrate.City", "City")
                        .WithMany("Students")
                        .HasForeignKey("CityID");

                    b.HasOne("EntityLayer.Concrate.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID");

                    b.HasOne("EntityLayer.Concrate.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionID");

                    b.HasOne("EntityLayer.Concrate.University", "University")
                        .WithMany("Students")
                        .HasForeignKey("UniversityID");

                    b.Navigation("City");

                    b.Navigation("Faculty");

                    b.Navigation("Section");

                    b.Navigation("University");
                });

            modelBuilder.Entity("EntityLayer.Concrate.City", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Faculty", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EntityLayer.Concrate.University", b =>
                {
                    b.Navigation("Faculties");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
