﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Service;
using LoanInformationSystemMVPLibrary.View;
using System.Windows.Forms;

namespace LoanInformationSystemMVPLibrary.Presenter
{
    public class AddLoanPresenter
    {
        private IAddLoan _addLoan;
        private Loan _loan = new Loan();
        private Customer _customer = new Customer();
        private LoanService _loanService = new LoanService();        
        public AddLoanPresenter(IAddLoan addloan)
        {
            _addLoan = addloan;
            _customer.Id = _addLoan.CustomerID;
        }

        public void OnLoadInsertLoan()
        {                        
            if (_loanService.OnSetIsLoanStatusUnpaid(_addLoan.CustomerID) is true)
            {
                ErrorMessage("Customer has pending loan", "Cannot Add loan");
            }
            else
            {
                string message = _loanService.OnSetInsertLoan(LoadData(_loan), _customer);
                SuccessfulMessage(message, "Loan Recorded");
            }            
        }
        private Loan LoadData(Loan loan)
        {
            loan.PaymentTerm = _addLoan.PaymentTerm;
            loan.Duration = _addLoan.Duration;
            loan.EffectiveDate = _addLoan.EffectiveDate;
            loan.Interest = _addLoan.Interest;
            loan.PrincipalLoan = _addLoan.PrincipalLoan;
            loan.Penalty = _addLoan.Penalty;
            return loan;
        }
        private void SuccessfulMessage(string text, string messageCaption)
        {                        
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ErrorMessage(string text, string messageCaption)
        {
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
