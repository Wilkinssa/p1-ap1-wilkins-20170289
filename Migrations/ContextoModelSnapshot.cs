// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using p1_ap1_wilkins_20170289.DAL;

namespace p1_ap1_wilkins_20170289.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("p1_ap1_wilkins_20170289.Entidades.Aportes", b =>
                {
                    b.Property<int>("AporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Persona")
                        .HasColumnType("TEXT");

                    b.HasKey("AporteId");

                    b.ToTable("Aportes");
                });
#pragma warning restore 612, 618
        }
    }
}
