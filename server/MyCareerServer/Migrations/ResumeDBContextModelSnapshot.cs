﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCareerServer.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyCareerServer.Migrations
{
    [DbContext(typeof(ResumeDBContext))]
    partial class ResumeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Contact", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Media")
                        .HasColumnType("text");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Education", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Begin")
                        .HasColumnType("text");

                    b.Property<string>("Degree")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("End")
                        .HasColumnType("text");

                    b.Property<string>("InstituteName")
                        .HasColumnType("text");

                    b.Property<string>("Major")
                        .HasColumnType("text");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Experience", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Begin")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("End")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Language", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Resume", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("AboutSelf")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string[]>("Hobbies")
                        .HasColumnType("text[]");

                    b.Property<string>("ImageURL")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<string[]>("Skills")
                        .HasColumnType("text[]");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<int?>("TemplateNo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Contact", b =>
                {
                    b.HasOne("MyCareerServer.FreelanceModels.Resume", "Resume")
                        .WithMany("Contacts")
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Education", b =>
                {
                    b.HasOne("MyCareerServer.FreelanceModels.Resume", "Resume")
                        .WithMany("Educations")
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Experience", b =>
                {
                    b.HasOne("MyCareerServer.FreelanceModels.Resume", "Resume")
                        .WithMany("Experinces")
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Language", b =>
                {
                    b.HasOne("MyCareerServer.FreelanceModels.Resume", "Resume")
                        .WithMany("Languages")
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("MyCareerServer.FreelanceModels.Resume", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Educations");

                    b.Navigation("Experinces");

                    b.Navigation("Languages");
                });
#pragma warning restore 612, 618
        }
    }
}