using System;
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

            var root = @"C:\temp";
            var subdir = @"c:\temp\Genesis";
            var dll = @"c:\temp\Genesis\DLL";
            var qr2 = @"c:\temp\Genesis\QR2";
            var bpl = @"c:\temp\Genesis\BPL";
            var zip = @"c:\temp\Genesis\ZIP";
            var import = @"c:\temp\Genesis\Importados";

            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                Directory.CreateDirectory(subdir);
                Directory.CreateDirectory(dll);
                Directory.CreateDirectory(qr2);
                Directory.CreateDirectory(bpl);
                Directory.CreateDirectory(zip);
                Directory.CreateDirectory(import);
                System.Diagnostics.Process.Start(@"c:\temp\Genesis");


            }
            else
            {
                System.Diagnostics.Process.Start(@"c:\temp\Genesis");
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
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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



            // TKNS - 09

            if (tkns09.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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



            // TKNS - 10

            if (tkns10.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 11

            if (tkns11.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 12

            if (tkns12.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 13

            if (tkns13.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 14

            if (tkns14.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 15

            if (tkns15.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 16

            if (tkns16.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 17

            if (tkns17.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 18

            if (tkns18.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 19

            if (tkns19.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 21

            if (tkns21.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 22

            if (tkns22.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 23

            if (tkns23.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 24

            if (tkns24.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 25

            if (tkns25.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 26

            if (tkns26.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 01

            if (tkns01.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 02

            if (tkns02.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 03

            if (tkns21.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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


            // TKNS - 04

            if (tkns04.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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

            // TKNS - 05

            if (tkns05.Checked == true)
            {
                var dirDllOrigin = @"c:\temp\Genesis\DLL"; // Diretorio Origem da Dll
                var dirBplOrigin = @"c:\temp\Genesis\BPL"; // Diretorio Origem da BPL
                var dirQr2Origin = @"c:\temp\Genesis\QR2"; // Diretorio Origem da QR2
                var dirZipOrigin = @"c:\temp\Genesis\ZIP"; // Diretorio Origem da ZIP 

                var dirDllDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\DLL"; // Diretorio do Servidor ( DESTINO )
                var dirBplDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\BPL"; // Diretorio do Servidor ( DESTINO )
                var dirQr2Destin = @"C:\Users\Filipe Bernardino\Documents\Servidor\QR2"; // Diretorio do Servidor ( DESTINO )
                var dirZipDestin = @"C:\Users\Filipe Bernardino\Documents\Servidor\ZIP"; // Diretorio do Servidor ( DESTINO )


                var dirImport = @"C:\temp\Genesis\IMPORTADOS"; // Diretorio de Backup no Servidor ( DESTINO ) 


                string[] filesDll = Directory.GetFiles(dirDllOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesBpl = Directory.GetFiles(dirBplOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesQr2 = Directory.GetFiles(dirQr2Origin); // Nome do  Diretorio e Nome do Arquivo ( array )
                string[] filesZip = Directory.GetFiles(dirZipOrigin); // Nome do  Diretorio e Nome do Arquivo ( array )





                string resultDll = String.Join(",", filesDll); // Encontra Nome do Arquivo
                string resultBpl = String.Join(",", filesBpl); // Encontra Nome do Arquivo
                string resultQr2 = String.Join(",", filesQr2); // Encontra Nome do Arquivo
                string resultZip = String.Join(",", filesZip); // Encontra Nome do Arquivo


                var arqDll = System.IO.Path.GetFileName(resultDll); // Guarda o Nome do Arquivo em Uma Variavel
                var arqBpl = System.IO.Path.GetFileName(resultBpl); // Guarda o Nome do Arquivo em Uma Variavel
                var arqQr2 = System.IO.Path.GetFileName(resultQr2); // Guarda o Nome do Arquivo em Uma Variavel
                var arqZip = System.IO.Path.GetFileName(resultZip); // Guarda o Nome do Arquivo em Uma Variavel


                var dirFileDll = dirDllOrigin + @"\" + arqDll;  // Diretorio e nome do arquivo ( String )
                var dirFileBpl = dirBplOrigin + @"\" + arqBpl;  // Diretorio e nome do arquivo ( String )
                var dirFileQr2 = dirQr2Origin + @"\" + arqQr2;  // Diretorio e nome do arquivo ( String )
                var dirFileZip = dirZipOrigin + @"\" + arqZip;  // Diretorio e nome do arquivo ( String )

                resultTxt.Text = dirDllDestin;

                resultTxt2.Text = arqDll;


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





        }

    }






}



