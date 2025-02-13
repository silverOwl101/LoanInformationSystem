using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Repository;
using LoanInformationSystemUtilityLibrary.Generator;

namespace LoanInformationSystemMVPLibrary.Service
{
    internal class SavingsServices
    {
        SavingsRepo _savingsRepo;
        public void OnSetAddSavings(Savings savings)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            SavingsRepo _savingsRepo = new SavingsRepo();

            savings.Uid = Guid.NewGuid();
            savings.Id = idGeneratorClass.NewId();
                        
            while (_savingsRepo.IsDuplicateUid(savings.Uid))
            {
                savings.Uid = Guid.NewGuid();
            }
            while (_savingsRepo.IsDuplicateId(savings.Id))
            {
                savings.Id = idGeneratorClass.NewId();
            }

            try
            {
                _savingsRepo.InsertSavings(savings);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public decimal OnSetGetTotalSavings(DateTime date)
        {
            _savingsRepo = new SavingsRepo();
            return _savingsRepo.GetTotalSavingsInDate(date);
        }
    }
}
