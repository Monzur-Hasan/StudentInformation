using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentInfo.Getway
{
    public class DBGetway
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;


        public DBGetway()
        {
            connection=new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
            command= new SqlCommand();
        }

        public SqlConnection ConnectionObj
        {
            get { return connection; }
        }

        public SqlCommand CommandObj
        {
            get
            { command.Connection = connection;
                return command;

            }
        }
    }
}