using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ClientRepository : RepositoryBase<ClientEntity>,IClientRepository
    {
        public ClientRepository(ApplicationDBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<ClientEntity>> GetAllAsync()
        {
            return await FindAllAsync();
        }
        public async Task<ClientEntity> GetAsync(int id)
        {
            return await FindAsync(id);
        }

    }
}
