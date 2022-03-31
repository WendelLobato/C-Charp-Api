using Api_Projeto.Models;
using Api_Projeto.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Projeto.Controllers
{
    [Route("api/[controller]")]// roda sempre no 5001 / método com s no final e a função
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("GetProduto")]
        public IEnumerable<Produto> GetProdutos()
        {
            return _produtoService.GetProdutos();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Produto/AddProduto")]
        public IActionResult AddProduto(Produto produto)
        {
            _produtoService.AddProduto(produto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Produto/UpdateProduto")]
        public IActionResult UpdateProduto([FromBody] Produto produto)
        {
            _produtoService.UpdateProduto(produto);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Produto/DeleteProduto")]
        public IActionResult DeleteProduto(int id)
        {
            var existingProduto = _produtoService.GetProduto(id);
            if (existingProduto != null)
            {
                _produtoService.DeleteProduto(existingProduto.Id);
                return Ok();
            }
            return NotFound($"Product Not Found with ID : {existingProduto.Id}");
        }

        [HttpGet]
        [Route("GetProduto/{id}")]
        public Produto GetProduto(int id)
        {
            return _produtoService.GetProduto(id);
        }

        [HttpGet]
        [Route("GetProdutoEan/{ean}")]
        public Produto GetProdutoEan(string ean)
        {
            var s= _produtoService.GetProdutoEan(ean);
            return s;
        }
    }
}   
