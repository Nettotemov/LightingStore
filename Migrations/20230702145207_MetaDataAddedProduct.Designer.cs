﻿// <auto-generated />
using System;
using LampStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LampStore.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20230702145207_MetaDataAddedProduct")]
    partial class MetaDataAddedProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LampStore.Models.AboutPages.AboutPage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("DisplayHomePage")
                        .HasColumnType("bit");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgOneUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<bool>("MainAboutCompany")
                        .HasColumnType("bit");

                    b.Property<string>("Paragraph")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutPages");
                });

            modelBuilder.Entity("LampStore.Models.AboutPages.AdditionalBlocksForAboutPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("AboutPageId")
                        .HasColumnType("bigint");

                    b.Property<byte>("AdditionalBlockType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AboutPageId");

                    b.ToTable("AdditionalBlocksForAboutPage");
                });

            modelBuilder.Entity("LampStore.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartLineID"), 1L, 1);

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("LampStore.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CategoryImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DisplayHomePage")
                        .HasColumnType("bit");

                    b.Property<bool>("DisplaySlider")
                        .HasColumnType("bit");

                    b.Property<string>("HeadingThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadingTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgThreeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgTwoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Slider")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("LampStore.Models.CollectionsLights.AdditionalBlocksForCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("AdditionalBlockType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CollectionLightId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionLightId");

                    b.ToTable("AdditionalBlocksForCollection");
                });

            modelBuilder.Entity("LampStore.Models.CollectionsLights.CollectionLight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHomePage")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CollectionLights");
                });

            modelBuilder.Entity("LampStore.Models.ConfidentPolicy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ConfidentPolicyNodes");
                });

            modelBuilder.Entity("LampStore.Models.Cooperation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CooperationImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("MinDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCooperation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CooperationPages");
                });

            modelBuilder.Entity("LampStore.Models.Info", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("NameInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SvgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextForBanner")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("InfoPages");
                });

            modelBuilder.Entity("LampStore.Models.InfoProp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("InfoId")
                        .HasColumnType("int");

                    b.Property<string>("InfoPropLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("TypesAddintionalFields")
                        .HasColumnType("tinyint");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InfoId");

                    b.ToTable("InfoProp");
                });

            modelBuilder.Entity("LampStore.Models.LightsModels.AdditionalBlocksForModelLight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("AdditionalBlockType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ModelLightId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelLightId");

                    b.ToTable("AdditionalBlocksForModelLight");
                });

            modelBuilder.Entity("LampStore.Models.LightsModels.ModelLight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CollectionLightId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHomePage")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionLightId");

                    b.ToTable("LightsModels");
                });

            modelBuilder.Entity("LampStore.Models.MetaTags.MetaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long?>("AboutPageId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<int?>("CollectionLightId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutPageId")
                        .IsUnique()
                        .HasFilter("[AboutPageId] IS NOT NULL");

                    b.HasIndex("CategoryId")
                        .IsUnique()
                        .HasFilter("[CategoryId] IS NOT NULL");

                    b.HasIndex("CollectionLightId")
                        .IsUnique()
                        .HasFilter("[CollectionLightId] IS NOT NULL");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasFilter("[ProductId] IS NOT NULL");

                    b.ToTable("MetaDatas");
                });

            modelBuilder.Entity("LampStore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GiftWrap")
                        .HasColumnType("bit");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Shipped")
                        .HasColumnType("bit");

                    b.Property<byte>("StatusOrders")
                        .HasColumnType("tinyint");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("AddControl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artikul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("BaseSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<int?>("CollectionLightId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CordLength")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Kelvins")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainPhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModelLightId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OldPrice")
                        .HasColumnType("bigint");

                    b.Property<string>("Photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CollectionLightId");

                    b.HasIndex("ModelLightId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeProducts");
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("LampStore.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("NameSettings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Setting")
                        .HasColumnType("tinyint");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.Property<int>("ProductTagsId")
                        .HasColumnType("int");

                    b.Property<long>("ProductsId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductTagsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("LampStore.Models.AboutPages.AdditionalBlocksForAboutPage", b =>
                {
                    b.HasOne("LampStore.Models.AboutPages.AboutPage", "AboutPage")
                        .WithMany("AdditionalBlocks")
                        .HasForeignKey("AboutPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AboutPage");
                });

            modelBuilder.Entity("LampStore.Models.CartLine", b =>
                {
                    b.HasOne("LampStore.Models.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("LampStore.Models.ProductsPages.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LampStore.Models.CollectionsLights.AdditionalBlocksForCollection", b =>
                {
                    b.HasOne("LampStore.Models.CollectionsLights.CollectionLight", "CollectionModel")
                        .WithMany("AdditionalBlocks")
                        .HasForeignKey("CollectionLightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CollectionModel");
                });

            modelBuilder.Entity("LampStore.Models.InfoProp", b =>
                {
                    b.HasOne("LampStore.Models.Info", null)
                        .WithMany("InfoProp")
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LampStore.Models.LightsModels.AdditionalBlocksForModelLight", b =>
                {
                    b.HasOne("LampStore.Models.LightsModels.ModelLight", "ModelLight")
                        .WithMany("AdditionalBlocks")
                        .HasForeignKey("ModelLightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelLight");
                });

            modelBuilder.Entity("LampStore.Models.LightsModels.ModelLight", b =>
                {
                    b.HasOne("LampStore.Models.CollectionsLights.CollectionLight", "CollectionModel")
                        .WithMany("ModelLights")
                        .HasForeignKey("CollectionLightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CollectionModel");
                });

            modelBuilder.Entity("LampStore.Models.MetaTags.MetaData", b =>
                {
                    b.HasOne("LampStore.Models.AboutPages.AboutPage", "AboutPage")
                        .WithOne("MetaData")
                        .HasForeignKey("LampStore.Models.MetaTags.MetaData", "AboutPageId");

                    b.HasOne("LampStore.Models.Category", "Category")
                        .WithOne("MetaData")
                        .HasForeignKey("LampStore.Models.MetaTags.MetaData", "CategoryId");

                    b.HasOne("LampStore.Models.CollectionsLights.CollectionLight", "CollectionLight")
                        .WithOne("MetaData")
                        .HasForeignKey("LampStore.Models.MetaTags.MetaData", "CollectionLightId");

                    b.HasOne("LampStore.Models.ProductsPages.Product", "Product")
                        .WithOne("MetaData")
                        .HasForeignKey("LampStore.Models.MetaTags.MetaData", "ProductId");

                    b.Navigation("AboutPage");

                    b.Navigation("Category");

                    b.Navigation("CollectionLight");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.Product", b =>
                {
                    b.HasOne("LampStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LampStore.Models.CollectionsLights.CollectionLight", "CollectionLight")
                        .WithMany("Products")
                        .HasForeignKey("CollectionLightId");

                    b.HasOne("LampStore.Models.LightsModels.ModelLight", "ModelLight")
                        .WithMany("Products")
                        .HasForeignKey("ModelLightId");

                    b.HasOne("LampStore.Models.ProductsPages.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CollectionLight");

                    b.Navigation("ModelLight");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.HasOne("LampStore.Models.ProductsPages.Tag", null)
                        .WithMany()
                        .HasForeignKey("ProductTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LampStore.Models.ProductsPages.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LampStore.Models.AboutPages.AboutPage", b =>
                {
                    b.Navigation("AdditionalBlocks");

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("LampStore.Models.Category", b =>
                {
                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("LampStore.Models.CollectionsLights.CollectionLight", b =>
                {
                    b.Navigation("AdditionalBlocks");

                    b.Navigation("MetaData")
                        .IsRequired();

                    b.Navigation("ModelLights");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("LampStore.Models.Info", b =>
                {
                    b.Navigation("InfoProp");
                });

            modelBuilder.Entity("LampStore.Models.LightsModels.ModelLight", b =>
                {
                    b.Navigation("AdditionalBlocks");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("LampStore.Models.Order", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.Product", b =>
                {
                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("LampStore.Models.ProductsPages.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
