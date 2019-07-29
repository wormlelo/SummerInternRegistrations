﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SummerInternRegistration.Models;

namespace SummerInternRegistration.Migrations
{
    [DbContext(typeof(SummerInternRegistrationContext))]
    [Migration("20190726145116_MS-SQL-01")]
    partial class MSSQL01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SummerInternRegistration.Models.Intern", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ACADEMICCREDITSEMESTER");

                    b.Property<string>("BACKGROUNDCHECK");

                    b.Property<string>("CLASSIFICATION");

                    b.Property<string>("COLLEGECREDIT");

                    b.Property<string>("COLLEGEGRADUATIONSEMESTER");

                    b.Property<string>("COLLEGEGRADUATIONYEAR");

                    b.Property<string>("DRUGSCREEN");

                    b.Property<string>("EDITOR");

                    b.Property<string>("EMAIL1");

                    b.Property<string>("FIRSTEXPERIENCE");

                    b.Property<string>("FNAME");

                    b.Property<string>("FNAMEPROF");

                    b.Property<double>("GPA");

                    b.Property<string>("INTERNSHIPPREP");

                    b.Property<string>("LNAME");

                    b.Property<string>("LNAMEPROF");

                    b.Property<string>("LOCATIONLODGING");

                    b.Property<string>("LOCATIONOUTSIDEGA");

                    b.Property<string>("MAJOR");

                    b.Property<string>("MOBILE");

                    b.Property<string>("NOTES");

                    b.Property<string>("ACADEMICCREDITYEAR");

                    b.Property<string>("PMNAME");

                    b.Property<string>("PREFEREDSITE");

                    b.Property<string>("PREFIX");

                    b.Property<string>("SEMESTERTERM");

                    b.Property<string>("SEMESTERYEAR");

                    b.Property<string>("SUFFIX");

                    b.Property<DateTime>("TIMESTAMP");

                    b.HasKey("ID");

                    b.ToTable("Intern");
                });
#pragma warning restore 612, 618
        }
    }
}
