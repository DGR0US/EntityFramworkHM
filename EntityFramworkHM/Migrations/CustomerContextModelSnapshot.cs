// <auto-generated />
using System;
using EntityFramworkHM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramworkHM.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityFramworkHM.Model.customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("name1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("name2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.HasKey("id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("EntityFramworkHM.Model.orderh", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double>("amount")
                        .HasColumnType("double precision");

                    b.Property<int>("customerid")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("doc_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("doc_no")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("net_amount")
                        .HasColumnType("double precision");

                    b.Property<double>("vat")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.HasIndex("customerid");

                    b.ToTable("Orderh", (string)null);
                });

            modelBuilder.Entity("EntityFramworkHM.Model.orderid", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("item_desc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("itemid")
                        .HasColumnType("integer");

                    b.Property<double>("net_amount")
                        .HasColumnType("double precision");

                    b.Property<int>("orderhid")
                        .HasColumnType("integer");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<double>("qty")
                        .HasColumnType("double precision");

                    b.Property<double>("vat")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.HasIndex("itemid");

                    b.ToTable("Orderid", (string)null);
                });

            modelBuilder.Entity("EntityFramworkHM.Model.product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("name1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("name2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("EntityFramworkHM.Model.orderh", b =>
                {
                    b.HasOne("EntityFramworkHM.Model.customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("EntityFramworkHM.Model.orderid", b =>
                {
                    b.HasOne("EntityFramworkHM.Model.product", "product")
                        .WithMany()
                        .HasForeignKey("itemid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}
