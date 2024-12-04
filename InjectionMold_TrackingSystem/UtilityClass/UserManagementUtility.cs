using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class UserData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public string Section { get; set; }
        public string Date { get; set; }
    }
    public class UserManagementUtility
    {
        private readonly DbConnection _connection;

        public UserManagementUtility()
        {
            _connection = new DbConnection();
        }
        public UserData GetandVerifyUser(string userId, string password)
        {
            UserData RetrievedUser = null;
            try
            {
                using (SqlConnection conn = _connection.GetConnection())
                {
                    string query = "select username, password, type, section, employeename from Users where " +
                                    "username COLLATE Latin1_General_CS_AS = @username and password COLLATE Latin1_General_CS_AS = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@username",userId);
                        cmd.Parameters.AddWithValue("@Password",password);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                RetrievedUser = new UserData()
                                {
                                    UserName = reader["username"].ToString(),
                                    Password = reader["password"].ToString(),
                                    Section = reader["section"].ToString(),
                                    Role = reader["type"].ToString(),
                                    EmployeeName = reader["employeename"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return RetrievedUser;
        }
        public bool AddUserToDatabase(UserData userData)
        {
            bool IsRecorded = false;
            try
            {
                using(SqlConnection conn = _connection.GetConnection())
                {
                    DateTime dateTime = DateTime.Today;
                    string Query = "insert into Users (EmployeeID, username, password, type, section, employeename, date_created)" +
                                    " values (@employeeID, @username, @password, @type, @section, @employeename, @date_created)";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@employeeID", userData.EmployeeId);
                        cmd.Parameters.AddWithValue("@username", userData.UserName);
                        cmd.Parameters.AddWithValue("@password", userData.Password);
                        cmd.Parameters.AddWithValue("@type", userData.Role);
                        cmd.Parameters.AddWithValue("@section", userData.Section);
                        cmd.Parameters.AddWithValue("@employeename", userData.EmployeeName);
                        cmd.Parameters.AddWithValue("@date_created", dateTime.ToString("MM/dd/yyyy"));

                        int result = cmd.ExecuteNonQuery();
                        IsRecorded = result > 0;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return IsRecorded;
        }
        public List<UserData> GetUsers()
        {
            List<UserData> users = new List<UserData>();

            try
            {
                using(SqlConnection conn = _connection.GetConnection())
                {
                    string Query = "select EmployeeID, username, password, type, section, date_created, employeename from Users";
                    using(SqlCommand cmd = new SqlCommand(Query,conn))
                    {
                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserData userData = new UserData
                                {
                                    EmployeeId = reader["EmployeeID"].ToString() ?? string.Empty,
                                    EmployeeName = reader["employeename"].ToString() ?? string.Empty,
                                    UserName = reader["username"].ToString() ?? string.Empty,
                                    Password = reader["password"].ToString() ?? string.Empty,
                                    Role = reader["type"].ToString() ?? string.Empty,
                                    Section = reader["section"].ToString() ?? string.Empty,
                                };
                                users.Add(userData);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return users;
        }
        public bool Changepassword(UserData userData)
        {
            bool isChangePassSuccess = false;
            try
            {
                using(SqlConnection conn = _connection.GetConnection())
                {
                    string Query = "Update Users set password = @password where employeeID = @employeeID";
                    conn.Open();
                    using(SqlCommand  command = new SqlCommand(Query, conn))
                    {
                        command.Parameters.AddWithValue("@password", userData.Password);
                        command.Parameters.AddWithValue("@employeeID", userData.EmployeeId);
                        int result = command.ExecuteNonQuery();
                        isChangePassSuccess = result > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return isChangePassSuccess;
        }
        public bool UpdateUserData(UserData user)
        {
            
            bool IsUpdateSuccess = false;
            try
            {
                using(SqlConnection connection = _connection.GetConnection())
                {
                    string Query = "Update Users set EmployeeID = @employeeID, username = @username, section = @section, type = @type, employeename = @employeename" +
                                   " where EmployeeID = @employeeID";
                    connection.Open();

                    using(SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", user.EmployeeId);
                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@type", user.Role);
                        cmd.Parameters.AddWithValue("@employeename", user.EmployeeName);
                        cmd.Parameters.AddWithValue("@section", user.Section);

                        int result = cmd.ExecuteNonQuery();
                        IsUpdateSuccess = result > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return IsUpdateSuccess;
        }
        public List<UserData> GetUsersData(string employeeID)
        {
            List<UserData> users = new List<UserData>();

            try
            {
                using (SqlConnection conn = _connection.GetConnection())
                {
                    string Query = "select EmployeeID, username, password, type, section, date_created, employeename from Users where EmployeeID = @employeeID";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserData userData = new UserData
                                {
                                    EmployeeId = reader["EmployeeID"].ToString() ?? string.Empty,
                                    EmployeeName = reader["employeename"].ToString() ?? string.Empty,
                                    UserName = reader["username"].ToString() ?? string.Empty,
                                    Password = reader["password"].ToString() ?? string.Empty,
                                    Role = reader["type"].ToString() ?? string.Empty,
                                    Section = reader["section"].ToString() ?? string.Empty,
                                };
                                users.Add(userData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return users;
        }
        public bool DeleteRecord(string employeeID)
        {
            bool IsDeleted = false;

            try
            {
                using(SqlConnection conn = _connection.GetConnection())
                {
                    conn.Open();
                    string Query = "delete from Users where EmployeeID = @employeeID";

                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        int result = cmd.ExecuteNonQuery();
                        IsDeleted = result > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return IsDeleted;
        }
    }
}
