using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.Domain.Entities;
using AutoMapper;

namespace ArquiteturaDDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProdutoViewModel, Produto>()
                .ConstructUsing(c => new Produto(c.Nome, c.PrecoCusto, c.PrecoVenda, c.Marca));
        }
    }
}