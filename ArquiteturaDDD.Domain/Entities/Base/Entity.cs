using System;

namespace ArquiteturaDDD.Domain.Entities.Base
{
    public class Entity
    {
        public long Id { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public long CodigoUsuario { get; private set; }
    }
}