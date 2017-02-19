using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LAInfrastructure.Data;

namespace LAInfrastructure.Migrations
{
    [DbContext(typeof(LOTTODBContext))]
    partial class LOTTODBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LACore.Model.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KeyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("KeyValue")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("LACore.Model.Extraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExtractionDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Number1");

                    b.Property<int>("Number2");

                    b.Property<int>("Number3");

                    b.Property<int>("Number4");

                    b.Property<int>("Number5");

                    b.Property<int>("Number6");

                    b.Property<int>("SpecialNumber");

                    b.HasKey("Id");

                    b.ToTable("Extraction");
                });

            modelBuilder.Entity("LACore.Model.Factor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExtractionId");

                    b.Property<decimal>("Factor1")
                        .HasColumnType("decimal");

                    b.Property<decimal>("Factor2")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("ExtractionId");

                    b.ToTable("Factor");
                });

            modelBuilder.Entity("LACore.Model.Number", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool?>("IsSpecial");

                    b.Property<int?>("NotSeen");

                    b.Property<int>("Number1")
                        .HasColumnName("Number");

                    b.Property<int?>("Occurencies");

                    b.HasKey("Id");

                    b.ToTable("Number");
                });

            modelBuilder.Entity("LACore.Model.Factor", b =>
                {
                    b.HasOne("LACore.Model.Extraction", "Extraction")
                        .WithMany("Factor")
                        .HasForeignKey("ExtractionId")
                        .HasConstraintName("FK_Factor_Extraction")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
