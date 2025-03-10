using Library.Domain;
using Library.Domain.Entities;
using Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly LibraryAppDbContext _context;

        public LibraryRepository(LibraryAppDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Book> GetBooks() => _context.Books.ToList();

        public Book GetBookById(int id) => _context.Books.Find(id);

        /*
        public async Task AddBookAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
        */

       public IEnumerable<Member> GetMembers() => _context.Members.ToList();

       public Member GetMemberById(int id) => _context.Members.Find(id);
        
        /*
       public async Task AddMemberAsync(Member member)
       {
           await _context.Members.AddAsync(member);
           await _context.SaveChangesAsync();
       }

       */
        public IEnumerable<Checkout> GetCheckouts() => _context.Checkouts.ToList();

        public Checkout GetCheckoutById(int id) => _context.Checkouts.Find(id);
        /*
        public async Task AddCheckoutAsync(Checkout checkout)
        {
            await _context.Checkouts.AddAsync(checkout);
            await _context.SaveChangesAsync();
        }

        public async Task<Checkout> GetCheckoutByIdAsync(int id) => await _context.Checkouts.FindAsync(id);

        public async Task ReturnBookAsync(int checkoutId, DateTime returnDate)
        {
            var checkout = await _context.Checkouts.FindAsync(checkoutId);
            if (checkout != null)
            {
                checkout.ReturnDate = returnDate;
                await _context.SaveChangesAsync();
            }
        }
        */
    }
}
