using System.Collections.Generic;
using DesignModelDDD.Application.Interface;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.Domain.Interfaces.Services;

namespace DesignModelDDD.Application.Services
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
