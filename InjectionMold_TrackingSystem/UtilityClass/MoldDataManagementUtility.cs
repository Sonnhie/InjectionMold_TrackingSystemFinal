using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class MoldData
    {
        public string MoldNumber { get; set; }
        public string Dienumber { get; set; }
        public string Customer { get; set; }
        public string MachineNumber { get; set; }
    }
    public class MachineData
    {
        public string machineData { get; set; }
        public string MachineName { get; set; }
    }

    public class ShotCountData
    {
        public int shotCount { get; set; }
        public string partnumber { get; set; }
        public string dienumber { get; set; }
        public string customer { get; set; }
        public string machine { get; set; }
        public DateTime prod_date { get; set; }
        public DateTime uploaded_at { get; set; } 
    }
    public class MoldDataManagementUtility
    {
        private readonly DbConnection connection;
        public MoldDataManagementUtility()
        {
            connection = new DbConnection();
        }
        public bool GetMoldsWitkDuplicate(string mold)
        {
            List<string> molds = new List<string>();
            bool HasDuplicate = false;

            try
            {
                using(SqlConnection conn = connection.GetConnection())
                {
                    string Query = "select count(DISTINCT Material) as partcount From MoldMaster where Mold_no = @mold";

                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mold", mold);

                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                           if (reader.Read())
                            {
                                int partcount = Convert.ToInt32(reader["partcount"]);
                                HasDuplicate = partcount > 1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return HasDuplicate;
        }
        public List<string> GetMoldsWithDuplicate(string mold)
        {
            List<string> molds = new List<string>();

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query = "SELECT TOP 5 Material, Mold_no, Die_no, Material_Name, Customer FROM MoldMaster WHERE Mold_no = @MoldNumber";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MoldNumber", mold);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string partnumber = $"Part number: {reader["Material"].ToString()}";
                                molds.Add(partnumber);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return molds;
        }
        public List<string> GetSuggestionofPartnumber()
        {
            List<string> result = new List<string>();

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query = "SELECT DISTINCT Material FROM MoldMaster";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader["Material"].ToString());
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return result;
        }
        public List<string> GetSuggestionofMachinenumber()
        {
            List<string> result = new List<string>();

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    string Query = "SELECT DISTINCT Equipment FROM EquipmentMasterlist";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader["Equipment"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return result;
        }
        public MoldData ProvideData(string partnumber, string die_no)
        {
            string query = "SELECT Customer, Mold_no FROM MoldMaster WHERE Material = @partNumber and Die_no = @die_no";

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@partNumber", partnumber);
                        command.Parameters.AddWithValue("@die_no", die_no);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                return new MoldData
                                {
                                    MoldNumber = reader["Mold_no"].ToString(),
                                    //DieNumber = reader["Die_no"].ToString(),
                                    Customer = reader["Customer"].ToString()
                                };

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception as needed and handle it gracefully
                Console.WriteLine("Error retrieving mold data: " + ex.Message);
            }
            return null;
        }
        public MachineData ProvideDataMachine(string machinenumber)
        {
            string query = "SELECT Equipment_name FROM EquipmentMasterlist WHERE Equipment = @equipment";

            try
            {
                using (SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@equipment", machinenumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                return new MachineData
                                {
                                    MachineName = reader["Equipment_name"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception as needed and handle it gracefully
                Console.WriteLine("Error retrieving mold data: " + ex.Message);
            }
            return null;
        }
        public void MoldLocationComboxBox(ComboBox comboBox)
        {
            try
            {
                string Query = "select distinct LocationCode from MoldLocation";
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);

                            comboBox.DataSource = table;
                            comboBox.DisplayMember = "LocationCode";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public List<MoldLocation> GetLocationList()
        {
            List<MoldLocation> list = new List<MoldLocation>();
            try
            {
                string Query = "select Id, LocationCode, LocationDescription from MoldLocation";
                using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        using(SqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                MoldLocation moldLocation = new MoldLocation
                                {
                                    ID = r["Id"].ToString() ?? string.Empty,
                                    LocationCode = r["LocationCode"].ToString() ?? string.Empty,
                                    LocationDescription = r["LocationDescription"].ToString() ?? string.Empty,
                                };
                                list.Add(moldLocation);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return list;
        }
        public bool IsDuplicateLocation(MoldLocation location)
        {
            bool isDuplicate = false;
            try
            {
                string Query = "select count(*) from MoldLocation where LocationCode COLLATE Latin1_General_BIN = @locationCode " +
                               "and LocationDescription COLLATE Latin1_General_BIN = @description";
               using(SqlConnection conn = connection.GetConnection())
                {
                    conn.Open();
                    using( SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@locationCode", location.LocationCode);
                        cmd.Parameters.AddWithValue("@description", location.LocationDescription);
                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        isDuplicate = result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return isDuplicate;
        }
        public bool AddNewLocation(MoldLocation location)
        {
            bool isRecord = false;
            try
            {
                string Query = "insert into MoldLocation (LocationCode, LocationDescription) values (@LocationCode, @LocationDescription)";
                using(SqlConnection con = connection.GetConnection())
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(Query, con))
                    {
                      cmd.Parameters.AddWithValue("@LocationCode", location.LocationCode);
                      cmd.Parameters.AddWithValue("@LocationDescription", location.LocationDescription);
                      int result = cmd.ExecuteNonQuery();
                      isRecord = result > 0;
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isRecord;
        }
        public bool DeleteLocation(string ID)
        {
            bool isRecord = false;
            try
            {
                string Query = "Delete from MoldLocation where Id = @id";
                using(SqlConnection con = connection.GetConnection())
                {
                    con.Open();
                    using(SqlCommand  command = new SqlCommand(Query, con))
                    {
                        command.Parameters.AddWithValue("@Id", ID);
                        int result = command.ExecuteNonQuery();
                        isRecord = result > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isRecord;
        }

        public bool UpdateLocation(string ID, string code, string description)
        {
            bool isRecord = false;
            try
            {
                string query = "update MoldLocation set LocationCode = @code , LocationDescription = @description where Id = @Id";
                using (SqlConnection con = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query,con))
                    {
                        con.Open();
                        command.Parameters.AddWithValue("@Id", ID);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@description", description);
                        int result = command.ExecuteNonQuery();
                        isRecord = result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return isRecord;
        }

        public (bool isRecord, List<string> duplicates) SaveUploadedDatatoDatabase(DataTable data, Action<int> reportProgress)
        {
            List<string> duplicateMessage = new List<string>();
            bool isRecord = false;

            if (data == null || data.Rows.Count == 0)
            {
                throw new ArgumentException("No data provided.");
            }

            DateTime date = DateTime.Now;

            try
            {
                int totalRows = data.Rows.Count;
                int currentRow = 0;

                foreach (DataRow row in data.Rows)
                {



                    string query = "INSERT INTO ShotCount_Table (partnumber, customer, dienumber, shot_count, prod_date, uploaded_at) " +
                                   "VALUES (@partnumber, @customer, @dienumber, @shot_count, @prod_date, @uploaded_at)";
                    string checkQuery = "select count(*) from ShotCount_Table where partnumber = @partnumber and dienumber = @dienumber and prod_date = @prod_date";

                    string partNumber = row[1].ToString();
                    string customer = row[2].ToString();
                    string dieNumber = row[3].ToString();
                    DateTime prodDate = Convert.ToDateTime(row[0]);

                    using (SqlConnection con = connection.GetConnection())
                    {
                        con.Open();
                        using (SqlCommand chkcmd = new SqlCommand(checkQuery, con))
                        {
                            chkcmd.Parameters.AddWithValue("@partnumber", partNumber);
                            chkcmd.Parameters.AddWithValue("@dienumber", dieNumber);
                            chkcmd.Parameters.AddWithValue("@prod_date", prodDate);

                            int exist = (int)chkcmd.ExecuteScalar();
                            if (exist > 0)
                            {
                                duplicateMessage.Add($"Duplicate Entry: {partNumber} | {dieNumber} | {prodDate}");
                                continue;
                            }
                        }


                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@partnumber", row[1].ToString());
                            command.Parameters.AddWithValue("@customer", row[2].ToString());
                            command.Parameters.AddWithValue("@dienumber", row[3].ToString());
                            command.Parameters.AddWithValue("@shot_count", row[4]);
                            command.Parameters.AddWithValue("@prod_date", row[0]);
                            command.Parameters.AddWithValue("@uploaded_at", date);

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                                isRecord = true;
                        }
                    }

                    // ✅ Update progress
                    currentRow++;
                    int progress = (int)((currentRow / (double)totalRows) * 100);
                    reportProgress(progress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return (isRecord, duplicateMessage);
        }

        public DataTable GetShotCountDataToTable(string partNumber = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT 
                    CONCAT(YEAR(prod_date), '-', RIGHT('0' + CAST(MONTH(prod_date) AS VARCHAR(2)), 2)) AS [Month],
                    partnumber AS [Part Number],
                    customer,
                    dienumber AS [Die Number],
                    SUM(shot_count) AS [Monthly Shot Count],
                    SUM(SUM(shot_count)) OVER (
                        PARTITION BY partnumber 
                        ORDER BY YEAR(prod_date), MONTH(prod_date)
                    ) AS [Accumulated Shot Count]
                FROM ShotCount_Table
                WHERE shot_count IS NOT NULL";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(partNumber))
            {
                query += " AND partnumber LIKE @PartNumber";
                parameters.Add(new SqlParameter("@PartNumber", "%" + partNumber + "%"));
            }

            if (dateFrom.HasValue)
            {
                query += " AND CAST(prod_date AS DATE) >= @DateFrom";
                parameters.Add(new SqlParameter("@DateFrom", dateFrom.Value.Date));
            }

            if (dateTo.HasValue)
            {
                query += " AND CAST(prod_date AS DATE) <= @DateTo";
                parameters.Add(new SqlParameter("@DateTo", dateTo.Value.Date));
            }

            query += @"
                   GROUP BY 
                YEAR(prod_date), 
                MONTH(prod_date), 
                partnumber, 
                customer, 
                dienumber
            ORDER BY YEAR(prod_date), MONTH(prod_date)";

            using (SqlConnection con = connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                con.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

    }
}
