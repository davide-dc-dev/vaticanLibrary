using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaticanLibrary.Core.Entities
{
    public class LoanBook
    {

        public string IdUser { get; set; }
        public string ISBN { get; set; }

        public DateOnly StartLoan { get; set; }

        public DateOnly EndLoan { get; set; }

        public LoanBook(string idUser, string isbn, DateOnly startLoan, DateOnly endLoan)
        {
            IdUser = idUser;
            ISBN = isbn;
            StartLoan = startLoan;
            EndLoan = endLoan;
        }
    }
}
