using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.View
{
    public interface IAddAmountAndDate
    {        
        decimal Amount { get; set; }
        DateTime Date { get; set; }
    }
}
