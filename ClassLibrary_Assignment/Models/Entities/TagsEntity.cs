using System.ComponentModel.DataAnnotations.Schema;


namespace ClassLibrary_Assignment.Models.Entities;

//[Index(nameof(Tag), IsUnique = true)]
public class TagsEntity
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(1000)")]
    public string Tag { get; set; } = null!;
    public ICollection<ArticleEntity>? Articles { get; set; }
}
