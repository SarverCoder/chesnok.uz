﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using chesnok.DataAccess;

#nullable disable

namespace chesnok.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("chesnok.Domain.Entities.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Calories")
                        .HasColumnType("integer")
                        .HasColumnName("calories");

                    b.Property<double>("Carbs")
                        .HasColumnType("double precision")
                        .HasColumnName("carbs");

                    b.Property<double>("Fats")
                        .HasColumnType("double precision")
                        .HasColumnName("fats");

                    b.Property<int>("FoodCategory")
                        .HasColumnType("integer")
                        .HasColumnName("food_category");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Protein")
                        .HasColumnType("double precision")
                        .HasColumnName("protein");

                    b.HasKey("Id")
                        .HasName("pk_food_items");

                    b.ToTable("food_items", (string)null);
                });

            modelBuilder.Entity("chesnok.Domain.Entities.MealLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodItemId")
                        .HasColumnType("integer")
                        .HasColumnName("food_item_id");

                    b.Property<DateTime>("LoggedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("logged_at");

                    b.Property<double>("Quantity")
                        .HasColumnType("double precision")
                        .HasColumnName("quantity");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_meal_logs");

                    b.HasIndex("FoodItemId")
                        .HasDatabaseName("ix_meal_logs_food_item_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_meal_logs_user_id");

                    b.ToTable("meal_logs", (string)null);
                });

            modelBuilder.Entity("chesnok.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("chesnok.Domain.Entities.MealLog", b =>
                {
                    b.HasOne("chesnok.Domain.Entities.FoodItem", "FoodItem")
                        .WithMany()
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_meal_logs_food_items_food_item_id");

                    b.HasOne("chesnok.Domain.Entities.User", "User")
                        .WithMany("MealLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_meal_logs_users_user_id");

                    b.Navigation("FoodItem");

                    b.Navigation("User");
                });

            modelBuilder.Entity("chesnok.Domain.Entities.User", b =>
                {
                    b.Navigation("MealLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
