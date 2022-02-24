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

            IDataView data = LoadData(loadColumns, query);
            var preview = data.Preview();
        }

        private static IDataView LoadData(DatabaseLoader.Column[] loadColumns, StringBuilder query)
        {
            var connection = new SqlConnection(connectionString);
            var factory = DbProviderFactories.GetFactory(connection);

            var context = new MLContext();
            var loader = context.Data.CreateDatabaseLoader(loadColumns);
            var dbSource = new DatabaseSource(factory, connectionString, query.ToString());

            var data = loader.Load(dbSource);
            return data;
        }
    }
}
