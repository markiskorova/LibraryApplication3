using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public interface ILibraryRepository
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBookById(int id);
        
        //Task AddBookAsync(Book book);
        //Task UpdateBookAsync(Book book);
        //Task DeleteBookAsync(int id);
        public IEnumerable<Member> GetMembers();
        public Member GetMemberById(int id);
        //Task AddMemberAsync(Member member);
        public IEnumerable<Checkout> GetCheckouts();
        public Checkout GetCheckoutById(int id);

        //Task AddCheckoutAsync(Checkout checkout);
        //Task<Checkout> GetCheckoutByIdAsync(int id);
        //Task ReturnBookAsync(int checkoutId, DateTime returnDate);

    }
}
