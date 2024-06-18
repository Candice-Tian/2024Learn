namespace NetCoreLearn.Data
{
    public class BooksContext : DbContext
    {

        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<Books> Books { get; set; } = null!;
    }
}
