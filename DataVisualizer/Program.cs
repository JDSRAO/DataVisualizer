﻿using DataVisualizer.Models;
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


            IDataView data = MlManager.LoadSqlData(PostedTransactionConfiguration.Columns, connectionString, PostedTransactionConfiguration.Query);
            var preview = data.Preview();
        }

        
    }
}
