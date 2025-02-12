namespace TesteUBC.Domain.Entity
{
    public sealed class Estudante : BaseEntity
    {
        public string? Nome { get; private set; }
        public string? Idade { get; private set; }
        public string? Serie { get; private set; }
        public double NotaMedia { get; private set; }
        public string? NomePai { get; private set; }
        public string? NomeMae { get; private set; }
        public DateTimeOffset DataNascimento { get; private set; }
        public Endereco? Endereco { get; private set; }

        public Estudante(Guid id, DateTimeOffset datainclusao, DateTimeOffset dataAlteracao, bool ativo, string nome, string idade, string serie, double notaMedia, string nomePai, string nomeMae, DateTimeOffset dataNascimento, Endereco endereco)
        {
            Id = id;
            DataInclusao = datainclusao;
            DataAlteracao = dataAlteracao;
            Ativo = ativo;
            Nome = nome;
            Idade = idade;
            Serie = serie;
            NotaMedia = notaMedia;
            NomePai = nomePai;
            NomeMae = nomeMae;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public Estudante() { }
    }
}
