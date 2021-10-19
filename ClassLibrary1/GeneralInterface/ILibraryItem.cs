using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILibraryItem
    {   
        //Properties
        string LibraryId { get; set; }
        string Title { get; set; }
        //string Author { get; set; }
        //DateTime BorrowDate { get; set; }
        //string Borrower { get; set; }
        //int CheckOutDurationInDays { get; set; }
        //int Pages { get; set; }

        //Functions
        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}
