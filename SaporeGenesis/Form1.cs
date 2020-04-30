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


namespace SaporeGenesis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            tkns01.Checked = false;
            tkns02.Checked = false;
            tkns03.Checked = false;
            tkns04.Checked = false;
            tkns05.Checked = false;
            tkns07.Checked = false;
            tkns08.Checked = false;
            tkns09.Checked = false;
            tkns10.Checked = false;
            tkns11.Checked = false;
            tkns12.Checked = false;
            tkns13.Checked = false;
            tkns14.Checked = false;
            tkns15.Checked = false;
            tkns16.Checked = false;
            tkns17.Checked = false;
            tkns18.Checked = false;
            tkns19.Checked = false;
            tkns21.Checked = false;
            tkns22.Checked = false;
            tkns23.Checked = false;
            tkns24.Checked = false;
            tkns25.Checked = false;
            tkns26.Checked = false;

        }

        private void group4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tkns01.Checked = true;
            tkns02.Checked = true;
            tkns03.Checked = true;
            tkns04.Checked = true;
            tkns05.Checked = true;
            tkns07.Checked = true;
            tkns08.Checked = true;
            tkns09.Checked = true;
            tkns10.Checked = true;
            tkns11.Checked = true;
            tkns12.Checked = true;
            tkns13.Checked = true;
            tkns14.Checked = true;
            tkns15.Checked = true;
            tkns16.Checked = true;
            tkns17.Checked = true;
            tkns18.Checked = true;
            tkns19.Checked = true;
            tkns21.Checked = true;
            tkns22.Checked = true;
            tkns23.Checked = true;
            tkns24.Checked = true;
            tkns25.Checked = true;
            tkns26.Checked = true;
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            // Verifica Existencia Dos Diretorios De Origem e Os Cria Caso Não Exista 

            if (!Directory.Exists(ConfigurationManager.AppSettings["root"].ToString()))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["root"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["subdir"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["dll"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["qr2"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["bpl"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["zip"].ToString());
                Directory.CreateDirectory(ConfigurationManager.AppSettings["dirImport"].ToString());
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["subdir"].ToString());
            }
            else
            {
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["subdir"].ToString());
            }
        }

        private void tkns07_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // TKNS - 07
            if (tkns07.Checked == true)
            {
                //Origem
                var dirDllOrigin = ConfigurationManager.AppSettings["dll"].ToString();
                var dirBplOrigin = ConfigurationManager.AppSettings["bpl"].ToString();
                var dirQr2Origin = ConfigurationManager.AppSettings["qr2"].ToString();
                var dirZipOrigin = ConfigurationManager.AppSettings["zip"].ToString();
                //Destino
                var dirDllDestin = ConfigurationManager.AppSettings["dirDllDestin"].ToString();
                var dirBplDestin = ConfigurationManager.AppSettings["dirBplDestin"].ToString();
                var dirQr2Destin = ConfigurationManager.AppSettings["dirQr2Destin"].ToString();
                var dirZipDestin = ConfigurationManager.AppSettings["dirZipDestin"].ToString();
                //Backup
                var dirImport = ConfigurationManager.AppSettings["dirImport"].ToString();
                //Captura de Arquivos
                string[] filesDll = Directory.GetFiles(dirDllOrigin);
                string[] filesBpl = Directory.GetFiles(dirBplOrigin);
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin);
                string[] filesZip = Directory.GetFiles(dirZipOrigin);
                //Captura Nome de Arquivos
                string resultDll = String.Join(",", filesDll);
                string resultBpl = String.Join(",", filesBpl);
                string resultQr2 = String.Join(",", filesQr2);
                string resultZip = String.Join(",", filesZip);
                //Guarda Nome de Arquivos
                var arqDll = System.IO.Path.GetFileName(resultDll);
                var arqBpl = System.IO.Path.GetFileName(resultBpl);
                var arqQr2 = System.IO.Path.GetFileName(resultQr2);
                var arqZip = System.IO.Path.GetFileName(resultZip);
                // Concatena Diretorio + Nome de arquivos
                var dirFileDll = dirDllOrigin + @"\" + arqDll;
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;
                var dirFileZip = dirZipOrigin + @"\" + arqZip;
                //  DLL                       
                if (System.IO.File.Exists(dirFileDll))
                {
                    File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirDllDestin, arqDll + @".old"), true);
                    File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirDllDestin, arqDll), true);
                    File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirImport, arqDll), true);
                    System.IO.File.Delete(dirFileDll);
                }
                else
                {
                    if (!System.IO.File.Exists(dirDllOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo DLL na pasta de DLL´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirDllDestin, arqDll), true);
                        File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirImport, arqDll), true);
                        System.IO.File.Delete(dirDllOrigin);
                    }
                }
                // BPL 

                if (System.IO.File.Exists(dirFileBpl))
                {
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin, arqBpl + @".old"), true);
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin, arqBpl), true);
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirImport, arqBpl), true);
                    System.IO.File.Delete(dirFileBpl);
                }

                else
                {
                    if (!System.IO.File.Exists(dirBplOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo BPL na pasta de BPL´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin, arqBpl), true);
                        File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirImport, arqBpl), true);
                        System.IO.File.Delete(dirBplOrigin);
                    }
                }
                // QR2

                if (System.IO.File.Exists(dirFileQr2))
                {
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin, arqQr2 + @".old"), true);
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin, arqQr2), true);
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirImport, arqQr2), true);
                    System.IO.File.Delete(dirFileQr2);
                }
                else
                {
                    if (!System.IO.File.Exists(dirQr2Origin))
                    {
                        MessageBox.Show("Não Existe Arquivo QR2 na pasta de QR2´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin, arqQr2), true);
                        File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirImport, arqQr2), true);
                        System.IO.File.Delete(dirQr2Origin);
                    }
                }
                // ZIP 

                if (System.IO.File.Exists(dirFileZip))
                {
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin, arqZip + @".old"), true);
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin, arqZip), true);
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirImport, arqZip), true);
                    System.IO.File.Delete(dirFileZip);
                }
                else
                {
                    if (!System.IO.File.Exists(dirZipOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo ZIP na pasta de ZIP´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin, arqZip), true);
                        File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirImport, arqZip), true);
                        System.IO.File.Delete(dirZipOrigin);
                    }
                }

            }


            // TKNS - 08
            if (tkns08.Checked == true)
            {
                //Origem
                var dirDllOrigin = ConfigurationManager.AppSettings["dll"].ToString();
                var dirBplOrigin = ConfigurationManager.AppSettings["bpl"].ToString();
                var dirQr2Origin = ConfigurationManager.AppSettings["qr2"].ToString();
                var dirZipOrigin = ConfigurationManager.AppSettings["zip"].ToString();
                //Destino
                var dirDllDestin08 = ConfigurationManager.AppSettings["dirDllDestin08"].ToString();
                var dirBplDestin08 = ConfigurationManager.AppSettings["dirBplDestin08"].ToString();
                var dirQr2Destin08 = ConfigurationManager.AppSettings["dirQr2Destin08"].ToString();
                var dirZipDestin08 = ConfigurationManager.AppSettings["dirZipDestin08"].ToString();
                //Backup
                var dirImport08 = ConfigurationManager.AppSettings["dirImport08"].ToString();
                //Captura de Arquivos
                string[] filesDll = Directory.GetFiles(dirDllOrigin);
                string[] filesBpl = Directory.GetFiles(dirBplOrigin);
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin);
                string[] filesZip = Directory.GetFiles(dirZipOrigin);
                //Captura Nome de Arquivos
                string resultDll = String.Join(",", filesDll);
                string resultBpl = String.Join(",", filesBpl);
                string resultQr2 = String.Join(",", filesQr2);
                string resultZip = String.Join(",", filesZip);
                //Guarda Nome de Arquivos
                var arqDll = System.IO.Path.GetFileName(resultDll);
                var arqBpl = System.IO.Path.GetFileName(resultBpl);
                var arqQr2 = System.IO.Path.GetFileName(resultQr2);
                var arqZip = System.IO.Path.GetFileName(resultZip);
                // Concatena Diretorio + Nome de arquivos
                var dirFileDll = dirDllOrigin + @"\" + arqDll;
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;
                var dirFileZip = dirZipOrigin + @"\" + arqZip;
                //  DLL                       
                if (System.IO.File.Exists(dirFileDll))
                {
                    File.Copy(Path.Combine(dirDllDestin08, arqDll), Path.Combine(dirDllDestin08, arqDll + @".old"), true);
                    File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirDllDestin08, arqDll), true);
                    File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirImport08, arqDll), true);
                    System.IO.File.Delete(dirFileDll);
                }
                else
                {
                    if (!System.IO.File.Exists(dirDllOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo DLL na pasta de DLL´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirDllDestin08, arqDll), true);
                        File.Copy(Path.Combine(dirDllOrigin, arqDll), Path.Combine(dirImport08, arqDll), true);
                        System.IO.File.Delete(dirDllOrigin);
                    }
                }
                // BPL 

                if (System.IO.File.Exists(dirFileBpl))
                {
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin08, arqBpl + @".old"), true);
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin08, arqBpl), true);
                    File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirImport08, arqBpl), true);
                    System.IO.File.Delete(dirFileBpl);
                }

                else
                {
                    if (!System.IO.File.Exists(dirBplOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo BPL na pasta de BPL´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirBplDestin08, arqBpl), true);
                        File.Copy(Path.Combine(dirBplOrigin, arqBpl), Path.Combine(dirImport08, arqBpl), true);
                        System.IO.File.Delete(dirBplOrigin);
                    }
                }
                // QR2

                if (System.IO.File.Exists(dirFileQr2))
                {
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin08, arqQr2 + @".old"), true);
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin08, arqQr2), true);
                    File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirImport08, arqQr2), true);
                    System.IO.File.Delete(dirFileQr2);
                }
                else
                {
                    if (!System.IO.File.Exists(dirQr2Origin))
                    {
                        MessageBox.Show("Não Existe Arquivo QR2 na pasta de QR2´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirQr2Destin08, arqQr2), true);
                        File.Copy(Path.Combine(dirQr2Origin, arqQr2), Path.Combine(dirImport08, arqQr2), true);
                        System.IO.File.Delete(dirQr2Origin);
                    }
                }
                // ZIP 

                if (System.IO.File.Exists(dirFileZip))
                {
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin08, arqZip + @".old"), true);
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin08, arqZip), true);
                    File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirImport08, arqZip), true);
                    System.IO.File.Delete(dirFileZip);
                }
                else
                {
                    if (!System.IO.File.Exists(dirZipOrigin))
                    {
                        MessageBox.Show("Não Existe Arquivo ZIP na pasta de ZIP´s", "Aviso");
                    }
                    else
                    {
                        File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirZipDestin08, arqZip), true);
                        File.Copy(Path.Combine(dirZipOrigin, arqZip), Path.Combine(dirImport08, arqZip), true);
                        System.IO.File.Delete(dirZipOrigin);
                    }
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}









