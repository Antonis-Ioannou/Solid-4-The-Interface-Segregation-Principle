using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Title { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }

        public void CheckOut(string borrower)
        {
            this.Borrower = borrower;
            this.BorrowDate = DateTime.Now;
        }

        public void CheckIn()
        {
            this.Borrower = "";
        }
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
