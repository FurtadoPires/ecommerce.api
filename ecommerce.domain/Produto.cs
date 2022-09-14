namespace ecommerce.domain
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public ICollection<ImagemProduto> Imagens { get; set; } = new List<ImagemProduto>();
    }
}