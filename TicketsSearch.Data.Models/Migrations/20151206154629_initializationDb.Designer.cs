using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TicketsSearch.Data.Models;

namespace TicketsSearch.Data.Models.Migrations
{
    [DbContext(typeof(TicketsSearchDbContext))]
    [Migration("20151206154629_initializationDb")]
    partial class initializationDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketsSearch.Data.Models.Stantion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:TableName", "Stantions");
                });
        }
    }
}
