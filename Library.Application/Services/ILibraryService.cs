using Library.Domain.Entities;

namespace Library.Application.Services
{
    public interface ILibraryService
    {
        public Book GetBookById(int id);
        public IEnumerable<Book> GetBooks();
        public IEnumerable<Member> GetMembers();
        public Member GetMemberById(int id);
        public IEnumerable<Checkout> GetCheckouts();
        public Checkout GetCheckoutById(int id);
       
    }
}