using Api_Projeto.DBContexts;
using Api_Projeto.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_Projeto.Services
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoiContext _produtoDbContext;
        public ProdutoService(ProdutoiContext ProdutoDbContext)
        {
            _produtoDbContext = ProdutoDbContext;
        }
        public Produto AddProduto(Produto Produto)
        {
            _produtoDbContext.Produtos.Add(Produto);
            _produtoDbContext.SaveChanges();
            return Produto;
        }
        public List<Produto> GetProdutos()
        {
            return _produtoDbContext.Produtos.ToList();
        }

        public void UpdateProduto(Produto Produto)
        {
            _produtoDbContext.Produtos.Update(Produto);
            _produtoDbContext.SaveChanges();
        }

        public void DeleteProduto(int Id)
        {
            var Produto = _produtoDbContext.Produtos.FirstOrDefault(x => x.Id == Id);
            if (Produto != null)
            {
                _produtoDbContext.Remove(Produto);
                _produtoDbContext.SaveChanges();
            }
        }

        public Produto GetProduto(int Id)
        {
            return _produtoDbContext.Produtos.FirstOrDefault(x => x.Id == Id);
        }

        public Produto GetProdutoEan(string Ean)
        {
            return _produtoDbContext.Produtos.FirstOrDefault(x => x.Ean == Ean);
        }
    }
}
