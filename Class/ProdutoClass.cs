using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class ProdutoClass
    {
        public int id_produto { get; set; }
        public String nome_produto { get; set; }
        public String categoria { get; set; }
        public String descricao { get; set; }
        public String valor { get; set; }
        public String quantidade { get; set; }
        public DateTime data_criacao { get; set; }
        public int criado_por { get; set; }
        public String imagem { get; set; }
    }
}
