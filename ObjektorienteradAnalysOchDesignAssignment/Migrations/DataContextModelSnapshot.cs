﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObjektorienteradAnalysOchDesignAssignment.Context;

#nullable disable

namespace ObjektorienteradAnalysOchDesignAssignment.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entities.AuthorArticleRowEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorArticleRow");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ArticleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex("TagId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.AuthorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ContentTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ContentType");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entities.AuthorArticleRowEntity", b =>
                {
                    b.HasOne("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ArticleEntity", "Article")
                        .WithMany("AuthorRow")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.AuthorEntity", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ArticleEntity", b =>
                {
                    b.HasOne("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ContentTypeEntity", "ContentType")
                        .WithMany("Articles")
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.TagEntity", "Tag")
                        .WithMany("Articles")
                        .HasForeignKey("TagId");

                    b.Navigation("ContentType");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ArticleEntity", b =>
                {
                    b.Navigation("AuthorRow");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.AuthorEntity", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.ContentTypeEntity", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ObjektorienteradAnalysOchDesignAssignment.Models.Entity.TagEntity", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
