using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro_Assistencia_Tecnica.Model;
using Cadastro_Assistencia_Tecnica.Persistence;
using System.Data;

namespace Cadastro_Assistencia_Tecnica.Business.Impl
{
    class FichaService : IFichaService

    {

        private FichaDAO dao;

        public void insert(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                if (ficha.Id == 0)
                    dao.insert(ficha);
                else
                    dao.update(ficha);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (NullReferenceException ex) //temporario
            {
                throw new BusinessException(ex.Message);
            }
        }

        public void remove(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                dao.remove(ficha.Id);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public DataTable findAll()
        {
            try
            {
                dao = new FichaDAO();
                return dao.findAll();
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public DataTable findCliente(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                return dao.findCliente(ficha);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }


        public DataTable findNumero(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                return dao.findNumero(ficha);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }


        public DataTable findTelefone(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                return dao.findTelefone(ficha);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public DataTable findAprovados()
        {
            try
            {
                dao = new FichaDAO();
                return dao.findAprovados();
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public DataTable findValidaNROFicha(Ficha ficha)
        {
            try
            {
                dao = new FichaDAO();
                return dao.findValidaNROFicha(ficha);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public Ficha findById(int id)
        {
            try
            {
                dao = new FichaDAO();
                return dao.findById(id);
            }
            catch (OperacaoDAOException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (DataBaseNotFoundException ex)
            {
                throw new BusinessException(ex.Message);
            }
        }
    }
}
