using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using center_management_app.Services.utils;

namespace center_management_app.Services.models
{
    public class BaseModel
    {
        public string ID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Deleted { get; set; }

        public static bool IsNullOrEmpty(object value)
        {
            return value.GetType() == typeof(DBNull) || string.IsNullOrEmpty(value.ToString());
        }

        public static void BindingBaseInfo<Model>(SQLiteDataReader reader, ref Model record) where Model : BaseModel
        {
            record.ID = reader["ID"].ToString();

            if (!IsNullOrEmpty(reader["CreatedDate"]))
            {
                record.CreatedDate = new DateTime(Helpers.ConvertToLong(reader["CreatedDate"]));
            }

            if (!IsNullOrEmpty(reader["UpdatedDate"]))
            {
                record.UpdatedDate = new DateTime(Helpers.ConvertToLong(reader["UpdatedDate"]));
            }

            record.Deleted = reader["Deleted"].GetType() != typeof(DBNull) && reader["Deleted"].ToString() == "True" ? true : false;
        }
    }
}
