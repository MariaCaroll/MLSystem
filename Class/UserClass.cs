using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class UserClass
    {
        public int id_usuario { get; set; }
        public String nome_usuario { get; set; }
        public String sobrenome_usuario { get; set; }
        public String email_usuario { get; set; }
        public String login { get; set; }
        public String senha { get; set; }
        public String phone_usuario { get; set; }
        public String endereco_usuario { get; set; }
        public String sexo { get; set; }
        public String tipo_usuario { get; set; }
        public DateTime data_criacao { get; set; }
        public int criado_por { get; set; }
        public String cep_usuario { get; set; }
        public String estado_usuario { get; set; }
        public String bairro_usuario { get; set; }
        public String cidade_usuario { get; set; }
        public String numero_usuario { get; set; }
        public String recuperacao_senha { get; set; }
        public String cpf_usuario { get; set; }
    }
}
