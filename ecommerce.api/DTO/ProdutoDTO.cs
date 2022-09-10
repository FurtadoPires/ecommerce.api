namespace ecommerce.api.DTO
{
    public class ProdutoDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<ImagemProdutoDTO> Imagens { get; set; }
        public bool Ativo { get; set; }
    }
}
