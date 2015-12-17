using System.Collections.Generic;
using System.Linq;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.Domain.Interfaces.Repositories;

namespace DesignModelDDD.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
