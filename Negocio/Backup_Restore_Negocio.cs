using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBD;

namespace Negocio
{

    public  class Backup_Restore_Negocio
    {
        coneccao conect = new coneccao();
        public void Backup(String caminho)
        {
            string sql = "BACKUP DATABASE LojaInformatica TO DISK = '" + caminho + "\\LojaInformatica-" + DateTime.Now.Ticks + ".bak'";

            conect.LimparParametro();
            conect.ExecutarBackup(System.Data.CommandType.Text, sql);
        }

        public void Restore(String caminho)
        {
            string sql = "RESTORE DATABASE LojaInformatica FROM DISK = '" + caminho + "' WITH REPLACE;";

            conect.LimparParametro();
            conect.ExecutarBackup(System.Data.CommandType.Text, sql);
        }
    }
}
