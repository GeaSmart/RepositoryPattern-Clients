using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Client
{
    public interface IClientService
    {
        Task<IEnumerable<IClientModel>> GetAllAsync();
        Task<IClientModel> GetAsync(int id);
        Task<IClientModel> CreateClientAsync(IClientModel model);
        Task<IClientModel> UpdateClientAsync(IClientModel model);
    }
}
