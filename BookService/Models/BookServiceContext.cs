using System.Data.Entity;

namespace BookService.Models
{
	public class BookServiceContext : DbContext
	{
		public BookServiceContext() : base("name=BookServiceContext")
		{
		}

		public DbSet<Author> Authors { get; set; }

		public DbSet<Book> Books { get; set; }
	}
}
