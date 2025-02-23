namespace TesteUBC.Domain.Contratos.Regras
{
    public interface IRegrasDeNegocio
    {
        string Codigo { get; }
        string Mensagem { get; }
        bool DeuRuim();
    }
}