using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.DirectoryServices.ActiveDirectory;

namespace SaporeGenesis
{
    public partial class Form1 : Form
    {

        Dictionary<string, CheckBox> dicServidores = new Dictionary<string, CheckBox>();
        Bll.PublicaServidor publicaservidor = new Bll.PublicaServidor();
        Bll.ApagarArquivos apagarArquivos = new Bll.ApagarArquivos();

        public Form1()
        {
            InitializeComponent();

            dicServidores.Add("tkns01", tkns01);
            dicServidores.Add("tkns02", tkns02);
            dicServidores.Add("tkns03", tkns03);
            dicServidores.Add("tkns04", tkns04);
            dicServidores.Add("tkns05", tkns05);
            dicServidores.Add("tkns07", tkns07);
            dicServidores.Add("tkns08", tkns08);
            dicServidores.Add("tkns09", tkns09);
            dicServidores.Add("tkns10", tkns10);
            dicServidores.Add("tkns11", tkns11);
            dicServidores.Add("tkns12", tkns12);
            dicServidores.Add("tkns13", tkns13);
            dicServidores.Add("tkns14", tkns14);
            dicServidores.Add("tkns15", tkns15);
            dicServidores.Add("tkns16", tkns16);
            dicServidores.Add("tkns17", tkns17);
            dicServidores.Add("tkns18", tkns18);
            dicServidores.Add("tkns19", tkns19);
            dicServidores.Add("tkns21", tkns21);
            dicServidores.Add("tkns22", tkns22);
            dicServidores.Add("tkns23", tkns23);
            dicServidores.Add("tkns24", tkns24);
            dicServidores.Add("tkns25", tkns25);
            dicServidores.Add("tkns26", tkns26);

        }
        // BOTÃO MARCAR
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, CheckBox> informacaoServidor in dicServidores)
            {
                var a = informacaoServidor.Value;
                a.Checked = true;
            }
        }
        // BOTÃO DESMARCAR
        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, CheckBox> informacaoServidor in dicServidores)
            {
                if (informacaoServidor.Value.Checked)
                {
                    var a = informacaoServidor.Value;
                    a.Checked = false;
                }
            }
        }
        // BOTÃO ARQUIVOS
        private void btnArquivos_Click(object sender, EventArgs e)
        {
            // Verifica Existencia Dos Diretorios De Origem e Os Cria Caso Não Exista 

            if (!Directory.Exists(ConfigurationManager.AppSettings["userTemp"].ToString()))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userTemp"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["rootUser"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userDll"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userQr2"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userBpl"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userZip"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userImport"].ToString());
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["rootUser"].ToString());

            }
            else if (!Directory.Exists(ConfigurationManager.AppSettings["rootUser"].ToString()))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["rootUser"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userDll"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userQr2"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userBpl"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userZip"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["userImport"].ToString());
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["rootUser"].ToString());
            }
            else
            {
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["rootUser"].ToString());
            }

        }

        // BOTÃO FECHAR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTÃO ENVIAR
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool temCheckboxCheckado = false;
            bool temArquivosParaEnviar = false;

            foreach (KeyValuePair<string, CheckBox> informacaoServidor in dicServidores)
            {


                if (informacaoServidor.Value.Checked)
                {

                    temCheckboxCheckado = true;

                    //Date Time
                    DateTime dataHoje = DateTime.Now;
                    String dia = dataHoje.Day.ToString();
                    String mes = dataHoje.Month.ToString();
                    String ano = dataHoje.Year.ToString();
                    String hora = dataHoje.Hour.ToString();
                    String minuto = dataHoje.Minute.ToString();
                    String diaHora = @"-" + dia + @"-" + mes + @"-" + ano + @"-" + hora + @"-" + minuto + @".old";




                    //Origem
                    var userTemp = ConfigurationManager.AppSettings["userTemp"].ToString();
                    var rootUser = ConfigurationManager.AppSettings["rootUser"].ToString();
                    var userDll = ConfigurationManager.AppSettings["userDll"].ToString(); // Diretório Origem
                    var userQr2 = ConfigurationManager.AppSettings["userQr2"].ToString();
                    var userBpl = ConfigurationManager.AppSettings["userBpl"].ToString();
                    var userZip = ConfigurationManager.AppSettings["userZip"].ToString();
                    var userImport = ConfigurationManager.AppSettings["userImport"].ToString();
                    //Destino
                    var serverDll = ConfigurationManager.AppSettings["serverDll" + informacaoServidor.Key].ToString();  // Diretorio Destino
                    var serverBpl = ConfigurationManager.AppSettings["serverBpl" + informacaoServidor.Key].ToString();
                    var serverQr2 = ConfigurationManager.AppSettings["serverQr2" + informacaoServidor.Key].ToString();
                    var serverZip = ConfigurationManager.AppSettings["serverZip" + informacaoServidor.Key].ToString();
                    var serverImport = ConfigurationManager.AppSettings["serverImport" + informacaoServidor.Key].ToString();

                    //  CAPTURA DE ARQUIVOS
                    //DLL
                    string[] userDllNameStr = Directory.GetFiles(userDll); // String
                    var userDllDiretorio = String.Join(",", userDllNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userDllName = System.IO.Path.GetFileName(userDllDiretorio); // Nome do Arquivo
                    //BPL
                    string[] userBplNameStr = Directory.GetFiles(userBpl); // String
                    var userBplDiretorio = String.Join(",", userBplNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userBplName = System.IO.Path.GetFileName(userBplDiretorio); // Nome do Arquivo
                    //QR2
                    string[] userQr2NameStr = Directory.GetFiles(userQr2); // String
                    var userQr2Diretorio = String.Join(",", userQr2NameStr); // Diretorio de Origem + Nome do Arquivo
                    var userQr2Name = System.IO.Path.GetFileName(userQr2Diretorio); // Nome do Arquivo
                    //ZIP
                    string[] userZipNameStr = Directory.GetFiles(userZip); // String
                    var userZipDiretorio = String.Join(",", userZipNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userZipName = System.IO.Path.GetFileName(userZipDiretorio); // Nome do Arquivo

                    if (System.IO.File.Exists(userDll + @"\" + userDllName))
                    {
                        publicaservidor.EnviaArquivos(serverDll, userDllName, userDll, userImport, serverImport, userDllDiretorio, diaHora);
                        temArquivosParaEnviar = true;
                    }
                    else if ((System.IO.File.Exists(userBpl + @"\" + userBplName)))
                    {
                        publicaservidor.EnviaArquivos(serverBpl, userBplName, userBpl, userImport, serverImport, userBplDiretorio, diaHora);
                        temArquivosParaEnviar = true;
                    }
                    else if ((System.IO.File.Exists(userQr2 + @"\" + userQr2Name)))
                    {
                        publicaservidor.EnviaArquivos(serverQr2, userQr2Name, userQr2, userImport, serverImport, userQr2Diretorio, diaHora);
                        temArquivosParaEnviar = true;
                    }
                    else if ((System.IO.File.Exists(userZip + @"\" + userZipName)))
                    {
                        publicaservidor.EnviaArquivos(serverZip, userZipName, userZip, userImport, serverImport, userZipDiretorio, diaHora);
                        temArquivosParaEnviar = true;
                    }




                }



            }


            foreach (KeyValuePair<string, CheckBox> informacaoServidor in dicServidores)
            {
                bool temCheckboxCheckado2 = false;

                if (informacaoServidor.Value.Checked)
                {

                    temCheckboxCheckado2 = true;

                    //Origem
                    var userTemp = ConfigurationManager.AppSettings["userTemp"].ToString();
                    var rootUser = ConfigurationManager.AppSettings["rootUser"].ToString();
                    var userDll = ConfigurationManager.AppSettings["userDll"].ToString(); // Diretório Origem
                    var userQr2 = ConfigurationManager.AppSettings["userQr2"].ToString();
                    var userBpl = ConfigurationManager.AppSettings["userBpl"].ToString();
                    var userZip = ConfigurationManager.AppSettings["userZip"].ToString();
                    var userImport = ConfigurationManager.AppSettings["userImport"].ToString();

                    //  CAPTURA DE ARQUIVOS
                    //DLL
                    string[] userDllNameStr = Directory.GetFiles(userDll); // String
                    var userDllDiretorio = String.Join(",", userDllNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userDllName = System.IO.Path.GetFileName(userDllDiretorio); // Nome do Arquivo
                                                                                    //BPL
                    string[] userBplNameStr = Directory.GetFiles(userBpl); // String
                    var userBplDiretorio = String.Join(",", userBplNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userBplName = System.IO.Path.GetFileName(userBplDiretorio); // Nome do Arquivo
                                                                                    //QR2
                    string[] userQr2NameStr = Directory.GetFiles(userQr2); // String
                    var userQr2Diretorio = String.Join(",", userQr2NameStr); // Diretorio de Origem + Nome do Arquivo
                    var userQr2Name = System.IO.Path.GetFileName(userQr2Diretorio); // Nome do Arquivo
                                                                                    //ZIP
                    string[] userZipNameStr = Directory.GetFiles(userZip); // String
                    var userZipDiretorio = String.Join(",", userZipNameStr); // Diretorio de Origem + Nome do Arquivo
                    var userZipName = System.IO.Path.GetFileName(userZipDiretorio); // Nome do Arquivo


                    if (System.IO.File.Exists(userDll + @"\" + userDllName))
                    {
                        apagarArquivos.ApagarArquivosImportados(userDllName, userDll);
                    }

                    if (System.IO.File.Exists(userBpl + @"\" + userBplName))
                    {
                        apagarArquivos.ApagarArquivosImportados(userBplName, userBpl);
                    }

                    if (System.IO.File.Exists(userQr2 + @"\" + userQr2Name))
                    {
                        apagarArquivos.ApagarArquivosImportados(userQr2Name, userQr2);
                    }

                    if (System.IO.File.Exists(userZip + @"\" + userZipName))
                    {
                        apagarArquivos.ApagarArquivosImportados(userZipName, userZip);
                    }

                }
            }





            if (!temCheckboxCheckado == true)
            {
                MessageBox.Show("Nenhum Servidor Foi Selecionado ! ");
            }

            if (temArquivosParaEnviar == false)
            {
                MessageBox.Show("Não Há Arquivos Nas Pastas De Origem ! ");
            }




            MessageBox.Show("FIM");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }


}









