namespace TesteUBC.Domain.Entity
{
    public class Usuario : BaseEntity
    {
        public string? NomeUsuario { get; private set; } 
        public string? Senha { get; private set; } 
        public Usuario(Guid id, DateTimeOffset datainclusao, DateTimeOffset dataAlteracao, bool ativo, string nomeUsuario, string senha ) 
        {
            Id = id;
            DataInclusao = datainclusao;
            DataAlteracao = dataAlteracao;
            Ativo = ativo;
            NomeUsuario = nomeUsuario;
            Senha = senha;  
        }
        public Usuario() { }
    }
}
