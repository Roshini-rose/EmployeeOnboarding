﻿// <auto-generated />
using System;
using EmployeeOnboarding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeOnboarding.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230731051952_admindata")]
    partial class admindata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmployeeOnboarding.Data.ApprovalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Approved")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Cancelled")
                        .HasColumnType("boolean");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeAdditionalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Covid_VaccSts")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("Disability")
                        .HasColumnType("boolean");

                    b.Property<string>("Disablility_type")
                        .HasColumnType("text");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Vacc_Certificate")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeAdditionalInfo");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeAddressDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeAddressDetails");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeContactDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Contact_no")
                        .HasColumnType("double precision");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("Emgy_Contactno")
                        .HasColumnType("double precision");

                    b.Property<string>("Emgy_Contactperson")
                        .HasColumnType("text");

                    b.Property<string>("Emgy_Contactrelation")
                        .HasColumnType("text");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Personal_Emailid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeContactDetails");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeEducationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Certificate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<int>("Passoutyear")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("programme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeEducationDetails");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeExperienceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Company_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Exp_Certificate")
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Totalmonths")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("EmployeeExperienceDetails");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.EmployeeGeneralDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BloodGrp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateOfMarriage")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Empid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaritalName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeGeneralDetails");
                });

            modelBuilder.Entity("EmployeeOnboarding.Data.Login", b =>
                {
                    b.Property<string>("Empid")
                        .HasColumnType("text");

                    b.Property<string>("Created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Date_Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Emailid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modified_by")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Empid");

                    b.ToTable("Logins");
                });
#pragma warning restore 612, 618
        }
    }
}
