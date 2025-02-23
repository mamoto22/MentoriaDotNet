namespace TesteUBC.Domain.ValueObjects
{
    public sealed class Endereco
    {
        public string? Cep { get; private set; }
        public string? Rua { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cidade { get; private set; }
        public string? Uf { get; private set; }

        public Endereco(
            string cep, 
            string rua, 
            string bairro, 
            string cidade, 
            string uf)
        {
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco() { }
    }
}