using System;

namespace ArquiteturaDDD.Domain.Entities.Base
{
    public class Entity
    {
        public long Id { get; protected set; }
        public DateTime DataInclusao { get; protected set; }
        public DateTime DataAlteracao { get; protected set; }
        public long CodigoUsuario { get; protected set; }

        protected long SetCodigoUsuario(long codigoUsuario)
        {
            if (codigoUsuario > 1) return codigoUsuario;
            return 0;
        }

        protected DateTime SetDataInclusao(DateTime dataInclusao)
        {
            if (dataInclusao == default(DateTime)) return DateTime.Now;
            return dataInclusao;
        }

        protected DateTime SetDataAlteracao(DateTime dataAlteracao)
        {
            if (dataAlteracao == default(DateTime)) return DateTime.Now;
            return dataAlteracao;
        }
    }
}