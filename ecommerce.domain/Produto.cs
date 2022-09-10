namespace ecommerce.domain
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string SKU { get; set; }
        public ICollection<ImagemProduto> Imagens { get; set; }
    }
}