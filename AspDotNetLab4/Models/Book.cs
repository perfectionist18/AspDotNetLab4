using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetLab4.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Назва книги")]
        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Введіть назву книги")]
        public string Title { get; set; }
        [DisplayName("Рік видання")]
        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Введіть рік")]
        public string Year { get; set; }
        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
