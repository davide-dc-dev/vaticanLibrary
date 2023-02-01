using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaticanLibrary.Core.Entities;
using VaticanLibrary.Core.Interfaces;

namespace VaticanLibrary.Core.BusinessLogic
{
    public class MainBusinessLogic : IMainBusinessLogic
    {

        private readonly IBookRepository bookRepo;
        private readonly IUserRepository userRepo;


        public MainBusinessLogic(IBookRepository bookRepo, IUserRepository userRepo)
        {
            this.bookRepo = bookRepo;
            this.userRepo = userRepo;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepo.Fetch();
        }

        public void InsertBook(Book book)
        {
            bookRepo.Create(book);
        }

        public void RemoveBook(int id)
        {
            bookRepo.DeleteById(id);
        }

        public void UpdateBook(Book book)
        {
            bookRepo.Update(book);
        }


        public IEnumerable<User> GetAllUsers()
        {
            return userRepo.Fetch();
        }

        public Book GetBookById(int bookId)
        {
            return bookRepo.GetById(bookId);
        }

        public User GetUserById(int userId)
        {
            return userRepo.GetById(userId);
        }

        public void InsertUser(User user)
        {
            userRepo.Create(user);
        }

        public void RemoveUser(int id)
        {
            userRepo.DeleteById(id);
        }

        public void UpdateUser(User user)
        {
            userRepo.Update(user);
        }
    }
}
