using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
