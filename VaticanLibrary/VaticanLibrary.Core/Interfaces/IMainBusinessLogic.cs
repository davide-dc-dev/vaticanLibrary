using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using VaticanLibrary.Core.Entities;

namespace VaticanLibrary.Core.Interfaces
{
    public interface IMainBusinessLogic
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}
