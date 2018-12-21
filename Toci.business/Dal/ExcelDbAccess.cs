using System.Data;
using System.IO;
using System.Security.Policy;
using ExcelDataReader;

namespace Toci.business.Dal
{
    public class ExcelDbAccess : DbAccessBase<DataTable>
    {
        private IExcelDataReader reader;

        public override bool Connect(string connectionString)
        {
            reader = ExcelDataReader.ExcelReaderFactory.CreateReader(new FileStream("", FileMode.Open));

            return true;

        }

        public override int ExecuteInsert(string query)
        {
            throw new System.NotImplementedException();
        }

        public override DataTable ExecuteSelect(string @select)
        {
            throw new System.NotImplementedException();
        }
    }
}