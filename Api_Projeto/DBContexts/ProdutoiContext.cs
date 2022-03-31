using Api_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Projeto.DBContexts
{
    public class ProdutoiContext : DbContext
    {
        public ProdutoiContext(DbContextOptions<ProdutoiContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
