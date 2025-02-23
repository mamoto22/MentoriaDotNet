namespace TesteUBC.Domain.Common
{
    public abstract class BaseEntity : BaseNegociosEntity
    {
        public Guid Id { get; protected set; }
        public DateTimeOffset DataInclusao { get; protected set; }
        public DateTimeOffset DataAlteracao { get; protected set; }
        public bool Ativo { get; protected set; }

        protected BaseEntity() { }

        protected BaseEntity(
            Guid id,
            DateTimeOffset dataInclusao,
            DateTimeOffset dataAlteracao,
            bool ativo = true)
        {
            Id = id;
            DataInclusao = dataInclusao;
            DataAlteracao = dataAlteracao;
            Ativo = ativo;
        }
    }
}
