namespace ecommerce.api.DTO
{
    public static class CargaDados
    {
        public static ProdutoDTO ObterProduto(string id)
        {
            List<ImagemProdutoDTO> imagemProdutoDTOs = new List<ImagemProdutoDTO>();
            imagemProdutoDTOs.Add(new ImagemProdutoDTO
            {
                Nome = "PlacaWifi",
                CaminhoArquivo = "C:\\1"
            });
            imagemProdutoDTOs.Add(new ImagemProdutoDTO
            {
                Nome = "PlacaWifi2",
                CaminhoArquivo = "C:\\2"
            });
            return new ProdutoDTO
            {
                Id = id,
                Nome = "Placa Wifi",
                Descricao = "Placa 802.11ac",
                Ativo = true,
                Imagens = imagemProdutoDTOs
            };
        }

        public static List<ProdutoDTO> ObterProdutos()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            for (int i = 0; i < 10; i++)
            {
                produtos.Add(ObterProduto(i.ToString()));
            }
            return produtos;
        }
    }
}
