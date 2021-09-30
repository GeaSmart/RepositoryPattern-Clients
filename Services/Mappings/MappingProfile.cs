using AutoMapper;
using DAL.Entidades;
using Services.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IClientModel, ClientModel>().ReverseMap();
            CreateMap<IClientModel, ClientEntity>().ReverseMap();
        }
    }
}
