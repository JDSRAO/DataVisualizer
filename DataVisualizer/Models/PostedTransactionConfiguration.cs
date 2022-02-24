using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataVisualizer.Models
{
    internal class PostedTransactionConfiguration
    {
        public static DatabaseLoader.Column[] Columns = new DatabaseLoader.Column[]
        {
            new DatabaseLoader.Column() { Name = "", Type = DbType.Single }
        };

        public static string Query => query.ToString();

        private static StringBuilder query 
        { 
            get
            {
                return new StringBuilder();
            } 
        }
    }
}
