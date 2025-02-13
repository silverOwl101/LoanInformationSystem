using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.Model
{
    internal class PenaltyReport
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public decimal Penalty { get; set; }
        
    }
}
