﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Repository;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemUtilityLibrary.Generator;
using MySql.Data.MySqlClient;
using System.Data;

namespace LoanInformationSystemMVPLibrary.Service
{
    public class CustomerService
    {
        #region Fields

        private CustomerRepo _customerRepo;

        #endregion

        public bool OnSetIsDuplicateName(string name)
        {
            _customerRepo = new CustomerRepo();

            try
            {
                return _customerRepo.IsDuplicateName(name);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public void OnSetInsertData(Customer customer, CustomerBusinessInformation customerBusinessInformation)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            customer.Uid = Guid.NewGuid();
            customer.Id = idGeneratorClass.NewId();
            customerBusinessInformation.Uid = Guid.NewGuid();
            customerBusinessInformation.Id = idGeneratorClass.NewId();
            _customerRepo = new CustomerRepo();

            #region Check All Credentials if Valid

            while (_customerRepo.IsDuplicateUid(customer.Uid))
            {
                customer.Uid = Guid.NewGuid();
            }
            while (_customerRepo.IsDuplicateId(customer.Id))
            {
                customer.Id = idGeneratorClass.NewId();
            }
            while (_customerRepo.IsDuplicateBusinessId(customerBusinessInformation.Id))
            {
                customerBusinessInformation.Id = idGeneratorClass.NewId();
            }
            while (_customerRepo.IsDuplicateBusinessGuid(customerBusinessInformation.Uid))
            {
                customerBusinessInformation.Uid = Guid.NewGuid();
            }

            #endregion

            try
            {
                _customerRepo.InsertData(customer, customerBusinessInformation);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public List<GetCustomerInfo> OnSetGetCustomerList(Customer customer)
        {
            _customerRepo = new CustomerRepo();

            try
            {
                return _customerRepo.GetList(customer);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        internal void OnSetUpdateCustomerData(Customer customer,CustomerBusinessInformation businessInformation)
        {
            _customerRepo = new CustomerRepo();

            try
            {
                _customerRepo.UpdateData(customer, businessInformation);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }        
    }
}
