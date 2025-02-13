using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.View
{
    public interface ILogIn
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
