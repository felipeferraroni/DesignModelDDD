using System.Collections.Generic;
using System.Linq;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.Domain.Interfaces.Repositories;
using DesignModelDDD.Domain.Interfaces.Services;

namespace DesignModelDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base (clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
