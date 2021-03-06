﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProcessStep_Demo2.Models;

namespace ProcessStep_Demo2.Migrations
{
    [DbContext(typeof(ProcessStepsContext))]
    [Migration("20191108132316_initial-db")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProcessStep_Demo2.Models.ProcessStep", b =>
                {
                    b.Property<int>("StepID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("StepName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("StepID");

                    b.ToTable("ProcessSteps","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
