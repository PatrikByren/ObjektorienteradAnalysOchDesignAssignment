namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    public class AuthorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ArticleEntity> Articles { get; set; }
    }
}
