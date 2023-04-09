using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary_Assignment.Models.Entities;

//[Index(nameof(Type), IsUnique = true)]
public class ContentTypeEntity
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(1000)")]
    public string Type { get; set; } = null!;
    public ICollection<ArticleEntity>? Articles { get; set; }
}
