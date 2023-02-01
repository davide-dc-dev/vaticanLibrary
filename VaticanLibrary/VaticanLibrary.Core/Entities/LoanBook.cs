using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaticanLibrary.Core.Entities
{
    public class LoanBook
    {

        public int IdUser { get; set; }
        public int ISBN { get; set; }

        public DateOnly StartLoan { get; set; }

        public DateOnly EndLoan { get; set; }

        public LoanBook(int idUser, int isbn, DateOnly startLoan, DateOnly endLoan)
        {
            IdUser = idUser;
            ISBN = isbn;
            StartLoan = startLoan;
            EndLoan = endLoan;
        }
    }
}
