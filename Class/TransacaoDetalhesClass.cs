using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class TransacaoDetalhesClass
    {
        public int id_venda { get; set; }
        public int produto_id { get; set; }
        public int valor { get; set; }
        public int quantidade { get; set; }
        public int total { get; set; }
        public int cliente_id { get; set; }
        public int criacao_data { get; set; }
        public int criado_por { get; set; }
    }
}
