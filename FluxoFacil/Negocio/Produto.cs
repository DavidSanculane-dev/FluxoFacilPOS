using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoFacil.Negocio
{
    public class Produto
    {


        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeMinima { get; set; }
        public int Quantidade { get; set; }
        public string LocalArmazem { get; set; }


    }
}
