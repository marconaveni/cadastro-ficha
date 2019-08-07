using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Assistencia_Tecnica.Model
{
    class OperacaoDAOException: Exception
    {
        public OperacaoDAOException() : base() { }
        public OperacaoDAOException(String message) : base(message) { }
    }
}
