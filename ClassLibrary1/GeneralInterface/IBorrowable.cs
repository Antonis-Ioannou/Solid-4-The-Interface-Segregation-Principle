using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IBorrowable
    {
        //properties
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }

        //functions
        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}