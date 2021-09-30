using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IClientRepository:IRepositoryBase<ClientEntity>
    {
        Task<IEnumerable<ClientEntity>> GetAllAsync();
        Task<ClientEntity> GetAsync(int id);
    }
}
