using System;

namespace ArquiteturaDDD.Domain.Builders.Base
{
    public abstract class BaseBuilder
    {
        public DateTime DataInclusao { get; protected set; }
        public DateTime DataAlteracao { get; protected set; }
        public long CodigoUsuario { get; protected set; }
        public long Id { get; protected set; }
    }
}   