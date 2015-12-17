using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Domain.Interfaces.Repositories
{
    public  interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
