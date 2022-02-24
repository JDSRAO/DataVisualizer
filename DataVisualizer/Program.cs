using Microsoft.Extensions.Configuration;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DataVisualizer
{
    internal class Program
    {
        private const string connectionString = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var loadColumns = new DatabaseLoader.Column[]
            {
                new DatabaseLoader.Column() { Name = "", Type = DbType.Single }
            };

            var query = new StringBuilder();

            IDataView data = MlManager.LoadSqlData(loadColumns, connectionString, query);
            var preview = data.Preview();
        }

        
    }
}
