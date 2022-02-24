using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DataVisualizer
{
    public class MlManager
    {
        public static IDataView LoadSqlData(DatabaseLoader.Column[] loadColumns, string connectionString, string query)
        {
            var connection = new SqlConnection(connectionString);
            var factory = DbProviderFactories.GetFactory(connection);

            var context = new MLContext();
            var loader = context.Data.CreateDatabaseLoader(loadColumns);
            var dbSource = new DatabaseSource(factory, connectionString, query);

            var data = loader.Load(dbSource);
            return data;
        }
    }
}
