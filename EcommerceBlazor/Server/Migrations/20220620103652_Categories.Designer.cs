﻿// <auto-generated />
using EcommerceBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceBlazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220620103652_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceBlazor.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TV Shows",
                            Url = "tv-shows"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Breaking Bad is an American neo-Western crime drama television series created and produced by Vince Gilligan. Set and filmed in Albuquerque, New Mexico, it tells the story of Walter White (Bryan Cranston), an underpaid, overqualified, and dispirited high-school chemistry teacher who is struggling with a recent diagnosis of stage-three lung cancer. Walter turns to a life of crime, partnering with his former student Jesse Pinkman (Aaron Paul), by producing and distributing crystal meth to secure his family's financial future before he dies, while navigating the dangers of the criminal underworld.",
                            ImageUrl = "https://content2.rozetka.com.ua/goods/images/big/23632594.jpg",
                            Price = 11.99m,
                            Title = "Breaking Bad"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Raised by Wolves is an American science fiction drama television series created by Aaron Guzikowski that premiered on HBO Max on September 3, 2020. The first two episodes were directed by Ridley Scott, who also serves as an executive producer for the show. The series was renewed for a second season shortly after its debut, and the second season premiered on February 3, 2022. The first season was met with generally positive reviews from critics, while the second season has received critical acclaim. In June 2022, the series was cancelled after two seasons.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/6/64/Raised_by_Wolves_%28TV%29.jpg",
                            Price = 7.99m,
                            Title = "Raised by Wolves"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Constructed as a nonlinear narrative, season one focuses on Louisiana State Police homicide detectives Rustin Rust Cohle (McConaughey) and Martin Marty Hart (Harrelson), who investigated the murder of prostitute Dora Lange in 1995. Seventeen years later, they must revisit the investigation, along with several other unsolved crimes. During this time, Hart's infidelity threatens his marriage to Maggie (Monaghan), and Cohle struggles to cope with his troubled past.",
                            ImageUrl = "https://i.pinimg.com/originals/73/61/58/7361583898d2e42805a913c10bfa39fb.jpg",
                            Price = 10.99m,
                            Title = "True Detective"
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Product", b =>
                {
                    b.HasOne("EcommerceBlazor.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
