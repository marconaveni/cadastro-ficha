
using Cadastro_Assistencia_Tecnica.Business;
using Cadastro_Assistencia_Tecnica.Business.Impl;
using Cadastro_Assistencia_Tecnica.Model;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webapp.Chromium;

namespace webapp.View
{




    public partial class FrmMain : Form
    {

        public ChromiumWebBrowser chrome;
        private IFichaService service = new FichaService();
        private int id = 0;
        public int tipoConsulta = 0;
        private bool admin = false;


        public FrmMain()
        {
            InitializeComponent();

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);




            String page = string.Format(@"{0}\index.html", Application.StartupPath);

            chrome = new ChromiumWebBrowser("http://192.168.0.100:9876/material.io/");
            //chrome = new ChromiumWebBrowser("https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_element_requestfullscreen_exit");
            //chrome = new ChromiumWebBrowser(page);


            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;


            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            chrome.RegisterJsObject("cefCustomObject", new CefCustomObject(chrome, this));

            chrome.FrameLoadEnd += (sender, args) =>
            {
                //Wait for the MainFrame to finish loading
                if (args.Frame.IsMain)
                {
                    //args.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");
                    Clear();
                    args.Frame.ExecuteJavaScriptAsync("$('body').removeClass('esconde');");

                }
            };


        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            chrome.ShowDevTools();
           
            chrome.PrintToPdfAsync(@"D:\out.pdf", new PdfPrintSettings
            {
                BackgroundsEnabled = true,
                HeaderFooterEnabled = false,
                Landscape = true,

                MarginType = CefPdfPrintMarginType.Custom,
                MarginBottom = 0,
                MarginTop = 0,
                MarginLeft = 0,
                MarginRight = 0,

                PageWidth = 0, //210000,
                PageHeight = 0 //297000
            });


        }

        public void Clear()
        {

            id = 0;
            chrome.ExecuteScriptAsync("id = 0;");
            chrome.ExecuteScriptAsync("document.getElementById('nroficha').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('dtentrada').value = '" + DateTime.Now.ToString("dd/MM/yyyy") + "';");
            chrome.ExecuteScriptAsync("document.getElementById('cliente').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('telefone').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('endereco').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('nroendereco').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('aparelho').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('marca').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('modelo').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('acessorios').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('estado').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('valor').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('aprovado').value  = 'Em Aberto';");
            chrome.ExecuteScriptAsync("document.getElementById('dtaprovado').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('ok').value = 'Não';");
            chrome.ExecuteScriptAsync("document.getElementById('dtok').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('entrega').value = 'Não';");
            chrome.ExecuteScriptAsync("document.getElementById('dtentrega').value = '';");
            chrome.ExecuteScriptAsync("document.getElementById('detalhes').value = '';");

            chrome.ExecuteScriptAsync("formsVisible()");

            chrome.ExecuteScriptAsync("$('select').material_select();");
            chrome.ExecuteScriptAsync("$('#detalhes').trigger('autoresize');");
            chrome.ExecuteScriptAsync("Materialize.updateTextFields();");

            chrome.ExecuteScriptAsync("$('#btnVer').addClass('esconde');");
            chrome.ExecuteScriptAsync("$('#btnExcluir').addClass('esconde');");


            chrome.ExecuteScriptAsync("document.getElementById('btnCadastrar').text = 'cadastrar' ");
            chrome.ExecuteScriptAsync("document.getElementById('nroficha').focus();");
            chrome.ExecuteScriptAsync("consultar();");

            chrome.ExecuteScriptAsync("document.getElementById('nroficha').disabled = false;");
            chrome.ExecuteScriptAsync("document.getElementById('dtentrada').disabled = false;");
            chrome.ExecuteScriptAsync("document.getElementById('cliente').disabled = false;");
            chrome.ExecuteScriptAsync("document.getElementById('aparelho').disabled = false;");
        }



        public void SetForm(int _id)
        {
            Ficha ficha = new Ficha();
            ficha = service.findById(_id);

            id = ficha.Id;
            chrome.ExecuteScriptAsync("id = " + ficha.Id + ";");
            chrome.ExecuteScriptAsync("document.getElementById('nroficha').value = '" + ficha.NroFicha + "';");
            chrome.ExecuteScriptAsync("document.getElementById('dtentrada').value = '" + ficha.DataEntrada.ToString("dd/MM/yyyy") + "';");
            chrome.ExecuteScriptAsync("document.getElementById('cliente').value = '" + ficha.Cliente + "';");
            chrome.ExecuteScriptAsync("document.getElementById('telefone').value = '" + ficha.Telefone + "';");
            chrome.ExecuteScriptAsync("document.getElementById('endereco').value = '" + ficha.Endereco + "';");
            chrome.ExecuteScriptAsync("document.getElementById('nroendereco').value = '" + ficha.NroEndereco + "';");
            chrome.ExecuteScriptAsync("document.getElementById('aparelho').value = '" + ficha.Aparelho + "';");
            chrome.ExecuteScriptAsync("document.getElementById('marca').value = '" + ficha.Marca + "';");
            chrome.ExecuteScriptAsync("document.getElementById('modelo').value = '" + ficha.Modelo + "';");
            chrome.ExecuteScriptAsync("document.getElementById('acessorios').value = '" + ficha.Acessorios + "';");
            chrome.ExecuteScriptAsync("document.getElementById('estado').value = '" + ficha.Estado + "';");
            chrome.ExecuteScriptAsync("document.getElementById('valor').value = '" + ficha.Valor + "';");
            chrome.ExecuteScriptAsync("document.getElementById('aprovado').value  ='" + ficha.Aprovado + "';");
            chrome.ExecuteScriptAsync("document.getElementById('dtaprovado').value = '" + ficha.DataAprovado + "';");
            chrome.ExecuteScriptAsync("document.getElementById('ok').value = '" + ficha.Ok + "';");
            chrome.ExecuteScriptAsync("document.getElementById('dtok').value = '" + ficha.DataOk + "';");
            chrome.ExecuteScriptAsync("document.getElementById('entrega').value = '" + ficha.Entrega + "';");
            chrome.ExecuteScriptAsync("document.getElementById('dtentrega').value = '" + ficha.DataEntrega + "';");
            chrome.ExecuteScriptAsync("document.getElementById('detalhes').value = '" + ficha.Detalhes.Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n") + "';");

            chrome.ExecuteScriptAsync("formsVisible()");

            chrome.ExecuteScriptAsync("$('select').material_select();");
            chrome.ExecuteScriptAsync("$('#detalhes').trigger('autoresize');");
            chrome.ExecuteScriptAsync("Materialize.updateTextFields();");
            chrome.ExecuteScriptAsync("$('ul.tabs').tabs('select_tab', 'cadastro');");

            chrome.ExecuteScriptAsync("$('#btnVer').removeClass('esconde');");

            chrome.ExecuteScriptAsync("document.getElementById('btnCadastrar').text = 'Alterar' ");

            if (admin == false)
            {
                chrome.ExecuteScriptAsync("document.getElementById('nroficha').disabled = true;");
                chrome.ExecuteScriptAsync("document.getElementById('dtentrada').disabled = true;");
                chrome.ExecuteScriptAsync("document.getElementById('cliente').disabled = true;");
                chrome.ExecuteScriptAsync("document.getElementById('aparelho').disabled = true;");
            }
            else
            {
               chrome.EvaluateScriptAsync("excluir()");
            }

        }


        //metodo assincrono exemplo http://www.macoratti.net/17/12/c_progassinc1.htm
        public async Task<string> GetInputForm(string inputName)
        {
            Ficha ficha = new Ficha();
            string valor = "";
            string script = string.Format("document.getElementById('" + inputName + "').value;");
            await chrome.EvaluateScriptAsync(script).ContinueWith(x =>
            {
                var response = x.Result;
                if (response.Success && response.Result != null)
                {
                    var startDate = response.Result;
                    valor = startDate.ToString();
                }

            });

            return valor;
        }

        public void GetForm()
        {

        }

        public void SearchFicha(string text)
        {

            /*string value = @"setTabela(""";
            value += GetFicha(text);
            value += @""")";*/

            string value = string.Format(@"setTabela(""{0}""); ", GetFicha(text));
            chrome.ExecuteScriptAsync(value);
        }

        public async Task insertFicha()
        {

            Ficha ficha = new Ficha();
            ficha.Id = id;
            ficha.DataEntrada = Convert.ToDateTime(await GetInputForm("dtentrada"));
            ficha.NroFicha = await GetInputForm("nroficha");
            ficha.Cliente = await GetInputForm("cliente");
            ficha.Telefone = await GetInputForm("telefone");
            ficha.Endereco = await GetInputForm("endereco");
            ficha.NroEndereco = await GetInputForm("nroendereco");
            ficha.Aparelho = await GetInputForm("aparelho");
            ficha.Marca = await GetInputForm("marca");
            ficha.Modelo = await GetInputForm("modelo");
            ficha.Acessorios = await GetInputForm("acessorios");
            ficha.Estado = await GetInputForm("estado");
            if (await GetInputForm("valor") == "")
                ficha.Valor = 0;
            else
                ficha.Valor = Convert.ToDecimal(await GetInputForm("valor"));        
            ficha.Aprovado = await GetInputForm("aprovado");
            ficha.DataAprovado = await GetInputForm("dtaprovado");
            ficha.Ok = await GetInputForm("ok");
            ficha.DataOk = await GetInputForm("dtok");
            ficha.Entrega = await GetInputForm("entrega");
            ficha.DataEntrega = await GetInputForm("dtentrega");
            ficha.Detalhes = await GetInputForm("detalhes");
            //message(ficha.Cliente + " " + id);

            if (ficha.Aprovado == "Em Aberto")
            {
                ficha.DataAprovado = "";
            }
            if (ficha.Ok != "Sim")
            {
                ficha.DataOk = "";
            }
            if (ficha.Entrega == "Não")
            {
                ficha.DataEntrega = "";
            }

            service.insert(ficha);
            if (ficha.Id == 0)
                MessageModal("Ficha Cadastrada com sucesso!");
            else
                MessageModal("Ficha Alterada com sucesso!");
            Clear();


        }

        public void DeleteFicha()
        {
            if (id != 0)
            {
                Ficha ficha = new Ficha();
                ficha.Id = id;
                service.remove(ficha);
                MessageModal("Registro Excluído com Sucesso!");
                Clear();
            }
        }



        public void MessageModal(string message)
        {
            MessageModal(message, false);
        }

        public void MessageModal(bool question)
        {
            MessageModal("", question);
        }

        public void MessageModal(string message, bool question)
        {
            if (question)
            {
                chrome.ExecuteScriptAsync("$('#messagebox-question').modal('open');");
            }
            else
            {
                chrome.ExecuteScriptAsync("$('#messagebox').modal('open');");
                chrome.ExecuteScriptAsync("document.getElementById('msg').innerText = '" + message + "';");
            }
        }

        private string GetFicha(string consulta)
        {
            string tabela = "";
            Ficha ficha = new Ficha();
            List<Ficha> fichaList = new List<Ficha>();
            DataTable dt = new DataTable("Fichas");

            if (tipoConsulta == 0)
            {
                ficha.NroFicha = consulta;
                dt = service.findNumero(ficha);
            }
            else if (tipoConsulta == 1)
            {
                ficha.Cliente = consulta;
                dt = service.findCliente(ficha);
            }
            else if (tipoConsulta == 2)
            {
                ficha.Telefone = consulta;
                dt = service.findTelefone(ficha);
            }



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ficha fichas = new Ficha();

                fichas.Id = Convert.ToInt32(dt.Rows[i]["id"]);
                fichas.DataEntrada = Convert.ToDateTime(dt.Rows[i]["Entrada"].ToString());
                fichas.NroFicha = dt.Rows[i]["Número da Ficha"].ToString();
                fichas.Cliente = dt.Rows[i]["cliente"].ToString();
                fichas.Telefone = dt.Rows[i]["telefone"].ToString();
                fichas.Endereco = dt.Rows[i]["Endereço"].ToString();
                fichas.NroEndereco = dt.Rows[i]["Número Endereço"].ToString();
                fichas.Aparelho = dt.Rows[i]["aparelho"].ToString();
                fichas.Marca = dt.Rows[i]["marca"].ToString();
                fichas.Modelo = dt.Rows[i]["modelo"].ToString();
                fichas.Estado = dt.Rows[i]["estado"].ToString();
                fichas.Valor = Convert.ToDecimal(dt.Rows[i]["valor"].ToString());
                fichas.Aprovado = dt.Rows[i]["aprovado"].ToString();
                fichas.Ok = dt.Rows[i]["Pronto"].ToString();
                fichas.DataOk = dt.Rows[i]["Data Pronto"].ToString();
                fichas.Entrega = dt.Rows[i]["Entregue"].ToString();
                fichas.DataEntrega = dt.Rows[i]["Data Entrega"].ToString();
                fichas.Detalhes = dt.Rows[i]["detalhes"].ToString();

                fichaList.Add(fichas);

            }

            /*for (int i = 0; i < dt.Rows.Count; i++)
            {
                //teste +=  dt.Rows[i]["cliente"].ToString();
            }*/

            StringBuilder msg = new StringBuilder();


            msg.Append("<table class='tabelaficha bordered highlight'>");
            msg.Append("<thead>");
            msg.Append("<tr>");
            msg.Append("<th>Entrada</th>");
            msg.Append("<th>Ficha</th>");
            msg.Append("<th>Cliente</th>");
            msg.Append("<th>Telefone</th>");
            msg.Append("<th>Aparelho</th>");
            msg.Append("<th>Marca</th>");
            msg.Append("<th>Valor</th>");
            msg.Append("<th>Entregue</th>");
            // msg.Append("<th>Opções</th>");
            msg.Append("</tr>");
            msg.Append("</thead>");
            msg.Append("<tbody>");
            //msg.Append("");


            foreach (var item in fichaList)
            {
                msg.Append("<tr ondblclick='formulario(" + item.Id + ")' class='sel'>");
                msg.Append("<td>" + item.DataEntrada.ToString("dd/MM/yyyy") + "</td>");
                msg.Append("<td>" + item.NroFicha + "</td>");
                msg.Append("<td>" + item.Cliente + "</td>");
                msg.Append("<td>" + item.Telefone + "</td>");
                msg.Append("<td>" + item.Aparelho + "</td>");
                msg.Append("<td>" + item.Marca + "</td>");
                msg.Append("<td>" + item.Valor + "</td>");
                msg.Append("<td>" + item.Entrega + "</td>");
                // msg.Append("<td><a class='waves-effect circle icone' href='#'><i class='material-icons'>edit</i></a></td>");
                msg.Append("</tr>");
            }


            msg.Append("</tbody>");
            msg.Append("</table>");
            tabela = msg.ToString();
            return tabela;

        }

        public bool login(string password)
        {
            string pass = ConfigurationManager.AppSettings["pass"].ToString();
            if (pass.Equals(password))
            {
                chrome.ExecuteScriptAsync("document.getElementById('nroficha').disabled = false;");
                chrome.ExecuteScriptAsync("document.getElementById('dtentrada').disabled = false;");
                chrome.ExecuteScriptAsync("document.getElementById('cliente').disabled = false;");
                chrome.ExecuteScriptAsync("document.getElementById('aparelho').disabled = false;");
                admin = true;
            }
            else
            {
                admin = false;
            }
            return admin;
        }

        public void message(string message)
        {
            MessageBox.Show(message);
        }
    }
}
