using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLibrary
{
    public class Card
    {
        
        public DateTime TransactionDate { get; set; }
        public long? AccNo { get; set; }
        public long CardNo { get; set; }
        public string TransactionMode { get; set; }
        public string AccountType { get; set; }
        public decimal? Ammount { get; set; }

        public int Pin { get; set; }    

    }
}
