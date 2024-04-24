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
