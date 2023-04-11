using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<AuthorEntity> Author { get; set; }
        public DbSet<ContentTypeEntity> ContentType { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<AuthorArticleRowEntity> AuthorArticleRow { get; set; }

    }
}
