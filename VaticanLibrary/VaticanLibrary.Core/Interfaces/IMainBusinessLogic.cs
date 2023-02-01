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
        public void InsertBook(Book book);
        public void RemoveBook(int id);
        public void UpdateBook(Book book); 
        Book GetBookById(int bookId);
        IEnumerable<User> GetAllUsers();
        public void InsertUser(User user);
        public void RemoveUser(int id);
        public void UpdateUser(User user);
        User GetUserById(int userId);
    }
}
