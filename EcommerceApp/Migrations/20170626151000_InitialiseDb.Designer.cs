using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EcommerceApp.Context;

namespace EcommerceApp.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20170626151000_InitialiseDb")]
    partial class InitialiseDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EcommerceApp.Models.Entities.CartItem", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<decimal?>("Price");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("Quantity");

                    b.Property<decimal?>("UnitPrice");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<DateTime?>("DateEntered");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("LastName");

                    b.Property<int>("PostalCode");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<decimal>("OrderTotal");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.OrderLine", b =>
                {
                    b.Property<int>("OrderLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.Property<decimal?>("Price");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("Quantity");

                    b.Property<decimal?>("UnitPrice");

                    b.HasKey("OrderLineId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLine");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName")
                        .HasMaxLength(100);

                    b.Property<int?>("ProductId");

                    b.HasKey("PictureId");

                    b.HasIndex("ProductId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Details");

                    b.Property<int?>("PictureId");

                    b.Property<byte[]>("ProductImagePath");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<decimal>("UnitPrice");

                    b.Property<int?>("UnitsInStock");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.CartItem", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Customer", "Customers")
                        .WithMany("CartItems")
                        .HasForeignKey("CustomerId");

                    b.HasOne("EcommerceApp.Models.Entities.Product", "Products")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Order", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.OrderLine", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Order", "Orders")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceApp.Models.Entities.Product", "Products")
                        .WithMany("OrderLines")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Picture", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Product")
                        .WithMany("Pictures")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.Product", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("EcommerceApp.Models.Entities.SubCategory", b =>
                {
                    b.HasOne("EcommerceApp.Models.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
