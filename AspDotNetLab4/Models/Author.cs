using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetLab4.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [DisplayName("Ім'я")]
        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Введіть ім'я")]
        public string Name { get; set; }
        [DisplayName("Прізвище")]
        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Введіть прізвище")]
        public string Surname { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
