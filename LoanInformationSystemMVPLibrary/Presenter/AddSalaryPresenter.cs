﻿using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Service;
using LoanInformationSystemMVPLibrary.View;

namespace LoanInformationSystemMVPLibrary.Presenter
{
    public class AddSalaryPresenter
    {
        private IAddAmountAndDate _amountAndDate;
        private SalaryServices _salaryServices;
        private SavingsServices _savingsServices;
        private CollectionService _collectionService;
        private Salary salary;

        public AddSalaryPresenter()
        {

        }
        public AddSalaryPresenter(IAddAmountAndDate addAmountAndDate)
        {
            _amountAndDate = addAmountAndDate;
        }        
        public bool OnLoadRemit()
        {            
            salary = new Salary();
            salary.SalaryAmount = _amountAndDate.Amount;
            salary.CollectionDate = _amountAndDate.Date;
            salary.DateRemmited = DateTime.Now.Date;

            if (IsDateValid(salary.CollectionDate))
            {
                _salaryServices = new SalaryServices();
                _salaryServices.OnSetAddSalary(salary);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsDateValid(DateTime date)
        {
            _salaryServices = new SalaryServices();
            return _salaryServices.OnSetCheckDateValidity(date);
        }
        public decimal OnLoadGetDailyTotalCollectionByDate(DateTime date)
        {
            _collectionService = new CollectionService();
            return _collectionService.OnSetGetDailyTotalCollectionByDate(date);
        }
        public decimal OnLoadGetTotalSalary(DateTime date)
        {
            _salaryServices = new SalaryServices();
            return _salaryServices.OnSetGetTotalSalary(date);
        }
        public decimal OnLoadGetTotalSavings(DateTime date)
        {
            _savingsServices = new SavingsServices();
            return _savingsServices.OnSetGetTotalSavings(date);
        }
    }
}
