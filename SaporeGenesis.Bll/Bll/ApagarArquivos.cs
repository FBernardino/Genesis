using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SaporeGenesis.Bll
{
   public  class ApagarArquivos
    {
        public void ApagarArquivosImportados(string userName, string user)
        {
            System.IO.File.Delete(user + @"\" + userName);
        }
    }
}
