using AutoMapper;
using DAL.Entidades;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository repository;
        private readonly IMapper mapper;

        public ClientService(IClientRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<IClientModel>> GetAllAsync()
        {
            IEnumerable<ClientEntity> resultado = repository.GetAllAsync().Result;
            return mapper.Map<IEnumerable<IClientModel>>(resultado);
        }

        public async Task<IClientModel> GetAsync(int id)
        {
            ClientEntity resultado = repository.GetAsync(id).Result;
            return mapper.Map<IClientModel>(resultado);
        }

        public async Task<IClientModel> CreateClientAsync(IClientModel model)
        {
            repository.Create(mapper.Map<ClientEntity>(model));
            await repository.CommitAsync();
            return model;
        }
        public async Task<IClientModel> UpdateClientAsync(IClientModel model)
        {
            repository.Update(mapper.Map<ClientEntity>(model));
            await repository.CommitAsync();
            return model;
        }
        public async Task DeleteClientAsync(IClientModel model)
        {
            var cliente = await repository.GetAsync(model.Id);
            if(cliente != null)
            {
                repository.Delete(cliente);
                await repository.CommitAsync();
            }
        }
    }
}
