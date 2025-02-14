﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Repository;
using LoanInformationSystemUtilityLibrary.Generator;

namespace LoanInformationSystemMVPLibrary.Service
{
    internal class CollectionService
    {
        private CollectionRepo _collectionRepo;
        private LoanInformationRepo _loanInformationRepo;
        private GetCustomerLoanInformation _customerLoanInfo = new GetCustomerLoanInformation();        
        private CustomerRepo _customerRepo;

        public void OnSetInsertCollection(Collection collection, Customer customer, Loan loan) 
        {         
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();            
            _customerRepo = new CustomerRepo();

            collection.Uid = Guid.NewGuid();
            collection.Id = idGeneratorClass.NewId();            
            _collectionRepo = new CollectionRepo();
            _loanInformationRepo = new LoanInformationRepo();

            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            customer.Id = _customerLoanInfo.CustomerID;
            string guid = _customerRepo.GetGuid(customer);
            customer.Uid = Guid.Parse(guid);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            while (_collectionRepo.IsDuplicateUid(collection.Uid))
            {
                collection.Uid = Guid.NewGuid();
            }
            while (_collectionRepo.IsDuplicateId(collection.Id))
            {
                collection.Id = idGeneratorClass.NewId();
            }

            try
            {
                _collectionRepo.InsertCollection(collection,customer,loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public void OnSetInsertPenalty(Penalty penalty, Customer customer, Loan loan)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            _customerRepo = new CustomerRepo();

            penalty.Uid = Guid.NewGuid();
            penalty.Id = idGeneratorClass.NewId();
            _collectionRepo = new CollectionRepo();
            _loanInformationRepo = new LoanInformationRepo();

            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            customer.Id = _customerLoanInfo.CustomerID;
            string guid = _customerRepo.GetGuid(customer);
            customer.Uid = Guid.Parse(guid);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            while (_collectionRepo.IsDuplicateUid(penalty.Uid))
            {
                penalty.Uid = Guid.NewGuid();
            }
            while (_collectionRepo.IsDuplicateId(penalty.Id))
            {
                penalty.Id = idGeneratorClass.NewId();
            }

            try
            {
                _collectionRepo.InsertPenalty(penalty, customer, loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public void OnSetLoanStatusUpdate(Loan loan)
        {
            try
            {
                _collectionRepo = new CollectionRepo();
                _collectionRepo.LoanFullyPaidUpdate(loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        public bool OnSetCheckDateValidity(DateTime date)
        {
            _collectionRepo = new CollectionRepo();
            return _collectionRepo.CheckDateValidity(date);
        }
        public decimal OnSetGetDailyTotalCollectionByDate(DateTime date)
        {
            _collectionRepo = new CollectionRepo();
            return _collectionRepo.GetDailyTotalCollectionByDate(date);
        }
        public decimal OnSetGetTotalCollection(Loan loan)
        {
            _loanInformationRepo = new LoanInformationRepo();
            _collectionRepo = new CollectionRepo();
            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            return _collectionRepo.GetTotalCollection(loan);
        }        
        public decimal OnSetGetTotalPenalty(Loan loan)
        {
            _loanInformationRepo = new LoanInformationRepo();
            _collectionRepo = new CollectionRepo();
            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            return _collectionRepo.GetTotalPenalty(loan);
        }
        public decimal OnSetGetTotalCollectionForLoanInformationForm(Loan loan)
        {
            _loanInformationRepo = new LoanInformationRepo();
            _collectionRepo = new CollectionRepo();
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));
            return _collectionRepo.GetTotalCollection(loan);
        }
        public decimal OnSetGetTotalPenaltyForLoanInformationForm(Loan loan)
        {
            _loanInformationRepo = new LoanInformationRepo();
            _collectionRepo = new CollectionRepo();            
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));
            return _collectionRepo.GetTotalPenalty(loan);
        }
    }
}
