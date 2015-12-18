using System.Collections.Generic;
using DesignModelDDD.Domain.Entities;

namespace DesignModelDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> OnterClientesEspeciais();
    }
}
