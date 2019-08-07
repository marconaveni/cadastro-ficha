using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Cadastro_Assistencia_Tecnica.Persistence;

namespace Cadastro_Assistencia_Tecnica.Business.Impl
{
    class ConnectionService : IConnectionService
    {
          private SqlConnection conn;

          public void testaConexao()
          {
              conn = new ConnectionFactory().getConnection();
          }
    }
}
