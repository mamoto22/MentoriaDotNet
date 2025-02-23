using TesteUBC.Domain.Common;
using TesteUBC.Domain.Entity.Estudante.RegrasDeNegocio;
using TesteUBC.Domain.ValueObjects;

namespace TesteUBC.Domain.Entity.Estudante
{
    public sealed class Estudante : BaseEntity
    {
        public string? Nome { get; private set; }
        public uint Idade { get; private set; }
        public uint Serie { get; private set; }
        public double NotaMedia { get; private set; }
        public string? NomePai { get; private set; }
        public string? NomeMae { get; private set; }
        public DateTimeOffset DataNascimento { get; private set; }
        public Endereco? Endereco { get; private set; }
        public string? Telefone { get; private set; }

        public Estudante() { }

        public Estudante(
            Guid id, 
            DateTimeOffset dataInclusao, 
            DateTimeOffset dataAlteracao, 
            bool ativo, 
            string nome, 
            uint idade, 
            uint serie, 
            double notaMedia, 
            string nomePai, 
            string nomeMae, 
            DateTimeOffset 
            dataNascimento, 
            Endereco endereco,
            string telefone)
            : base(
                id, 
                dataInclusao, 
                dataAlteracao, 
                ativo)
        {
            Nome = nome;
            Idade = idade;
            Serie = serie;
            NotaMedia = notaMedia;
            NomePai = nomePai;
            NomeMae = nomeMae;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;

            AdicionarRegra(
                new EstudanteRegrasDeNegocio(
                    nome: nome,
                    idade: idade,
                    serie: serie,
                    notaMedia: notaMedia,
                    nomePai: nomePai,
                    nomeMae: nomeMae,
                    dataNascimento: dataNascimento,
                    telefone: Telefone)
                );
                
            VerificaRegrasDeNegocio();
        }
    }
}
