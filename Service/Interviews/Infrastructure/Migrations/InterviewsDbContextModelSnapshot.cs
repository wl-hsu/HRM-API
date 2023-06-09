﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(InterviewsDbContext))]
    partial class InterviewsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Entities.InterviewTypeLookUps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InterviewTypeCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("InterviewTypeDescription")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.ToTable("InterviewTypeLookUps");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Interviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<Guid>("EmployeeIdentityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Interviewers");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Interviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CandidateEmail")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CandidateFirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("CandidateIdentityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CandidateLastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InterviewTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewerId")
                        .HasColumnType("int");

                    b.Property<int?>("Passed")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Interviews");
                });
#pragma warning restore 612, 618
        }
    }
}
