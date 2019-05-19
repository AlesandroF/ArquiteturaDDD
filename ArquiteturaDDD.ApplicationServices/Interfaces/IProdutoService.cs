using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.Domain.Entities.Base;
using System.Collections.Generic;

namespace ArquiteturaDDD.ApplicationServices.Interfaces
{
    public interface IProdutoService
    {
        void Insert(ProdutoViewModel produto);
        IEnumerable<ProdutoViewModel> GetProdutos();
        ProdutoViewModel GetById(long? id);
        void Update(ProdutoViewModel produto);
        void Remove(long id);
    }
}