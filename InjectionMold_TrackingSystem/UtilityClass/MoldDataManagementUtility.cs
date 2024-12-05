using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
