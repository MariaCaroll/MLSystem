using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class TransacaoClass
    {
        public int id_transacao { get; set; }
        public String tipo { get; set; }
        public int cliente_id { get; set; }
        public decimal subtotal { get; set; }
        public DateTime data_trasacao { get; set; }
        public decimal taxa { get; set; }
        public decimal desconto { get; set; }
        public int criado_por { get; set; }
       
    }
}
