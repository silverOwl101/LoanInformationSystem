using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.Model
{
    internal class AllCollectionReport
    {        
        public DateTime Date { get; set; }
        public decimal Collection_Amount { get; set; }
        public decimal Salary_Amount { get; set; }
        public decimal Savings_Amount { get; set; }
    }
}
