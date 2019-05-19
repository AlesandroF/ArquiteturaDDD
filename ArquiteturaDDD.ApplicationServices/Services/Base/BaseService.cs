using ArquiteturaDDD.ApplicationServices.Interfaces.Base;
using ArquiteturaDDD.Domain.Entities.Base;
using ArquiteturaDDD.Infra.Data.Interfaces.Base;
using AutoMapper;

namespace ArquiteturaDDD.ApplicationServices.Services.Base
{
    public abstract class BaseService<T> : IBaseService where T : Entity
    {
        protected readonly IBaseRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IMapper mapper, IBaseRepository<T> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}