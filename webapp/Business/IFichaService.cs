using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro_Assistencia_Tecnica.Model;
using System.Data;

namespace Cadastro_Assistencia_Tecnica.Business
{
    interface IFichaService
    {
        void insert(Ficha ficha);

        void remove(Ficha ficha);

        DataTable findAll();

        DataTable findCliente(Ficha ficha);

        DataTable findNumero(Ficha ficha);

        DataTable findTelefone(Ficha ficha);

        DataTable findAprovados();

        DataTable findValidaNROFicha(Ficha ficha);

        Ficha findById(int id);


    }
}
