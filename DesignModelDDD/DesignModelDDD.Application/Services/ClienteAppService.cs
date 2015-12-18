using System.Collections.Generic;
using DesignModelDDD.Application.Interface;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.Domain.Interfaces.Services;

namespace DesignModelDDD.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> OnterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
