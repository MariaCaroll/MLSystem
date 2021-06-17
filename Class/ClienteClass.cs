using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class ClienteClass
    {
        public int id_cliente { get; set; }
        public String nome_cliente { get; set; }
        public String sobrenome_cliente { get; set; }
        public String email_cliente { get; set; }
        public String phone_cliente { get; set; }
        public String sexo_cliente { get; set; }
        public String aniversario_cliente { get; set; }
        public String cep_cliente { get; set; }
        public String estado_cliente { get; set; }
        public String endereco_cliente { get; set; }
        public String cidade_cliente { get; set; }
        public String bairro_cliente { get; set; }
        public String numero_cliente { get; set; }
        public DateTime data_criacao { get; set; }
        public int criado_por { get; set; }

    }
}
