
using System.ComponentModel.DataAnnotations.Schema;


namespace ClassLibrary_Assignment.Models.Entities;

//[Index(nameof(Name), IsUnique = true)]
public class AuthorEntity
{
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(200)")]
    public string Name { get; set; } = null!;
    public ICollection<ArticleEntity>? Articles { get; set; }
}
