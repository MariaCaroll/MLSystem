using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSystem.Class
{
    class ProdutoClass
    {
        public int id_product { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public String description { get; set; }
        public String rate { get; set; }
        public String amt { get; set; }
        public DateTime created_date { get; set; }
        public int creeated_by { get; set; }
    }
}
