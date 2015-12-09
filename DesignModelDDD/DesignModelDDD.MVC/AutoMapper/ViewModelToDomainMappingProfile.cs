using AutoMapper;
using DesignModelDDD.Domain.Entities;
using DesignModelDDD.MVC.ViewModels;

namespace DesignModelDDD.MVC.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public new string ProfileName { get; } = "ViewModelToDomainMapping";

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
