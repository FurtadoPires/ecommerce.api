using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.domain
{
    public class ImagemProduto : EntidadeBase
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CaminhoArquivo { get; set; }
        public Produto Produto { get; set; }
    }
}
