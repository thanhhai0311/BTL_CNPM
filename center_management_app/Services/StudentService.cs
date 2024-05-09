using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using center_management_app.Services.models;
using center_management_app.Services.utils;
using DevExpress.XtraPrinting.Native;

namespace center_management_app.Services
{
    class StudentService
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

        public static int getSize()
        {
            s_connection.Open();
            try
            {
                string commandString = "SELECT COUNT(*) AS quantity FROM Students";
                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                SQLiteDataReader reader = command.ExecuteReader();
                int quantity = 0;
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader["quantity"]);
                }
                return quantity;
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

        public static List<Student> GetAll(int page = 0, int pageSize = 5)
        {
            s_connection.Open();
            try
            {
                List<Student> students = new List<Student>();
                string commandString = "SELECT st.id, st.fullName, st.dob, st.gender, st.address, st.phoneNumber, st.email, st.createdDate, st.updatedDate," +
                    "cl.id AS clid, cl.name as clname, cl.totalStudents, cl.subject " +
                    "FROM Students st " +
                    "LEFT JOIN Classes cl ON cl.id = st.classId " +
                    "ORDER BY st.id " +
                    "LIMIT @PageSize OFFSET @Offset;";
                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                command.Parameters.AddWithValue("@PageSize", pageSize);
                command.Parameters.AddWithValue("@Offset", page * pageSize);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var student = new Student()
                    {
                        ID = reader["id"].ToString(),
                        fullName = reader["fullName"].ToString(),
                        dob = Convert.ToDateTime(reader["dob"].ToString()),
                        gender = reader["gender"].ToString() == "1" ? "Nam" : "Nữ",
                        address = reader["address"].ToString(),
                        phoneNumber = reader["phoneNumber"].ToString(),
                        email = reader["email"].ToString(),
                        _class = new Class()
                        {
                            ID = reader["clid"].ToString(),
                            Name = reader["clname"].ToString(),
                            TotalStudent = Int32.Parse(reader["totalStudents"].ToString()),

                        }
                    };
                    students.Add(student);
                }

                return students;
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


        public static List<Student> FindByID(string ID)
        {
            return Search("id", ID);
        }

       

        public static List<Student> FindByPhoneNumber(string phoneNumber)
        {
            return Search("phoneNumber", phoneNumber);
        }

        private static List<Student> Search(string field, string keyword)
        {
            s_connection.Open();
            try
            {
                List<Student> students = new List<Student>();
                string commandString = "SELECT * " +
                    "FROM Students " +
                    $"WHERE {field} LIKE @keyword " +
                    "ORDER BY id " +
                    "LIMIT @PageSize OFFSET @Offset;";

                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                //command.Parameters.AddWithValue("@field", field);
                command.Parameters.AddWithValue("@PageSize", 10);
                command.Parameters.AddWithValue("@Offset", 0);

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var student = new Student()
                    {
                        ID = reader["id"].ToString(),
                        fullName = reader["fullName"].ToString(),
                        dob = Convert.ToDateTime(reader["dob"].ToString()),
                        gender = reader["gender"].ToString() == "1" ? "Nam" : "Nữ",
                        address = reader["address"].ToString(),
                        phoneNumber = reader["phoneNumber"].ToString(),
                        email = reader["email"].ToString(),
                        CreatedDate = Convert.ToDateTime(reader["createdDate"]),
                        UpdatedDate = Convert.ToDateTime(reader["updatedDate"])
                    };
                    students.Add(student);
                }

                return students;
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

        public static bool Delete(int id)
        {
            return ExecuteQuery($"DELETE FROM Students WHERE id = '{id}'");
        }


        public static bool Update(Student student)
        {
            string query = $"UPDATE Students " +
                $"SET classId = {student._class.ID}, " +
                $"fullName = '{student.fullName}', " +
                $"dob = {student.dob}, " +
                $"gender = {student.gender}, " +
                $"address = '{student.address}', " +
                $"phoneNumber = '{student.phoneNumber}', " +
                $"email = '{student.email}', " +
                $"createdDate = {student.CreatedDate}, " +
                $"updatedDate = {student.UpdatedDate} " +
                $"WHERE id = {student.ID}";
            return ExecuteQuery(query);
        }



        public static bool Add(Student student)
        {
            int gender = student.gender == "Nam" ? 1 : 0;
            return ExecuteQuery($"INSERT INTO Students (classId, fullName, dob, gender, address, phoneNumber, email, createdDate, updatedDate) " +
                $"VALUES ('{student._class.ID}', '{student.fullName}', '{student.dob.ToString("yyyy-MM-dd")}', {gender}, '{student.address}', '{student.phoneNumber}', '{student.email}', datetime('now'), datetime('now'));");
        }


        /*public static List<Student> GetAllStudentsInClass(int id)
        {
            s_connection.Open();
            try
            {
                List<Student> students = new List<Student>();
                string commandString = "SELECT * FROM Students WHERE classId = @ID;";
                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                command.Parameters.AddWithValue("@ID", id);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var student = new Student()
                    {
                        id = int.Parse(reader["id"].ToString()),
                        fullName = reader["fullName"].ToString(),
                        dob = Convert.ToDateTime(reader["dob"].ToString()),
                        gender = int.Parse(reader["gender"].ToString()),
                        address = reader["address"].ToString(),
                        phoneNumber = reader["phoneNumber"].ToString(),
                        email = reader["email"].ToString(),
                        createdDate = Convert.ToDateTime(reader["createdDate"].ToString()),
                        updatedDate = Convert.ToDateTime(reader["updatedDate"].ToString())
                    };
                    students.Add(student);
                }

                return students;
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


        public static List<Student> FindByID(string ID)
        {
            return Search("id", ID);
        }

        public static List<Student> FindByEmail(string keyword)
        {
            return Search("email", keyword);
        }

        public static List<Student> FindByFullname(string keyword)
        {
            return Search("fullName", keyword);
        }

        private static List<Student> Search(string field, string keyword)
        {
            s_connection.Open();
            try
            {
                List<Student> students = new List<Student>();
                string commandString = "SELECT * " +
                    "FROM Students " +
                    $"WHERE {field} LIKE @keyword " +
                    "ORDER BY id " +
                    "LIMIT @PageSize OFFSET @Offset;";

                SQLiteCommand command = new SQLiteCommand(commandString, s_connection);
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                //command.Parameters.AddWithValue("@field", field);
                command.Parameters.AddWithValue("@PageSize", 10);
                command.Parameters.AddWithValue("@Offset", 0);

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var student = new Student()
                    {
                        id = int.Parse(reader["id"].ToString()),
                        fullName = reader["fullName"].ToString(),
                        dob = Convert.ToDateTime(reader["dob"].ToString()),
                        gender = int.Parse(reader["gender"].ToString()),
                        address = reader["address"].ToString(),
                        phoneNumber = reader["phoneNumber"].ToString(),
                        email = reader["email"].ToString(),
                        createdDate = Convert.ToDateTime(reader["createdDate"].ToString()),
                        updatedDate = Convert.ToDateTime(reader["updatedDate"].ToString())
                    };
                    students.Add(student);
                }

                return students;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                s_connection.Close();
            }
        }*/

        /*
        public static bool AddMultiple(List<Student> students)
        {
            if (students == null) return false;

            try
            {
                students.ForEach(student => { Add(student); });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Student student)
        {
            string query = $"UPDATE Students " +
                $"SET classId = {student._class.id}, " +
                $"fullName = '{student.fullName}', " +
                $"dob = {student.dob}, " +
                $"gender = {student.gender}, " +
                $"address = '{student.address}', " +
                $"phoneNumber = '{student.phoneNumber}', " +
                $"email = '{student.email}', " +
                $"createdDate = {student.createdDate}, " +
                $"updatedDate = {student.updatedDate} " +
                $"WHERE id = {student.id}";
            return ExecuteQuery(query);
        }


        public static bool Delete(int id)
        {

            return ExecuteQuery($"DELETE FROM Students WHERE id = '{id}'");
        }*/

    }
}