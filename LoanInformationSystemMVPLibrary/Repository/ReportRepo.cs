﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.ReportDataSets;
using LoanInformationSystemUtilityLibrary.DataSource;

namespace LoanInformationSystemMVPLibrary.Repository
{
    internal class ReportRepo
    {        
        internal DataSet GetCollectionSummaryReportUnpaid()
        {            
            
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getTotalCollectionPerLoanSummaryUnPaid";
                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CrystalReportDataSet data = new CrystalReportDataSet();
                adapt.Fill(data, "CollectionSummaryReport");
                return data;
            }            
        }
        internal DataSet GetCollectionSummaryReportPaid()
        {

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getTotalCollectionPerLoanSummaryPaid";
                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CrystalReportDataSet data = new CrystalReportDataSet();
                adapt.Fill(data, "CollectionSummaryReport_Paid");
                return data;
            }
        }
        internal DataSet GetLoanInformationReport(Loan loan)
        {            
            LoanInformationReport _loanInformation = null;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_createLoanInformationReport";                

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loan_id", loan.Id);
                cmd.Parameters["@loan_id"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {                    
                    while (reader.Read())
                    {
                        _loanInformation = new LoanInformationReport()
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            NameOfOwner = reader["CustomerName"].ToString(),
                            PrincipalLoan = Convert.ToDecimal(reader["PrincipalLoan"]),
                            Interest = Convert.ToDecimal(reader["Interest"]),                            
                            Terms = reader["PaymentTerm"].ToString(),
                            TotalLoan = Convert.ToDecimal(reader["TotalLoan"]),
                            DailyPayment = Convert.ToDecimal(reader["DailyPayment"]),
                        };                        
                    }
                }
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CrystalReportDataSet data = new CrystalReportDataSet();
                adapt.Fill(data, "LoanInformationReport");
                return data;
            }            
        }
        internal DataSet GetCollectionReport(Loan loan)
        {            
            CollectionReport _collectionReport = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getCollection";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanId", loan.Id);
                cmd.Parameters["@loanId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            _collectionReport = new CollectionReport()
                            {
                                ID = reader["ID"].ToString(),                                
                                Date = Convert.ToDateTime(reader["Date"]),
                                Remmit = Convert.ToDecimal(reader["Remmit"])
                            };
                        }                        
                    }
                }
                if (_collectionReport != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "CollectionDetailReport");
                    return data;
                }                                
                return data;
            }
        }
        internal DataSet GetPenaltyReport(Loan loan)
        {            
            PenaltyReport _penaltyReport = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getPenalty";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanId", loan.Id);
                cmd.Parameters["@loanId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            _penaltyReport = new PenaltyReport()
                            {
                                ID = reader["ID"].ToString(),                                
                                Date = Convert.ToDateTime(reader["Date"]),
                                Penalty = Convert.ToDecimal(reader["Penalty"])
                            };
                        }
                    }
                }
                if (_penaltyReport != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "PenaltyDetailReport");
                    return data;
                }
                return data;
            }
        }
        internal DataSet GetDailyCollection(DateTime dateFrom, DateTime dateTo)
        {
            AllCollectionReport _allCollected = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getDailyCollection";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@collectionDate_from", dateFrom);
                cmd.Parameters["@collectionDate_from"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collectionDate_to", dateTo);
                cmd.Parameters["@collectionDate_to"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            _allCollected = new AllCollectionReport()
                            {                                
                                Date = Convert.ToDateTime(reader["date"]),
                                Collection_Amount = Convert.ToDecimal(reader["CollectionAmount"]),
                                Salary_Amount = Convert.ToDecimal(reader["SalaryAmount"]),
                                Savings_Amount = Convert.ToDecimal(reader["SavingsAmount"])
                            };
                        }
                    }
                }
                if (_allCollected != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "DailyCollectionReport");
                    return data;
                }
                return data;
            }
        }
        internal DataSet GetSavingsSalaryExpensesSummary(DateTime dateFrom, DateTime dateTo)
        {
            Date date = null;
            Salary salary = null;
            Savings savings = null;
            Collection collection = null;

            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_GetSavingsSalaryExpensesSummary";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@dateMonthFrom", dateFrom);
                cmd.Parameters["@dateMonthFrom"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@dateMonthTo", dateTo);
                cmd.Parameters["@dateMonthTo"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            date = new Date()
                            {
                                Year = Convert.ToInt32(reader["year"]),
                                Month = Convert.ToInt32(reader["month"]),
                                Day = Convert.ToInt32(reader["day"]),
                                MonthName = reader["monthName"].ToString()
                            };
                            collection = new Collection()
                            {
                                Amount = Convert.ToDecimal(reader["TotalCollection"])
                            };
                            salary = new Salary()
                            {
                                SalaryAmount = Convert.ToDecimal(reader["TotalSalary"])
                            };
                            savings = new Savings()
                            {
                                SavingsAmount = Convert.ToDecimal(reader["TotalSavings"])
                            };
                        }
                    }
                }
                if (date != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "SavingsSalaryExpensesSummaryReport");
                    return data;
                }
                return data;
            }
        }
        internal DataSet GetSalary(DateTime date)
        {
            Salary salary = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getSalary";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            salary = new Salary()
                            {
                                CollectionDate = Convert.ToDateTime(reader["collection_date"]),
                                SalaryAmount = Convert.ToDecimal(reader["salary_amount"])
                            };
                        }
                    }
                }
                if (salary != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "SalaryReport");
                    return data;
                }
                return data;
            }
        }
        internal DataSet GetSavings(DateTime date)
        {
            Savings savings = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getSavings";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            savings = new Savings()
                            {
                                CollectionDate = Convert.ToDateTime(reader["collection_date"]),
                                SavingsAmount = Convert.ToDecimal(reader["savings_amount"])
                            };
                        }
                    }
                }
                if (savings != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "SavingsReport");
                    return data;
                }
                return data;
            }
        }
        internal decimal GetOverAllCollection()
        {
            decimal overAllCollectionAmount = 0;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getOverAllCollection";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            overAllCollectionAmount = Convert.ToDecimal(reader["OverAllCollection"]);
                        }
                    }
                }                
                return overAllCollectionAmount;
            }
        }
    }
}
