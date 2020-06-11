using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace SaporeGenesis.Bll
{
    public class PublicaServidor
    {


        public void EnviaArquivos(string server, string userName, string user, string userImport, string serverImport, string userDiretorio, String diaHora)
        {


            List<string> lstCaminhoArquivosOrigem = System.IO.Directory.GetFiles(user).ToList();

            foreach (var pathArquivoUserAtual in lstCaminhoArquivosOrigem)
            {

                var arquivoDaVez = System.IO.Path.GetFileName(pathArquivoUserAtual); // Nome do Arquivo



                if (System.IO.File.Exists(server + @"\" + userName))
                {


                    File.Copy(Path.Combine(server, arquivoDaVez), Path.Combine(server, arquivoDaVez + diaHora), true);
                    //  System.IO.File.Move(userName + @".old",   userName + diaHora + @".old");
                    File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(server, arquivoDaVez), true);
                    File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(userImport, arquivoDaVez), true);
                    if (!Directory.Exists(serverImport))
                    {
                        Directory.CreateDirectory(serverImport);
                    }
                    else
                    {
                        File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(serverImport, arquivoDaVez), true);
                    }

             
                }
                else
                {
                    File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(server, arquivoDaVez), true);
                    File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(userImport, arquivoDaVez), true);
                    File.Copy(Path.Combine(user, arquivoDaVez), Path.Combine(serverImport, arquivoDaVez), true);
               
                }


            }

          


        }



    }


}
