using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class Mold 
    {
        public string ID {  get; set; }
        public string MoldNumber { get; set; }
        public string Material { get; set; }
        public string Material_name { get; set; }
        public string DieNumber { get; set; }
        public string Customer { get; set; }
        public DateTime LastUsedDate { get; set; }
        public string Location { get; set; }
        public string DateCreated { get; set; }
        public string TimeCreated { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
    }
    public class Logs
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Section { get; set; }
        public string UserId { get; set; }
    }
    public class TransactionData
    {
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string MoldNumber { get; set; }
        public string DieNumber { get; set; }
        public string Customer { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public string ShotCount { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Section { get; set; }
        public string UserId { get; set; }
    }
    public class TransactionUtility
    {
        private readonly DbConnection connection;

        public TransactionUtility()
        {
            connection = new DbConnection();
        }
        public List<Mold> GetIdleMold()
        {
            List<Mold> IdleMold = new List<Mold>();

            string query = "WITH LatestTransaction AS (SELECT moldnumber, MAX(CONCAT(date, ' ', time)) AS LatestTimestamp FROM History " +
                                   "GROUP BY moldnumber) " +
                                   "SELECT h.partnumber, h.moldnumber, h.date, h.status, h.location " +
                                   "FROM history h JOIN LatestTransaction lt ON h.moldnumber = lt.moldnumber AND CONCAT(h.date, ' ', h.time) = lt.LatestTimestamp " +
                                   "WHERE DATEDIFF(DAY, lt.LatestTimestamp, GETDATE()) > 90 " +
                                   "ORDER BY h.date ASC, h.time ASC";


            using (SqlConnection conn = connection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mold moldData = new Mold
                        {
                            Material = reader["partnumber"].ToString(),
                            MoldNumber = reader["moldnumber"].ToString(),
                            DateCreated = GetTenure(reader["date"].ToString(), out DateTime lastUsedDate),
                            LastUsedDate = lastUsedDate,
                            Status = reader["status"].ToString(),
                            Location = reader["location"].ToString()
                        };

                        IdleMold.Add(moldData);
                    }
                }
            }
            return (IdleMold);
        }
        private string GetTenure(string dateCreated, out DateTime lastUsedDate)
        {
            if (DateTime.TryParse(dateCreated, out lastUsedDate))
            {
                DateTime currentDate = DateTime.Now;

                TimeSpan timeDifference = currentDate - lastUsedDate;

                int months = (currentDate.Year - lastUsedDate.Year) * 12 + currentDate.Month - lastUsedDate.Month;
                int days = timeDifference.Days - (months * 30);
                return $"{months} months {days} days";
            }
            else
            {
                lastUsedDate = DateTime.MinValue;
                return "Invalid Date";
            }
        }
        public bool RecordTransaction(TransactionData transactionData)
        {
            bool IsRecorded = false;
            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query = "insert into History (partnumber, moldnumber, dienumber, customer, status, remarks, shot_count, date, in_charge, time, location, section)" +
                        "values (@partnumber, @moldnumber, @dienumber, @customer, @status, @remarks, @shot_count, @date, @in_charge, @time, @location, @section)";
                    
                    using(SqlCommand cmd = new SqlCommand(Query,conn))
                    {
                        cmd.Parameters.AddWithValue("@partnumber", transactionData.PartNumber);
                        cmd.Parameters.AddWithValue("@moldnumber", transactionData.MoldNumber);
                        cmd.Parameters.AddWithValue("@dienumber", transactionData.DieNumber);
                        cmd.Parameters.AddWithValue("@customer", transactionData.Customer);
                        cmd.Parameters.AddWithValue("@status", transactionData.Status);
                        cmd.Parameters.AddWithValue("@remarks", transactionData.Remarks);
                        cmd.Parameters.AddWithValue("@shot_count", transactionData.ShotCount);
                        cmd.Parameters.AddWithValue("@date", transactionData.Date);
                        cmd.Parameters.AddWithValue("@in_charge", transactionData.UserId);
                        cmd.Parameters.AddWithValue("@time", transactionData.Time);
                        cmd.Parameters.AddWithValue("@location", transactionData.Location);
                        cmd.Parameters.AddWithValue("@section", transactionData.Section);

                        conn.Open();
                        int Result = cmd.ExecuteNonQuery();
                        IsRecorded = Result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return IsRecorded;
        }
        public bool RecordMoldTransaction(TransactionData transactionData)
        {
            bool IsRecorded = false;
            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query = "insert into History (partnumber, moldnumber, dienumber, customer, status, remarks, date, in_charge, time, location, section)" +
                        "values (@partnumber, @moldnumber, @dienumber, @customer, @status, @remarks, @date, @in_charge, @time, @location, @section)";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partnumber", transactionData.PartNumber);
                        cmd.Parameters.AddWithValue("@moldnumber", transactionData.MoldNumber);
                        cmd.Parameters.AddWithValue("@dienumber", transactionData.DieNumber);
                        cmd.Parameters.AddWithValue("@customer", transactionData.Customer);
                        cmd.Parameters.AddWithValue("@status", transactionData.Status);
                        cmd.Parameters.AddWithValue("@remarks", transactionData.Remarks);
                        cmd.Parameters.AddWithValue("@date", transactionData.Date);
                        cmd.Parameters.AddWithValue("@in_charge", transactionData.UserId);
                        cmd.Parameters.AddWithValue("@time", transactionData.Time);
                        cmd.Parameters.AddWithValue("@location", transactionData.Location);
                        cmd.Parameters.AddWithValue("@section", transactionData.Section);

                        conn.Open();
                        int Result = cmd.ExecuteNonQuery();
                        IsRecorded = Result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return IsRecorded;
        }
        public List<Mold> GetMoldData(int pageNumber, int pageSize)
        {
            List<Mold> moldDatas = new List<Mold>();
            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    string Query = "SELECT id, Mold_no, Material, Material_Name, Customer, Die_no, Date_created " +
                                    "FROM MoldMaster ORDER BY id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        int offset = (pageNumber - 1) * pageSize;

                        cmd.Parameters.AddWithValue("@Offset", offset);
                        cmd.Parameters.AddWithValue("@PageSize", pageSize);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Mold moldData = new Mold
                                {
                                    ID = reader["id"].ToString(),
                                    MoldNumber = reader["Mold_no"].ToString(),
                                    Material = reader["Material"].ToString(),
                                    Material_name = reader["Material_Name"].ToString(),
                                    Customer = reader["Customer"].ToString(),
                                    DieNumber = reader["Die_no"].ToString(),
                                    DateCreated = reader["Date_created"].ToString()
                                };
                                moldDatas.Add(moldData);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return moldDatas;
        }
        public List<TransactionData> GetInjectionTransactionLogs(string section)
        {
            List<TransactionData> transactions = new List<TransactionData>();
            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    DateTime dateTime = DateTime.Today;
                   
                    string Query = "select partnumber, dienumber, customer, status, location, remarks, shot_count, date, time, in_charge from History " +
                        "where CAST(date AS Date) = @Today and section = @section order by date ASC";
                    
                    using(SqlCommand cmd = new SqlCommand(Query,conn))
                    {
                        cmd.Parameters.AddWithValue("@Today",dateTime);
                        cmd.Parameters.AddWithValue("@section", section);

                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionData transactionData = new TransactionData
                                {
                                   PartNumber = reader["partnumber"]?.ToString() ?? string.Empty,
                                   DieNumber = reader["dienumber"]?.ToString() ?? string.Empty,
                                   Customer = reader["customer"]?.ToString() ?? string.Empty,
                                   Location = reader["location"]?.ToString() ?? string.Empty,
                                   Remarks = reader["remarks"]?.ToString() ?? string.Empty,
                                   Status = reader["status"]?.ToString() ?? string.Empty,
                                   ShotCount = reader["shot_count"]?.ToString() ?? string.Empty,
                                   Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue,
                                   Time = reader["time"]?.ToString() ?? string.Empty,
                                   UserId = reader["in_charge"]?.ToString()
                                };
                                transactions.Add(transactionData);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return transactions;
        }
        public List<TransactionData> GetTransactionLogs(string section, DateTime StartDate, DateTime EndDate)
        {
            List<TransactionData> transactions = new List<TransactionData>();

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                
                    string Query = "select moldnumber, partnumber, dienumber, customer, status, location, remarks, shot_count, date, time, in_charge from History " +
                        "where CAST(date AS Date) between @StartDate and @EndDate and section = @section order by date ASC";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                        cmd.Parameters.AddWithValue("@section", section);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionData transactionData = new TransactionData
                                {
                                    MoldNumber = reader["moldnumber"]?.ToString() ?? string.Empty,
                                    PartNumber = reader["partnumber"]?.ToString() ?? string.Empty,
                                    DieNumber = reader["dienumber"]?.ToString() ?? string.Empty,
                                    Customer = reader["customer"]?.ToString() ?? string.Empty,
                                    Location = reader["location"]?.ToString() ?? string.Empty,
                                    Remarks = reader["remarks"]?.ToString() ?? string.Empty,
                                    Status = reader["status"]?.ToString() ?? string.Empty,
                                    ShotCount = reader["shot_count"]?.ToString() ?? string.Empty,
                                    Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue,
                                    Time = reader["time"]?.ToString() ?? string.Empty,
                                    UserId = reader["in_charge"]?.ToString()
                                };
                                transactions.Add(transactionData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return transactions;
        }
        public List<TransactionData> GetAllTransactionLogs(DateTime StartDate, DateTime EndDate, int pageNumber, int pageSize)
        {
            List<TransactionData> transactions = new List<TransactionData>();
            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {

                    string Query = "select id, moldnumber, partnumber, dienumber, customer, status, location, remarks, shot_count, date, time from History " +
                        "where CAST(date AS Date) between @StartDate and @EndDate order by date ASC, time ASC OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        int offset = (pageNumber - 1) * pageSize;

                        cmd.Parameters.AddWithValue("@Offset", offset);
                        cmd.Parameters.AddWithValue("@PageSize", pageSize);
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                     
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionData transactionData = new TransactionData
                                {
                                    Id = reader["id"]?.ToString() ?? string.Empty,
                                    MoldNumber = reader["moldnumber"]?.ToString() ?? string.Empty,
                                    PartNumber = reader["partnumber"]?.ToString() ?? string.Empty,
                                    DieNumber = reader["dienumber"]?.ToString() ?? string.Empty,
                                    Customer = reader["customer"]?.ToString() ?? string.Empty,
                                    Location = reader["location"]?.ToString() ?? string.Empty,
                                    Remarks = reader["remarks"]?.ToString() ?? string.Empty,
                                    Status = reader["status"]?.ToString() ?? string.Empty,
                                    ShotCount = reader["shot_count"]?.ToString() ?? string.Empty,
                                    Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue,
                                    Time = reader["time"]?.ToString() ?? string.Empty,
                                };
                                transactions.Add(transactionData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return transactions;
        }
        public List<TransactionData> GetLatestTransactionLogs(string customer)
        {
            List<TransactionData> transactions = new List<TransactionData>();

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query;

                    if (customer == "ALL CUSTOMER")
                    {
                        Query = @"WITH LatestTransaction AS (
                            SELECT moldnumber, MAX(CONCAT(date, ' ', time)) AS LatestTimestamp 
                            FROM History 
                            GROUP BY moldnumber
                          )
                          SELECT h.date, h.partnumber, h.moldnumber, h.dienumber, h.status, h.location, 
                                 h.remarks, h.in_charge, h.time, h.customer, h.shot_count
                          FROM History h
                          JOIN LatestTransaction lt 
                          ON h.moldnumber = lt.moldnumber 
                          AND CONCAT(h.date, ' ', h.time) = lt.LatestTimestamp
                          ORDER BY h.date DESC, h.time DESC";
                    }
                    else
                    {
                        Query = @"WITH LatestTransaction AS (
                            SELECT moldnumber, MAX(CONCAT(date, ' ', time)) AS LatestTimestamp 
                            FROM History 
                            WHERE customer = @customer 
                            GROUP BY moldnumber
                          )
                          SELECT h.date, h.partnumber, h.moldnumber, h.dienumber, h.status, h.location, 
                                 h.remarks, h.in_charge, h.time, h.customer, h.shot_count
                          FROM History h
                          JOIN LatestTransaction lt 
                          ON h.moldnumber = lt.moldnumber 
                          AND CONCAT(h.date, ' ', h.time) = lt.LatestTimestamp
                          WHERE h.customer = @customer
                          ORDER BY h.date DESC, h.time DESC";
                    }
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        if (customer != "ALL CUSTOMER")
                        {
                            cmd.Parameters.AddWithValue("@customer", customer);
                        }

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionData transactionData = new TransactionData
                                {
                                  MoldNumber = reader["moldnumber"]?.ToString() ?? string.Empty,
                                  PartNumber = reader["partnumber"]?.ToString() ?? string.Empty,
                                  DieNumber = reader["dienumber"]?.ToString() ?? string.Empty,
                                  Customer = reader["customer"]?.ToString() ?? string.Empty,
                                  Location = reader["location"]?.ToString() ?? string.Empty,
                                  Remarks = reader["remarks"]?.ToString() ?? string.Empty,
                                  Status = reader["status"]?.ToString() ?? string.Empty,
                                  ShotCount = reader["shot_count"]?.ToString() ?? string.Empty,
                                  Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue,
                                  Time = reader["time"]?.ToString() ?? string.Empty,
                                };
                                transactions.Add(transactionData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return transactions;
        }
        public bool Printlogs(string section, string content, string employeename)
        {
            DateTime dateTime = DateTime.Now.Date;
            TimeSpan currentTime =  DateTime.Now.TimeOfDay;
            bool result = false;
            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    string Query = "Insert into PrintLog (PrintContent, Section, UserId, Date, Time) values (@PrintContent, @Section, @Userid, @Date, @Time)";
                    using(SqlCommand cmd = new SqlCommand(Query,conn))
                    {
                        cmd.Parameters.AddWithValue("@PrintContent", content);
                        cmd.Parameters.AddWithValue("@Section", section);
                        cmd.Parameters.AddWithValue("@Userid", employeename);
                        cmd.Parameters.AddWithValue("@Date", dateTime);
                        cmd.Parameters.AddWithValue("@Time", currentTime.ToString(@"hh\:mm\:ss"));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        result = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return result;
        }
        public List<Logs> GetLogs(string section)
        {
            List<Logs> logs = new List<Logs>();
            DateTime dateTime = DateTime.Now.Date;
            try
            {
                using( SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    string Query = "select PrintContent, Date, Time, Section, UserId from PrintLog where Section = @section and Date = @date";

                    using (SqlCommand cmd = new SqlCommand(Query,conn))
                    {
                        cmd.Parameters.AddWithValue("@date", dateTime);
                        cmd.Parameters.AddWithValue("@section", section);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Logs transaction = new Logs
                                {
                                    Content = reader["PrintContent"].ToString(),
                                    Section = reader["Section"].ToString(),
                                    UserId = reader["UserId"].ToString(),
                                    Date = reader["Date"] != DBNull.Value ? Convert.ToDateTime(reader["Date"]) : DateTime.MinValue,
                                    Time = reader["Time"].ToString()
                                };

                                logs.Add(transaction);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return logs;
        }
        public bool AddNewMold(Mold mold)
        {
            bool IsRecorded = false;
            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    string Query = "insert into MoldMaster (Mold_no, Material, Material_Name, Customer, Die_no, Date_created, Time_created) " +
                                   "values (@Mold_no, @Material, @Material_Name, @Customer, @Die_no, @Date_created, @Time_created)";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mold_no", mold.MoldNumber);
                        cmd.Parameters.AddWithValue("@Material", mold.Material);
                        cmd.Parameters.AddWithValue("@Material_Name", mold.Material_name);
                        cmd.Parameters.AddWithValue("@Customer", mold.Customer);
                        cmd.Parameters.AddWithValue("@Die_no", mold.DieNumber);
                        cmd.Parameters.AddWithValue("@Date_created", mold.DateCreated);
                        cmd.Parameters.AddWithValue("@Time_created", mold.TimeCreated);
                        //cmd.Parameters.AddWithValue("@Username", mold.UserName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        IsRecorded = rowsAffected > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return IsRecorded;
        }
        public bool UpdateMoldData(Mold mold)
        {
            bool IsRecorded = false;
           
                string Query = "Update MoldMaster set Mold_no = @Mold_no, Material = @Material, Material_Name = @Material_Name, " +
                                "Customer = @Customer, Die_no = @Die_no, Date_created = @Date_created, Time_created = @Time_created where id = @id";
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using(SqlTransaction transact = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(Query, conn, transact))
                            {
                                cmd.Parameters.AddWithValue("@id", mold.ID);
                                cmd.Parameters.AddWithValue("@Mold_no", mold.MoldNumber);
                                cmd.Parameters.AddWithValue("@Material", mold.Material);
                                cmd.Parameters.AddWithValue("@Material_Name", mold.Material_name);
                                cmd.Parameters.AddWithValue("@Customer", mold.Customer);
                                cmd.Parameters.AddWithValue("@Die_no", mold.DieNumber);
                                cmd.Parameters.AddWithValue("@Date_created", mold.DateCreated);
                                cmd.Parameters.AddWithValue("@Time_created", mold.TimeCreated);

                                int RowsAffected = cmd.ExecuteNonQuery();
                                IsRecorded = RowsAffected > 0;
                            }
                            transact.Commit();
                        }
                       catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            transact.Rollback();
                        }
                    }
                }
            return IsRecorded;
        }
        public bool DeleteMoldData(string id)
        {
            bool isDeleted = false;
            try
            {
                string Query = "Delete from MoldMaster where id = @id";
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int RowsAffected = cmd.ExecuteNonQuery();
                        isDeleted = RowsAffected > 0;
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isDeleted;
        }
        public bool EditTransanction(TransactionData transactionData)
        {
            bool isEdited = false;
            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    string Query = "Update History set partnumber = @partnumber, moldnumber = @moldnumber, dienumber = @dienumber, status = @status, customer = @customer, " +
                                    "remarks = @remarks, shot_count = @shotcount, location = @location where id = @id";

                    using(SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                          using (SqlCommand cmd = new SqlCommand(Query, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id", transactionData.Id);
                                cmd.Parameters.AddWithValue("@partnumber", transactionData.PartNumber);
                                cmd.Parameters.AddWithValue("@moldnumber", transactionData.MoldNumber);
                                cmd.Parameters.AddWithValue("@dienumber", transactionData.DieNumber);
                                cmd.Parameters.AddWithValue("@status", transactionData.Status);
                                cmd.Parameters.AddWithValue("@customer", transactionData.Customer);
                                cmd.Parameters.AddWithValue("@location", transactionData.Location);
                                cmd.Parameters.AddWithValue("@remarks", transactionData.Remarks);
                                cmd.Parameters.AddWithValue("@shotcount", transactionData.ShotCount ?? string.Empty);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                isEdited = rowsAffected > 0;
                            }
                            tran.Commit();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            tran.Rollback();
                        }
                    } 
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isEdited;
        }
        public bool DeleteTransactionData(string id)
        {
            bool isDeleted = false;
            try
            {
                string Query = "Delete from History where id = @id";
                using (SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int RowsAffected = cmd.ExecuteNonQuery();
                        isDeleted = RowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isDeleted;
        }
    }
}
