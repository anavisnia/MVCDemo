using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Repository
{
    public interface IBookRepository
    {
        List<BookModel> GetBooks();

        void CreateBook(BookModel book);
    }
}
