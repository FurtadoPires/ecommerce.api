namespace ecommerce.api.DTO
{
    public class ProdutoDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public ICollection<ImagemProdutoDTO> Imagens { get; set; } = new List<ImagemProdutoDTO>();
        public bool Ativo { get; set; }
    }
}
