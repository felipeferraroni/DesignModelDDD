using System.Collections;
using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.Domain.Interfaces.Repositories;
using DesignModelDDD.Domain.Interfaces.Services;

namespace DesignModelDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }
    }
}
