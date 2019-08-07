using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Assistencia_Tecnica.Model
{
    class BusinessException : Exception
    {
        public BusinessException() : base() { }
        public BusinessException(String message) : base(message) { }
    }
}
