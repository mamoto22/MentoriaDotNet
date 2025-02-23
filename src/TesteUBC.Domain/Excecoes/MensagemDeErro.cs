namespace TesteUBC.Domain.Excecoes
{
    public static class MensagemDeErro
    {
        public static string RegraDeNegocioInvalida(string entityName) 
            => $"{entityName.ToUpper()}_REGRA_DE_NEGOCIO_INVALIDA.";

        public const string NomeInvalido = "Nome deve ter no mínimo de 3 caracteres e no máximo de 50 caracteres.";
        public const string IdadeInvalida = "Idade deve ser um número inteiro entre 1 e 100.";
        public const string SerieInvalida = "Série deve ser um número inteiro entre 1 e 12.";
        public const string NotaMediaInvalida = "Nota média deve ser um número decimal entre 0 e 100.";
        public const string NomePaiInvalido = "Nome do Pai deve ter no mínimo de 3 caracteres e no máximo de 50 caracteres.";
        public const string NomeMaeInvalido = "Nome da Mãe deve ter no mínimo de 3 caracteres e no máximo de 50 caracteres.";
        public const string DataNascimentoInvalida = "Data de Nascimento inválida.";
        public const string TelefoneInvalido = "Telefone inválido. Deve conter 10 caracteres.";
    }
}