﻿using System;
using System.Data;
using System.Collections.Generic;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemUtilityLibrary.DataSource;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Configuration;
using LoanInformationSystemMVPLibrary.DataSets;

namespace LoanInformationSystemMVPLibrary.Repository
{
    internal class LoanInformationRepo
    {        
        internal DataSet GetLoanInformationUsingCustomerID(Customer customer)
        {

            GetCustomerLoanInformation getLoanInformation = null;            
            List<GetCustomerLoanInformation> loanList = new List<GetCustomerLoanInformation>();
            LoanInformationDataSet dataSet = new LoanInformationDataSet();

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getLoanInformationUsingCustomerId";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@customerId", customer.Id);
                cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;                
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        getLoanInformation = new GetCustomerLoanInformation
                        {
                            Id = reader["Loan ID"].ToString(),
                            CustomerID = reader["Customer ID"].ToString(),
                            Name = reader["Customer Name"].ToString(),
                            PaymentTerm = reader["Payment Term"].ToString(),
                            Duration = Convert.ToInt32(reader["Duration"].ToString()),
                            EffectiveDate = Convert.ToDateTime(reader["Effective Date"]).ToString("MM-dd-yyyy"),
                            Interest = Convert.ToDecimal(reader["Interest Rate"].ToString()),
                            PrincipalLoan = Convert.ToDecimal(reader["Principal Loan"].ToString()),                            
                            Status = reader["Status"].ToString()                            
                        };
                        //loanList.Add(getLoanInformation);                       
                    }
                }
                if (getLoanInformation != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(dataSet, "CustomerLoanInformation");
                    return dataSet;
                }
            }
            return dataSet;
        }
        internal DataSet GetLoanInformationUsingCustomerName(Customer customer)
        {
            GetCustomerLoanInformation getLoanInformation = null;
            List<GetCustomerLoanInformation> loanList = new List<GetCustomerLoanInformation>();
            LoanInformationDataSet dataSet = new LoanInformationDataSet();

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getLoanInformationUsingCustomerName";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();               
                cmd.Parameters.AddWithValue("@customerName", customer.Name);
                cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        getLoanInformation = new GetCustomerLoanInformation
                        {
                            Id = reader["Loan ID"].ToString(),
                            CustomerID = reader["Customer ID"].ToString(),
                            Name = reader["Customer Name"].ToString(),
                            PaymentTerm = reader["Payment Term"].ToString(),
                            Duration = Convert.ToInt32(reader["Duration"].ToString()),
                            EffectiveDate = Convert.ToDateTime(reader["Effective Date"]).ToString("MM-dd-yyyy"),
                            Interest = Convert.ToDecimal(reader["Interest Rate"].ToString()),
                            PrincipalLoan = Convert.ToDecimal(reader["Principal Loan"].ToString()),
                            Status = reader["Status"].ToString()                            
                        };
                        loanList.Add(getLoanInformation);
                    }
                }
                if (getLoanInformation != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(dataSet, "CustomerLoanInformation");
                    return dataSet;
                }
            }
            return dataSet;
        }
        internal GetCustomerLoanInformation GetLoanInformation(Loan loan)
        {
            GetCustomerLoanInformation getLoanInformation = null;            

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getLoanInformationUsingLoanId";

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
                        getLoanInformation = new GetCustomerLoanInformation
                        {
                            Id = reader["LoanID"].ToString(),
                            CustomerID = reader["CustomerID"].ToString(),
                            Name = reader["CustomerName"].ToString(),
                            PaymentTerm = reader["PaymentTerm"].ToString(),
                            Duration = Convert.ToInt32(reader["Duration"].ToString()),
                            EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]).ToString("MM-dd-yyyy"),
                            Interest = Convert.ToDecimal(reader["InterestRate"].ToString()),
                            PrincipalLoan = Convert.ToDecimal(reader["PrincipalLoan"].ToString()),
                            Status = reader["Status"].ToString(),
                            CollectedAmount = Convert.ToDecimal(reader["Amount"].ToString())
                        };                        
                    }
                }
            }

            return getLoanInformation;

        }
        public List<GetCollectionAndPenalty> GetCollectionAndPenalty(string LoanID)
        {

            string _getCollectionAndPenalty = LoanID;
            GetCollectionAndPenalty getCollectionAndPenalty;
            List<GetCollectionAndPenalty> collectionAndPenaltyList = new List<GetCollectionAndPenalty>();

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getCollectionAndPenalty";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@loanId", _getCollectionAndPenalty);
                cmd.Parameters["@loanId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            getCollectionAndPenalty = new GetCollectionAndPenalty
                            {
                                Date = Convert.ToDateTime(reader["Date"]),
                                Collection = reader["Collection"].ToString(),
                                Penalty = reader["Penalty"].ToString()
                            };
                            collectionAndPenaltyList.Add(getCollectionAndPenalty);
                        }
                        else
                            collectionAndPenaltyList.Clear();
                    }
                }
            }
            return collectionAndPenaltyList;
        }
        public void InsertLoanData(Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string customerInfoQuery = "sp_insertLoan";
                MySqlCommand cmd = new MySqlCommand(customerInfoQuery, con);

                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                #region Customer information parameters

                cmd.Parameters.AddWithValue("@loaninformationUid", loan.Uid);
                cmd.Parameters["@loaninformationUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@loaninformationId", loan.Id);
                cmd.Parameters["@loaninformationId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customerUid", loan.CustomerUid);
                cmd.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@paymentTerm", loan.PaymentTerm);
                cmd.Parameters["@paymentTerm"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@duration", loan.Duration);
                cmd.Parameters["@duration"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@effectiveDate", loan.EffectiveDate);
                cmd.Parameters["@effectiveDate"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@interest", loan.Interest);
                cmd.Parameters["@interest"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@principalLoan", loan.PrincipalLoan);
                cmd.Parameters["@principalLoan"].Direction = ParameterDirection.Input;                

                #endregion

                cmd.ExecuteNonQuery();
            }       
        }               
        public bool CheckLoanUnpaid(string customerId)
        {
            bool rslt = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
                {
                    const string customerInfoQuery = "sp_isLoanUnpaid";
                    MySqlCommand cmd = new MySqlCommand(customerInfoQuery, con);

                    con.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Customer information parameters
                    cmd.Parameters.AddWithValue("@ID", customerId);
                    cmd.Parameters["@ID"].Direction = ParameterDirection.Input;                    
                    cmd.Parameters.Add(new MySqlParameter("@rslt", MySqlDbType.UInt16));
                    cmd.Parameters["@rslt"].Direction = ParameterDirection.Output;                    
                    #endregion
                    cmd.ExecuteNonQuery();
                    
                    string cmdrslt = cmd.Parameters["@rslt"].Value.ToString();
                    if (!string.IsNullOrEmpty(cmdrslt)) // Do not remove this code                                                        
                    {
                        rslt = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return rslt;
        }
        internal string GetGuid(Loan loan)
        {
            string guid = null;

            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getLoanGuid";

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
                        guid = reader["uid"].ToString();
                    }
                }
            }

            return guid;

        }
        internal decimal GetReleasedAmount(Loan loan)
        {
            decimal releasedAmount = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getReleasedAmount";

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
                        releasedAmount = Convert.ToDecimal(reader["Release CollectedAmount"]);
                    }
                }
            }
            return releasedAmount;
        }
    }
}
