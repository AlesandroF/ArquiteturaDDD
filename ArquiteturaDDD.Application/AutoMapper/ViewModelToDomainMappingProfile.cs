using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.Domain.Builders;
using ArquiteturaDDD.Domain.Entities;
using AutoMapper;

namespace ArquiteturaDDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProdutoViewModel, ProdutoBuilder>()
                .ConstructUsing(c => new ProdutoBuilder(c.Nome, c.PrecoCusto, c.PrecoVenda, c.Marca));
            CreateMap<ProdutoViewModel, Produto>()
                .ConstructUsing(c => new Produto(c.Nome, c.Marca, c.PrecoCusto, c.PrecoVenda));
        }
    }
}