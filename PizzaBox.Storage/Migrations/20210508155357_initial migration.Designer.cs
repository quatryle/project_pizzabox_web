﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaBox.Storage;

namespace PizzaBox.Storage.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210508155357_initial migration")]
    partial class initialmigration
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

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("EntityId");

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

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
