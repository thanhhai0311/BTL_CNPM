using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace center_management_app.Services.models
{
    public class Class : BaseModel
    {
        public string Name { get; set; }

        public int TotalStudent { get; set; }

        public Teacher teacher { get; set; }


        public override string ToString() {  return Name; }

        public Class(string name) 
        {
            Name = name;
        }

        public Class() { }

        public object this[string propertyName]
        {
            get
            {
                Type type = typeof(Class);
                PropertyInfo info = type.GetProperty(propertyName);
                return info.GetValue(this, null);
            }
        }
    }
}
