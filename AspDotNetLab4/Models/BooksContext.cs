using Microsoft.EntityFrameworkCore;

namespace AspDotNetLab4.Models
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }
    }
}
