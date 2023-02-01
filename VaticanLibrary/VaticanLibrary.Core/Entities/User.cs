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
        public DateOnly LastLoan;

        User(string name, string surname, int id, DateOnly lastLoan)
        {
            Name = name;
            Surname = surname;
            ID = id;
            LastLoan = lastLoan;
            DateSubscription = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
