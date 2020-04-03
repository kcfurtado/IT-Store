using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransferencia
{
    public class ProdutoVenda
    {
        public int Cod_P { get; set; }
        public string Nome_P { get; set; }
        public string Marca_P { get; set; }
        public string Modelo_P { get; set; }
        public int quantidd_stock { get; set; }
        public decimal preco { get; set; }
    }
}
