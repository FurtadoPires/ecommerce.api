﻿using ecommerce.api.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.api.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[Controller]/{id}")]
        public IActionResult ObterProduto(string id)
        {
            if (int.Parse(id) == 2)
            {
                return BadRequest(new { mensagem = "Id inválido" });
            }

            return Ok(CargaDados.ObterProduto(id));
        }

        [HttpGet("[Controller]")]
        public IActionResult ObterProdutos()
        {
            return Ok(CargaDados.ObterProdutos());
        }
    }
}
