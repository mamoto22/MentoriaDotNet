namespace TesteUBC.Domain.Entity
{
    public sealed class Endereco
    {
        public Guid Id { get; private set; }
        public Guid EstudanteId { get; private set; }
        public string? Cep { get; private set; }
        public string? Rua { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cidade { get; private set; }
        public string? Uf { get; private set; }

        public Endereco(Guid id, Guid estudanteId, string cep, string rua, string bairro, string cidade, string uf)
        {
            Id = id;
            EstudanteId = estudanteId;
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco() { }
    }
}
