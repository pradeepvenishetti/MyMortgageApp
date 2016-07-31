using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageApp.Model
{
    class Borrower
    {

        public int BorrowerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public bool IsPrimary { get; set; }

    }
}
