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
    public class AddCustomerPresenter
    {   
        #region Fields

        private IAddCustomer _addCustomer;
        private Customer _customer;
        private CustomerBusinessInformation _customerBusinessInformation;
        private CustomerService _customerService;

        #endregion

        public AddCustomerPresenter(IAddCustomer addCustomer)
        {
            _addCustomer = addCustomer;
        }        
        public void OnLoadInsertData()
        {
            _customer = new Customer
            {
                Name = _addCustomer.CustomerName,
                Address = _addCustomer.CustomerAddress,
                ContactNumber = _addCustomer.ContactNumber
            };

            _customerBusinessInformation = new CustomerBusinessInformation
            {
                BusinessName = _addCustomer.BusinessName,
                BusinessNature = _addCustomer.BusinessNature,
                BusinessAddress = _addCustomer.BusinessAddress,
                GrossBusinessCapital = _addCustomer.GrossBusinessCapital,
                AverageDailyGrossSales = _addCustomer.AverageDailyGrossSales
            };

            _customerService = new CustomerService();

            if (_customerService.OnSetIsDuplicateName(_customer.Name) is false)
            {
                RecordEntry();
            }
            else
            {
                throw new ArgumentException(" Duplicate Name ", nameof(_customer.Name));
            }
        }
        private void RecordEntry()
        {
            _customerService = new CustomerService();
            _customerService.OnSetInsertData(_customer, _customerBusinessInformation);
        }
        public void OnLoadRetryAddEntry(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                RecordEntry();
            }
        }        
    }
}
