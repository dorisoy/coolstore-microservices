// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VND.CoolStore.Services.Cart.v1.Db;

namespace VND.CoolStore.Services.Cart.Migrations
{
    [DbContext(typeof(CartDbContext))]
    partial class CartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VND.CoolStore.Services.Cart.Domain.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CartItemPromoSavings");

                    b.Property<double>("CartItemTotal");

                    b.Property<double>("CartTotal");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsCheckout");

                    b.Property<double>("ShippingPromoSavings");

                    b.Property<double>("ShippingTotal");

                    b.Property<DateTime>("Updated");

                    b.Property<int>("Version");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Cart.Domain.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CartId");

                    b.Property<DateTime>("Created");

                    b.Property<double>("Price");

                    b.Property<double>("PromoSavings");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Cart.Domain.Product", b =>
                {
                    b.Property<Guid>("Id");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VND.CoolStore.Services.Cart.Domain.CartItem", b =>
                {
                    b.HasOne("VND.CoolStore.Services.Cart.Domain.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VND.CoolStore.Services.Cart.Domain.Product", b =>
                {
                    b.HasOne("VND.CoolStore.Services.Cart.Domain.CartItem", "CartItem")
                        .WithOne("Product")
                        .HasForeignKey("VND.CoolStore.Services.Cart.Domain.Product", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
