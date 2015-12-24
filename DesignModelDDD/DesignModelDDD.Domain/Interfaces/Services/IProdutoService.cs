using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
