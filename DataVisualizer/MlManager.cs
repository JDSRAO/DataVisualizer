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
        public static IDataView LoadData(DatabaseLoader.Column[] loadColumns, string connectionString, StringBuilder query)
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
