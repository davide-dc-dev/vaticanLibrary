using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaticanLibrary.Core.Entities
{
    public class User
    {
        public string Name;
        public string Surname;
        public int ID;
        public DateOnly DateSubscription;
        public DateOnly? LastLoan;

        public User(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            ID = id;
            DateSubscription = DateOnly.FromDateTime(DateTime.Now);
            LastLoan = null;
        }
    }
}
