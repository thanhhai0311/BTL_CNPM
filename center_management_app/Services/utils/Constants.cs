using System.Windows.Forms;

namespace center_management_app.Services.utils
{
    class Constants
    {
        public static readonly string ConnectionString = $"Data Source={Application.StartupPath}/data/AppDataBase.db;Version=3;New=False;Compress=True;";
    }
}
