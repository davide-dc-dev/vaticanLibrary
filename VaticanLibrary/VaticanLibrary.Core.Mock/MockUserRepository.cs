using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using VaticanLibrary.Core.Entities;
using VaticanLibrary.Core.Interfaces;

namespace VaticanLibrary.Core.Mock
{
    public class MockUserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>
        {
            new User("Giuseppe", "De Vivo", 1),
            new User("Davide", "De Cienzo", 2),
            new User("Umberto", "Cuomo", 3),
            new User("Joseph", "Ratzinger", 4),
            new User("Freancesco", "Assisi", 5),
            new User("Carlo", "Borbone", 6),

        };

        public void Create(User newItem)
        {
            _users.Add(newItem);
        }

        public void DeleteById(int id)
        {
            foreach (var user in _users)
            {
                if (user.ID== id)
                {
                    _users.Remove(user);
                    break;
                }   
            }
        }

        public IEnumerable<User> Fetch(Func<User, bool> filter = null)
        {
            if (filter != null)
                return _users.Where(filter);

            return _users;
        }

        public User GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("Invalid Ticket Id.");

            return _users.FirstOrDefault(t => t.ID == id);
        }

        public void Update(User updateItem)
        {
            for (var i = 0; i<_users.Count; i++)
            {
                if (updateItem.ID == _users[i].ID)
                {
                    _users[i] = updateItem;
                    break;

                }
            }
        }
    }
}
