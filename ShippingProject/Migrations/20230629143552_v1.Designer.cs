﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingProject.Models;

#nullable disable

namespace ShippingProject.Migrations
{
    [DbContext(typeof(ShippingContext))]
    [Migration("20230629143552_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShippingProject.Models.Branches", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id_city")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_city");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("ShippingProject.Models.Cities", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Regular_Shipping")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Governate");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ShippingProject.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Branch");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ShippingProject.Models.Employee_Order", b =>
                {
                    b.Property<string>("Id_employee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_employee", "Id_Order");

                    b.HasIndex("Id_Order");

                    b.ToTable("Employee_Orders");
                });

            modelBuilder.Entity("ShippingProject.Models.Governates", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Governates");
                });

            modelBuilder.Entity("ShippingProject.Models.Order", b =>
                {
                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address_trader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Branch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_City")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Type_Shipping")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_representive")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_type_paid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Order_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total_weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("flag_of_villagee")
                        .HasColumnType("bit");

                    b.Property<string>("oreder_salary_from_trader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_trader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_Branch")
                        .IsUnique()
                        .HasFilter("[Id_Branch] IS NOT NULL");

                    b.HasIndex("Id_City")
                        .IsUnique()
                        .HasFilter("[Id_City] IS NOT NULL");

                    b.HasIndex("Id_Governate")
                        .IsUnique()
                        .HasFilter("[Id_Governate] IS NOT NULL");

                    b.HasIndex("Id_Type_Shipping")
                        .IsUnique()
                        .HasFilter("[Id_Type_Shipping] IS NOT NULL");

                    b.HasIndex("Id_representive");

                    b.HasIndex("Id_type_paid")
                        .IsUnique()
                        .HasFilter("[Id_type_paid] IS NOT NULL");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShippingProject.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderId_Order")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("orderId_Order");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShippingProject.Models.Setting_Weight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Extra_weight")
                        .HasColumnType("float");

                    b.Property<string>("order_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("weight_shipping")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("order_id");

                    b.ToTable("Setting_Weights");
                });

            modelBuilder.Entity("ShippingProject.Models.Setting_shipping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("order_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("regular_shipping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("village_shipping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("order_id");

                    b.ToTable("Setting_shippings");
                });

            modelBuilder.Entity("ShippingProject.Models.Special_Price_Trader", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Trader")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("Id_Governate");

                    b.HasIndex("Id_Trader");

                    b.HasIndex("Id_city");

                    b.ToTable("Special_Price_Traders");
                });

            modelBuilder.Entity("ShippingProject.Models.Trader", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Per_Rejected_order")
                        .HasColumnType("float");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Branch");

                    b.HasIndex("Id_City");

                    b.HasIndex("Id_Governate");

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("ShippingProject.Models.Type_Of_Paid", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Type_Of_Paids");
                });

            modelBuilder.Entity("ShippingProject.Models.Type_Of_Shipping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Type_Of_Shippings");
                });

            modelBuilder.Entity("ShippingProject.Models.representive", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_percantage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_of_discount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Branch");

                    b.HasIndex("Id_Governate");

                    b.ToTable("representives");
                });

            modelBuilder.Entity("ShippingProject.Models.Branches", b =>
                {
                    b.HasOne("ShippingProject.Models.Cities", "city")
                        .WithMany("branches")
                        .HasForeignKey("Id_city");

                    b.Navigation("city");
                });

            modelBuilder.Entity("ShippingProject.Models.Cities", b =>
                {
                    b.HasOne("ShippingProject.Models.Governates", "governates")
                        .WithMany("cities")
                        .HasForeignKey("Id_Governate");

                    b.Navigation("governates");
                });

            modelBuilder.Entity("ShippingProject.Models.Employee", b =>
                {
                    b.HasOne("ShippingProject.Models.Branches", "branches")
                        .WithMany("employees")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branches");
                });

            modelBuilder.Entity("ShippingProject.Models.Employee_Order", b =>
                {
                    b.HasOne("ShippingProject.Models.Order", "order")
                        .WithMany("Employee_Order")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingProject.Models.Employee", "employee")
                        .WithMany("Employee_Order")
                        .HasForeignKey("Id_employee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("order");
                });

            modelBuilder.Entity("ShippingProject.Models.Order", b =>
                {
                    b.HasOne("ShippingProject.Models.Branches", "branches")
                        .WithOne("order")
                        .HasForeignKey("ShippingProject.Models.Order", "Id_Branch");

                    b.HasOne("ShippingProject.Models.Cities", "city")
                        .WithOne("order")
                        .HasForeignKey("ShippingProject.Models.Order", "Id_City");

                    b.HasOne("ShippingProject.Models.Governates", "Governates")
                        .WithOne("order")
                        .HasForeignKey("ShippingProject.Models.Order", "Id_Governate");

                    b.HasOne("ShippingProject.Models.Type_Of_Shipping", "type_Of_Shipping")
                        .WithOne("order")
                        .HasForeignKey("ShippingProject.Models.Order", "Id_Type_Shipping");

                    b.HasOne("ShippingProject.Models.representive", "representive")
                        .WithMany()
                        .HasForeignKey("Id_representive");

                    b.HasOne("ShippingProject.Models.Type_Of_Paid", "type_Of_Paid")
                        .WithOne("order")
                        .HasForeignKey("ShippingProject.Models.Order", "Id_type_paid");

                    b.Navigation("Governates");

                    b.Navigation("branches");

                    b.Navigation("city");

                    b.Navigation("representive");

                    b.Navigation("type_Of_Paid");

                    b.Navigation("type_Of_Shipping");
                });

            modelBuilder.Entity("ShippingProject.Models.Product", b =>
                {
                    b.HasOne("ShippingProject.Models.Order", "order")
                        .WithMany("product")
                        .HasForeignKey("orderId_Order");

                    b.Navigation("order");
                });

            modelBuilder.Entity("ShippingProject.Models.Setting_Weight", b =>
                {
                    b.HasOne("ShippingProject.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("ShippingProject.Models.Setting_shipping", b =>
                {
                    b.HasOne("ShippingProject.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("ShippingProject.Models.Special_Price_Trader", b =>
                {
                    b.HasOne("ShippingProject.Models.Governates", "Governates")
                        .WithMany()
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingProject.Models.Trader", "trader")
                        .WithMany()
                        .HasForeignKey("Id_Trader");

                    b.HasOne("ShippingProject.Models.Cities", "city")
                        .WithMany()
                        .HasForeignKey("Id_city")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("city");

                    b.Navigation("trader");
                });

            modelBuilder.Entity("ShippingProject.Models.Trader", b =>
                {
                    b.HasOne("ShippingProject.Models.Branches", "branches")
                        .WithMany("traders")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingProject.Models.Cities", "city")
                        .WithMany("traders")
                        .HasForeignKey("Id_City")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingProject.Models.Governates", "Governates")
                        .WithMany("traders")
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("branches");

                    b.Navigation("city");
                });

            modelBuilder.Entity("ShippingProject.Models.representive", b =>
                {
                    b.HasOne("ShippingProject.Models.Branches", "branches")
                        .WithMany("representive")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingProject.Models.Governates", "Governates")
                        .WithMany("representive")
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("branches");
                });

            modelBuilder.Entity("ShippingProject.Models.Branches", b =>
                {
                    b.Navigation("employees");

                    b.Navigation("order");

                    b.Navigation("representive");

                    b.Navigation("traders");
                });

            modelBuilder.Entity("ShippingProject.Models.Cities", b =>
                {
                    b.Navigation("branches");

                    b.Navigation("order");

                    b.Navigation("traders");
                });

            modelBuilder.Entity("ShippingProject.Models.Employee", b =>
                {
                    b.Navigation("Employee_Order");
                });

            modelBuilder.Entity("ShippingProject.Models.Governates", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("order");

                    b.Navigation("representive");

                    b.Navigation("traders");
                });

            modelBuilder.Entity("ShippingProject.Models.Order", b =>
                {
                    b.Navigation("Employee_Order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("ShippingProject.Models.Type_Of_Paid", b =>
                {
                    b.Navigation("order")
                        .IsRequired();
                });

            modelBuilder.Entity("ShippingProject.Models.Type_Of_Shipping", b =>
                {
                    b.Navigation("order")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}