namespace TesteUBC.Domain.Entity
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset DataInclusao { get; set; }
        public DateTimeOffset DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
