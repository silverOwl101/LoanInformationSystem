﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemMVPLibrary.Model
{
    public class GetCustomerLoanInformation
    {        
        public string Id { get; set; }
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string PaymentTerm { get; set; }
        public int Duration { get; set; }
        public string EffectiveDate { get; set; }
        public decimal Interest { get; set; }
        public decimal PrincipalLoan { get; set; }        
        public string Status { get; set; }
        public decimal CollectedAmount { get; set; }
        public decimal PenaltyAmount { get; set; }
    }
}
