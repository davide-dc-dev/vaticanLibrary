using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaticanLibrary.Core.Entities;
using VaticanLibrary.Core.Interfaces;

namespace VaticanLibrary.Core.Mock
{
    public class MockBookRepository  : IBookRepository
    {

        private static readonly List<Book> _books = new List<Book>
        {

            new Book(3500,
                "I segreti proibiti del vaticano",
                "Peppe De Vivo",
                "Thriller"    
                
            ),

            new Book(3501,
                "I segreti proibiti parte 2",
                "Damiano",
                "Romanzo")
           


        };

        public void Create(Book newItem)
        {
            _books.Add(newItem);
        }

        public void DeleteById(int id)
        {
           foreach(var book in _books)
            {
                if(book.ISBN == id)
                {
                    _books.Remove(book);
                    break;
                }
                    
            }
        }

        public IEnumerable<Book> Fetch(Func<Book, bool> filter = null)
        {
            if (filter != null)
                return _books.Where(filter);

            return _books;

        }

        public Book GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("Invalid Ticket Id.");

            return _books.FirstOrDefault(t => t.ISBN == id);
        }

        public void Update(Book updateItem)
        {
            for(var i=0;i<_books.Count;i++)
            {
                if(updateItem.ISBN == _books[i].ISBN)
                {
                    _books[i] = updateItem;
                    break;
                }
            }
        }
    }
}
