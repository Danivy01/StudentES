using AJDBLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentES.Data
{
    public class DbControl: AAJDBControl
    {
        public DbControl(): base (new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
        {
            QueryException += DbControl_QueryException;
        }

        private void DbControl_QueryException(Exception exception)
        {
            throw exception;
        }
    }
}