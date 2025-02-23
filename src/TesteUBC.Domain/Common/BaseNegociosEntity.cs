using TesteUBC.Domain.Contratos.Regras;
using TesteUBC.Domain.Excecoes;

namespace TesteUBC.Domain.Common
{
    public abstract class BaseNegociosEntity
    {
        private readonly ICollection<IRegrasDeNegocio> _regras = [];

        protected void VerificaRegrasDeNegocio()
        {
            foreach (var regraDeNegocio in _regras)
            {
                if (regraDeNegocio.DeuRuim())
                    throw new ErroDeValidacaoDasRegrasDeNegocio(regraDeNegocio);
            }
        }

        protected void AdicionarRegra(IRegrasDeNegocio regra)
            => _regras.Add(regra);
    }
}