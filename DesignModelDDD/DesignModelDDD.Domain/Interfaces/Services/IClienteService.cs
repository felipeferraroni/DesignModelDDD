using System.Collections;
using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
