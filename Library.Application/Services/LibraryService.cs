using Library.Domain.Entities;
using Library.Domain.Repositories;

namespace Library.Application.Services
{
    public class LibraryService : ILibraryService
    {
        private ILibraryRepository libraryRepository;

        public LibraryService(ILibraryRepository libraryRepository)
        {
            this.libraryRepository = libraryRepository;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = libraryRepository.GetBooks();
            return books;
        }

        public Book GetBookById(int id)
        {
            var book = libraryRepository.GetBookById(id);
            return book;
        }

        public IEnumerable<Member> GetMembers()
        {
            var members = libraryRepository.GetMembers();
            return members;
        }

        public Member GetMemberById(int id)
        {
            var member = libraryRepository.GetMemberById(id);
            return member;
        }

        public IEnumerable<Checkout> GetCheckouts()
        {
            var checkouts = libraryRepository.GetCheckouts();
            return checkouts;
        }

        public Checkout GetCheckoutById(int id)
        {
            var checkout = libraryRepository.GetCheckoutById(id);
            return checkout;
        }



    }
}
