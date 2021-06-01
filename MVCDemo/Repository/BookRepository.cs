using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly List<BookModel> _booksRepository;

        public BookRepository()
        {
            _booksRepository = new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Title = "Aasd",
                    Author = "book author",
                    Genre = "Fantasy",
                    PublishDate = new DateTime(2000 / 01 / 01)
                },
                new BookModel()
                {
                    Id = 2,
                    Title = "Dads",
                    Author = "book author",
                    Genre = "Fantasy",
                    PublishDate = new DateTime(1997 / 04 / 04)
                },
            };
        }

        public void CreateBook(BookModel book)
        {
            _booksRepository.Add(book);
        }

        public List<BookModel> GetBooks()
        {
            return _booksRepository;
        }
    }
}
