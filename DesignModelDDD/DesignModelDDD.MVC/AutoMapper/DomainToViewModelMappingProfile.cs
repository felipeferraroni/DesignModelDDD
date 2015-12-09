using AutoMapper;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.MVC.ViewModels;

namespace DesignModelDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public new string ProfileName { get; } = @"ViewModelToDomainMapping";

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
