
using ClassLibrary_Assignment.Models.Entities;


namespace ClassLibrary_Assignment.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }


        public static implicit operator AuthorEntity(AuthorModel model)
        {
            var entity = new AuthorEntity
            {
                Id = model.Id,
                Name = "hej"
            };

            return entity;
        }
    }
}
