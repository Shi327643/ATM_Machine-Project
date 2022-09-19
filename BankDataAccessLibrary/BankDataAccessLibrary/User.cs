using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLibrary
{
    public class User
    {
        public long CardNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pin { get; set; }
        public long AccNo { get; set; }
        public long ContactNo { get; set; }

        public decimal? Balance { get; set; }

    }
}
