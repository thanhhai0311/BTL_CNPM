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

        public static int GetTotal()
        {
            int total = 0;
            return total;
        }

        public static List<Student> GetAll([Optional] int page, [Optional] int pageSize)
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

        public static List<Student> GetStudentInClass(string groupID, [Optional] int page, [Optional] int pageSize)
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
        public static bool IsExist(string ID)
        {
            return true;
        }



        public static Student FindByID(string ID)
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

        public static Student FindByUsername(string username)
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

        public static List<Student> FindByEmail(string keyword)
        {
            return Search("Email", keyword);
        }

        public static List<Student> FindByFullname(string keyword)
        {
            return Search("Fullname", keyword);
        }

        private static List<Student> Search(string field, string keyword)
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

        public static string Add(Student student)
        {
            try
            {
                s_connection.Open();
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
            try
            {
                s_connection.Open();
                return true;
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


        public static bool Delete(string id)
        {

            try
            {
                s_connection.Open();
                return true;
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

    }
}
