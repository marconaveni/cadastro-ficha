using Cadastro_Assistencia_Tecnica.Model;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapp.View;

namespace webapp.Chromium
{
    class CefCustomObject
    {
        // Declare a local instance of chromium and the main form in order to execute things from here in the main thread
        private static ChromiumWebBrowser _instanceBrowser = null;
        // The form class needs to be changed according to yours
        private static FrmMain _instanceMainForm = null;

        private int count = 4;


        public CefCustomObject(ChromiumWebBrowser originalBrowser, FrmMain mainForm)
        {
            _instanceBrowser = originalBrowser;
            _instanceMainForm = mainForm;
        }

        public void clear()
        {
            _instanceMainForm.Clear();
        }

        public void insertFicha()
        {
            _instanceMainForm.insertFicha();
        }

        public void deleteFicha()
        {
            _instanceMainForm.DeleteFicha();
        }

        public string dateFormated()
        {
            return DateTime.Now.ToString("dd/MM/yyyy").ToString();
        }

        public void formulario(int value)
        {
            _instanceMainForm.SetForm(value);
        }

        public void tipoConsulta(int tipoconsulta, string consulta)
        {
            _instanceMainForm.tipoConsulta = tipoconsulta;
            _instanceMainForm.SearchFicha(consulta);
        }

        public void opencalc()
        {
            ProcessStartInfo start = new ProcessStartInfo("calc.exe");
            Process.Start(start);
        }

        public void login(string password)
        {
            if (count > 1) {
                if (_instanceMainForm.login(password))
                {
                    _instanceMainForm.MessageModal("Logado com sucesso");
                    _instanceBrowser.EvaluateScriptAsync("document.getElementById('i-admin').innerHTML = 'lock_open';");
                    _instanceBrowser.EvaluateScriptAsync("$('#btnAdmin').removeClass('modal-trigger');");
                    _instanceBrowser.EvaluateScriptAsync("$('#btnAdmin').tooltip('remove');");
                    _instanceBrowser.EvaluateScriptAsync("excluir()");
                }
                else
                {
                    count--;
                    _instanceMainForm.MessageModal("Senha Incorreta, só mais " + count + " tentativa(s)");

                }
            }
            else
            {
                _instanceMainForm.MessageModal("Nº de tentativas excedidas tente novamente mais tarde");
            }
        }

        public string[] datta(string campo)
        {
            Ficha ficha = new Ficha();
            if (campo == "aparelho")
            {
                return ficha.ListaAparelhos();
            }
            else if (campo == "marca")
            {
                return ficha.ListaMarcas();
            }
            else if (campo == "modelo")
            {
                return ficha.ListaModelos();
            }
            else if (campo == "acessorios")
            {
                return ficha.ListaAcessorios();
            }
            else if (campo == "estado")
            {
                return ficha.ListaDefeitos();
            }

            return null;
        }


        public void messageModal(string message, bool question)
        {
            _instanceMainForm.MessageModal(message, question);
        }



    }
}
