namespace ecommerce.domain
{
    public class ImagemProduto : EntidadeBase
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string CaminhoArquivo { get; set; } = string.Empty;
        public Produto Produto { get; set; } = new();   
    }
}
