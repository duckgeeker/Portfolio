﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Models;

namespace Portfolio.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20200816160922_StartMigration")]
    partial class StartMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portfolio.Models.Comment", b =>
                {
                    b.Property<int>("comment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contact_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("comment_id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Portfolio.Models.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contact_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("workId")
                        .HasColumnType("int");

                    b.HasKey("order_id");

                    b.HasIndex("workId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Portfolio.Models.Work", b =>
                {
                    b.Property<int>("work_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("desc_long")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc_short")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tools")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("work_id");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Portfolio.Models.Order", b =>
                {
                    b.HasOne("Portfolio.Models.Work", "Work")
                        .WithMany()
                        .HasForeignKey("workId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
