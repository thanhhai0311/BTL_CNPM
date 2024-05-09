using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using center_management_app.Services.models;
using center_management_app.Services.utils;

namespace center_management_app.Services
{
    class ClassService
    {
        private static readonly string s_connectionString = Constants.ConnectionString;
        private static readonly SQLiteConnection s_connection = new SQLiteConnection(s_connectionString);

        public static bool ExecuteQuery(string query)
        {
            try
            {
                s_connection.Open();

                SQLiteCommand command = s_connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                s_connection.Close();
            }
        }

        public static List<Class> GetAll([Optional] int page, [Optional] int pageSize)
        {
            s_connection.Open();
            try
            {
                int _page = Convert.ToBoolean(page) && page >= 0 ? page : 0;
                List<Class> classes = new List<Class>();
                string commandString = "SELECT c.id, c.name, c.createdDate, c.totalStudents, c.subject, COUNT(s.id) AS current, " +
                    "t.id AS teacherId, t.fullName AS teacherFullName, t.dob AS teacherDob, t.gender AS teacherGender, " +
                    "t.address AS teacherAddress, t.phoneNumber AS teacherPhoneNumber, t.email AS teacherEmail " +
                    "FROM Classes c " +
                    "LEFT JOIN Students s ON s.classId = c.id " +
                    "LEFT JOIN Teachers t ON c.teacherId = t.id " +
                    "GROUP BY c.id " +
                    "ORDER BY c.createdDate ASC " +
                    (Convert.ToBoolean(pageSize) && pageSize > 0 && _page >= 0 ? "LIMIT " + _page * pageSize + ", " + pageSize : "") +
                    ";";

                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["id"].ToString() != null)
                    {
                        var _class = new Class()
                        {
                            ID = reader["id"].ToString(),
                            Name = reader["name"].ToString(),
                            TotalStudent = Int32.Parse(reader["totalStudents"].ToString()),
                            //createdDate = Convert.ToDateTime(reader["createdDate"].ToString()),
                            //current = Int32.Parse(reader["current"].ToString()),
                            teacher = new Teacher()
                            {
                                ID = reader["teacherId"].ToString(),
                                fullName = reader["teacherFullName"].ToString(),
                                dob = Convert.ToDateTime(reader["teacherDob"].ToString()),
                                //gender = reader["gender"].ToString() == "1" ? "Nam" : "Nữ",
                                address = reader["teacherAddress"].ToString(),
                                phoneNumber = reader["teacherPhoneNumber"].ToString(),
                                email = reader["teacherEmail"].ToString()
                            }
                        };
                        classes.Add(_class);
                    }
                }

                return classes;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                s_connection.Close();
            }
        }

        public static List<Class> FindByName(string keyword, [Optional] int page, [Optional] int pageSize)
        {
            s_connection.Open();
            try
            {
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                s_connection.Close();
            }
        }

        public static Class FindByID(string ID)
        {
            s_connection.Open();
            try
            {
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                s_connection.Close();
            }
        }

        public static bool Add(string name)
        {
            return true;
        }

        public static bool Delete(string ID)
        {
            return true;
        }
    }
}
