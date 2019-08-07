using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Assistencia_Tecnica.Model
{
    class DataBaseNotFoundException : Exception
    {
        public DataBaseNotFoundException() : base() { }
        public DataBaseNotFoundException(String message) : base(message) { }
    }
}
