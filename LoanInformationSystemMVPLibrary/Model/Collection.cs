using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.Model
{
    internal class Collection
    {
        public Guid Uid { get; set; }
        public string Id { get; set; }                
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
