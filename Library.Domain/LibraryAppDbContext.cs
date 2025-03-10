using Library.Domain.Entities;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Library.Domain
{
    public class LibraryAppDbContext : DbContext
    {
        public LibraryAppDbContext(DbContextOptions<LibraryAppDbContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

    }
}