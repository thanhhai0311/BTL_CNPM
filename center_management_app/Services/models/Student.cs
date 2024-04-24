using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace center_management_app.Services.models
{
    public class Student : BaseModel
    {
        public string phoneNumber { get; set; }

        public string fullName { get; set; }

        public string gender { get; set; }

        public string address { get; set; }

        public DateTime dob { get; set; }

        public Class _class { get; set; }

        public string email { get; set; }

        public object this[string propertyName]
        {
            get
            {
                Type type = typeof(Student);
                PropertyInfo info = type.GetProperty(propertyName);
                return info.GetValue(this, null);
            }
        }
    }

}
