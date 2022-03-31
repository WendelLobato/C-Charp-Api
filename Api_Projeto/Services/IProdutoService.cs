using Api_Projeto.Models;
using System.Collections.Generic;


namespace Api_Projeto.Services
{
    public interface IProdutoService
    {
        Produto AddProduto(Produto produto);

        List<Produto> GetProdutos();

        void UpdateProduto(Produto produto);

        void DeleteProduto(int Id);

        Produto GetProduto(int Id);
        Produto GetProdutoEan(string ean);
    }
}
