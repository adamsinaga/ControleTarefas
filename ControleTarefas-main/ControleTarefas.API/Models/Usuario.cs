namespace ControleTarefas.API.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string? Login { get; set; }  
        public string? Senha { get; set; }
        public int TipoSenha { get; set; }
    }

}
