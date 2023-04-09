﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObjektorienteradAnalysOchDesignAssignment.Context;

#nullable disable

namespace ObjektorienteradAnalysOchDesignAssignment.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230405070340_Update_db")]
    partial class Update_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArticleEntityAuthorEntity", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("ArticleEntityAuthorEntity");
                });

            modelBuilder.Entity("ArticleEntityTagsEntity", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ArticleEntityTagsEntity");
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.ArticleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentTypeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.AuthorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.ContentTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("ContentType");
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.TagsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ArticleEntityAuthorEntity", b =>
                {
                    b.HasOne("ClassLibrary_Assignment.Models.Entities.ArticleEntity", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary_Assignment.Models.Entities.AuthorEntity", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleEntityTagsEntity", b =>
                {
                    b.HasOne("ClassLibrary_Assignment.Models.Entities.ArticleEntity", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary_Assignment.Models.Entities.TagsEntity", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.ArticleEntity", b =>
                {
                    b.HasOne("ClassLibrary_Assignment.Models.Entities.ContentTypeEntity", "ContentType")
                        .WithMany("Articles")
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentType");
                });

            modelBuilder.Entity("ClassLibrary_Assignment.Models.Entities.ContentTypeEntity", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}