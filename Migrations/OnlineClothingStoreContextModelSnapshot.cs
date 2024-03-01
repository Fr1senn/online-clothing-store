﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineClothingStore.Models;

#nullable disable

namespace OnlineClothingStore.Migrations
{
    [DbContext(typeof(OnlineClothingStoreContext))]
    partial class OnlineClothingStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OnlineClothingStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("categories_pkey");

                    b.HasIndex(new[] { "Title" }, "categories_title_key")
                        .IsUnique();

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BeginDate")
                        .HasColumnType("date")
                        .HasColumnName("begin_date");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_active");

                    b.Property<int>("Percentage")
                        .HasColumnType("integer")
                        .HasColumnName("percentage");

                    b.HasKey("Id")
                        .HasName("discounts_pkey");

                    b.ToTable("discounts", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("manufacturers_pkey");

                    b.HasIndex(new[] { "Title" }, "manufacturers_title_key")
                        .IsUnique();

                    b.ToTable("manufacturers", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("order_date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("status_id");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("orders_pkey");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("quantity");

                    b.HasKey("Id")
                        .HasName("order_items_pkey");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("order_items", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<int?>("DiscountId")
                        .HasColumnType("integer")
                        .HasColumnName("discount_id");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("integer")
                        .HasColumnName("manufacturer_id");

                    b.Property<decimal>("Price")
                        .HasPrecision(7, 2)
                        .HasColumnType("numeric(7,2)")
                        .HasColumnName("price");

                    b.Property<int?>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("products_pkey");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int?>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<string>("Review1")
                        .HasColumnType("text")
                        .HasColumnName("review");

                    b.Property<DateOnly>("ReviewDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("review_date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("reviews_pkey");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("roles_pkey");

                    b.HasIndex(new[] { "Title" }, "roles_title_key")
                        .IsUnique();

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("statuses_pkey");

                    b.HasIndex(new[] { "Title" }, "statuses_title_key")
                        .IsUnique();

                    b.ToTable("statuses", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("first_name");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("hashed_password");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("last_name");

                    b.Property<DateOnly?>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("registration_date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("users_pkey");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Email" }, "users_email_key")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("wish_list_pkey");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("wish_list", (string)null);
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Order", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("orders_status_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("orders_user_id_fkey");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.OrderItem", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("order_items_order_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("order_items_product_id_fkey");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Product", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("products_category_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.Discount", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("products_discount_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("products_manufacturer_id_fkey");

                    b.Navigation("Category");

                    b.Navigation("Discount");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Review", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("reviews_product_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("reviews_user_id_fkey");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.User", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("users_role_id_fkey");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.WishList", b =>
                {
                    b.HasOne("OnlineClothingStore.Models.Product", "Product")
                        .WithMany("WishLists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("wish_list_product_id_fkey");

                    b.HasOne("OnlineClothingStore.Models.User", "User")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("wish_list_user_id_fkey");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Discount", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OnlineClothingStore.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });
#pragma warning restore 612, 618
        }
    }
}
