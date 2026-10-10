using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }=DateTime.Now;

        public string AuthorName { get; set; }

        public string Nickname { get; set; }
    }
}