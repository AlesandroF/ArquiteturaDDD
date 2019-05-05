using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.Domain.Entities;
using AutoMapper;

namespace ArquiteturaDDD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}