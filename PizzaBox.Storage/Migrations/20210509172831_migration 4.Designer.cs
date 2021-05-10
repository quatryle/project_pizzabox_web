﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaBox.Storage;

namespace PizzaBox.Storage.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210509172831_migration 4")]
    partial class migration4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Plain"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Thin Crust"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Deep Dish"
                        },
                        new
                        {
                            EntityId = 4L,
                            Name = "Stuffed Crust"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "John Connor"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Thaddeus Good Ignatius Friday"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CustomerEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CustomerEntityId");

                    b.HasIndex("StoreEntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("SizeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("SizeEntityId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PresetPizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Crust")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Top1")
                        .HasColumnType("text");

                    b.Property<string>("Top2")
                        .HasColumnType("text");

                    b.Property<string>("Top3")
                        .HasColumnType("text");

                    b.Property<string>("Top4")
                        .HasColumnType("text");

                    b.Property<string>("Top5")
                        .HasColumnType("text");

                    b.Property<string>("Top6")
                        .HasColumnType("text");

                    b.Property<string>("Top7")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("PresetPizzas");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Custom Pizza"
                        },
                        new
                        {
                            EntityId = 2L,
                            Crust = "Plain",
                            Name = "Margherita Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese"
                        },
                        new
                        {
                            EntityId = 3L,
                            Crust = "Plain",
                            Name = "Pepperoni Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese",
                            Top3 = "Pepperoni"
                        },
                        new
                        {
                            EntityId = 4L,
                            Crust = "Plain",
                            Name = "Chicken Alfredo Pizza",
                            Top1 = "Alfredo Sauce",
                            Top2 = "Mozzarella Cheese",
                            Top3 = "Sausage"
                        },
                        new
                        {
                            EntityId = 5L,
                            Crust = "Deep Dish",
                            Name = "Deep Dish Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese"
                        },
                        new
                        {
                            EntityId = 6L,
                            Crust = "Thin Crust",
                            Name = "Thin Crust Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese"
                        },
                        new
                        {
                            EntityId = 7L,
                            Crust = "Plain",
                            Name = "Meat Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese",
                            Top3 = "Sausage",
                            Top4 = "Bacon",
                            Top5 = "Chicken",
                            Top6 = "Pepperoni"
                        },
                        new
                        {
                            EntityId = 8L,
                            Crust = "Plain",
                            Name = "Veggie Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese",
                            Top3 = "Sliced Tomato",
                            Top4 = "Mushrooms",
                            Top5 = "Onions",
                            Top6 = "Olives",
                            Top7 = "Green Peppers"
                        },
                        new
                        {
                            EntityId = 9L,
                            Crust = "Plain",
                            Name = "Four Cheese Pizza",
                            Top1 = "Tomato Sauce",
                            Top2 = "Mozzarella Cheese",
                            Top3 = "Cheddar Cheese",
                            Top4 = "Provalone Cheese",
                            Top5 = "Parmesan Cheese"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Small"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Medium"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Large"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Times Square Store"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Liberty Park Store"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Harvard Square Store"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityId");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Tomato Sauce",
                            Type = 1
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Alfredo Sauce",
                            Type = 1
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Garlic Sauce",
                            Type = 1
                        },
                        new
                        {
                            EntityId = 4L,
                            Name = "Mozzarella Cheese",
                            Type = 2
                        },
                        new
                        {
                            EntityId = 5L,
                            Name = "Cheddar Cheese",
                            Type = 2
                        },
                        new
                        {
                            EntityId = 6L,
                            Name = "Provalone Cheese",
                            Type = 2
                        },
                        new
                        {
                            EntityId = 7L,
                            Name = "Parmesan Cheese",
                            Type = 2
                        },
                        new
                        {
                            EntityId = 8L,
                            Name = "Pepperoni",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 9L,
                            Name = "Sausage",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 10L,
                            Name = "Anchovy",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 11L,
                            Name = "Bacon",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 12L,
                            Name = "Chicken",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 13L,
                            Name = "Ham",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 14L,
                            Name = "Sliced Tomato",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 15L,
                            Name = "Onions",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 16L,
                            Name = "Green Peppers",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 17L,
                            Name = "Olives",
                            Type = 3
                        },
                        new
                        {
                            EntityId = 18L,
                            Name = "Mushrooms",
                            Type = 3
                        });
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.Property<long>("PizzasEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingsEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("PizzasEntityId", "ToppingsEntityId");

                    b.HasIndex("ToppingsEntityId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Store", null)
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crust");

                    b.Navigation("Order");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingsEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
