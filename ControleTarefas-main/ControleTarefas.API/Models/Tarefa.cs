namespace ControleTarefas.API.Models
{
    public class Tarefa
    {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Descricao { get; set; }
            public StatusTarefa Status { get; set; }
            public int? UsuarioId { get; set; }
            public virtual Usuario? Usuario { get; set; }   
    }
}
