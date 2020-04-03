using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransferencia
{
    public class Pagamento
    {
        public int Cod_Pag { get; set; }
        public int cod_Func { get; set; }
        public string cod_Prod { get; set; }
        public decimal quantia { get; set; }
        public DateTime Hora { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; }
      

    }
}
