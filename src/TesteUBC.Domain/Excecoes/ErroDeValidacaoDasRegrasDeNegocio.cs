using TesteUBC.Domain.Contratos.Regras;

namespace TesteUBC.Domain.Excecoes
{
    internal class ErroDeValidacaoDasRegrasDeNegocio(IRegrasDeNegocio regrasDeNegocio)
        : Exception(regrasDeNegocio.Mensagem)
    { }
}