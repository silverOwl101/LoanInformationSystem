using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.View
{
    public interface IAddPenalty
    {
        DateTime DateOfPenalty { get; set; }
        decimal PenaltyAmount { get; set; }
    }
}
