namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    public class TagEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ArticleEntity> Articles { get; set; }
    }
}
