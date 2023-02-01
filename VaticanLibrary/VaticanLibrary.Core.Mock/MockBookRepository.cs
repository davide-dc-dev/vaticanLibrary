using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaticanLibrary.Core.Entities;

namespace VaticanLibrary.Core.Mock
{
    public class MockBookRepository
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



    }
}
