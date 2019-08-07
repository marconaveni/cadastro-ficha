using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Cadastro_Assistencia_Tecnica.Model;
using System.Configuration;

namespace Cadastro_Assistencia_Tecnica.Persistence
{
    class ConnectionFactory
    {
        private SqlConnection conn;
        private string nameserver = ConfigurationManager.AppSettings["nameserver"].ToString();
        private string database = ConfigurationManager.AppSettings["database"].ToString();
        private string dbuser = ConfigurationManager.AppSettings["dbuser"].ToString();
        private string dbpassword = ConfigurationManager.AppSettings["dbpassword"].ToString();

        public SqlConnection getConnection()
        {
            try
            {
                //conn = new SqlConnection(@"Data Source=.\Workgroup;Initial Catalog=Assistencia;Persist Security Info=True;User ID=Marco;Password=1234456778");
                conn = new SqlConnection(@"Data Source=" + nameserver + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + dbuser + ";Password=" + dbpassword + " ");
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                throw new DataBaseNotFoundException(ex.Message);
            }
        }
    }
}
