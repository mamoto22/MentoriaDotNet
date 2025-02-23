using TesteUBC.Domain.Contratos.Regras;
using TesteUBC.Domain.Excecoes;

namespace TesteUBC.Domain.Entity.Estudante.RegrasDeNegocio
{
    public class EstudanteRegrasDeNegocio(
        string nome,
        uint idade,
        uint serie,
        double notaMedia,
        string nomePai,
        string nomeMae,
        DateTimeOffset dataNascimento,
        string telefone) 
        : IRegrasDeNegocio
    {
        public string Codigo => MensagemDeErro.RegraDeNegocioInvalida("Estudante");
        public string Mensagem { get; private set; } = "Estudante inválido: ";

        private readonly string _nome = nome;
        private readonly uint _idade = idade;
        private readonly uint _serie = serie;
        private readonly double _notaMedia = notaMedia;
        private readonly string _nomePai = nomePai;
        private readonly string _nomeMae = nomeMae;
        private readonly DateTimeOffset _dataNascimento = dataNascimento;
        private readonly string _telefone = telefone;

        public bool DeuRuim()
        {
            if (NomeValido(_nome) &&
                IdadeValida(_idade) &&
                SerieValida(_serie) &&
                NotaMediaValida(_notaMedia) &&
                NomeValido(_nomeMae) &&
                NomeValido(_nomePai) &&
                DataNascimentoValida(_dataNascimento) &&
                TelefoneValido(_telefone))
                return false;
            
            if (!NomeValido(_nome))
                Mensagem += $" {MensagemDeErro.NomeInvalido}";

            if (!IdadeValida(_idade))
                Mensagem += $" {MensagemDeErro.IdadeInvalida}";

            if (!SerieValida(_serie))
                Mensagem += $" {MensagemDeErro.SerieInvalida}";

            if (!NotaMediaValida(_notaMedia))
                Mensagem += $" {MensagemDeErro.NotaMediaInvalida}";

            if (!NomeValido(_nomePai))
            Mensagem += $" {MensagemDeErro.NomePaiInvalido}";

            if (!NomeValido(_nomeMae))
                Mensagem += $" {MensagemDeErro.NomeMaeInvalido}";

            if (!DataNascimentoValida(_dataNascimento))
            Mensagem += $" {MensagemDeErro.DataNascimentoInvalida}";

            if (!TelefoneValido(_telefone))
                Mensagem += $" {MensagemDeErro.TelefoneInvalido}";

            return true;
        }

        private bool NomeValido(string nome)
            => !string.IsNullOrWhiteSpace(nome) && nome.Length is >= 5 and <= 50;
        
        private bool IdadeValida(uint idade)
            => idade >= 1 && idade <= 100;
        
        private bool SerieValida(uint serie)
            => serie >= 1 && serie <= 12;

        private bool NotaMediaValida(double notaMedia)
            => notaMedia >= 0 && notaMedia <= 100;
        
        private bool DataNascimentoValida(DateTimeOffset dataNascimento)
            => dataNascimento.Year >= 1900 && dataNascimento <= DateTimeOffset.UtcNow;
        
        private bool TelefoneValido(string telefone)
            => !string.IsNullOrWhiteSpace(telefone) && 
            telefone.Length == 10 && 
            telefone.All(char.IsDigit);
    }
}