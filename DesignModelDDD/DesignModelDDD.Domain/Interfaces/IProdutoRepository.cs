using System.Collections;
using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Domain.Interfaces
{
    public  interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
