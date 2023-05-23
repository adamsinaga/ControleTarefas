using System.ComponentModel;

namespace ControleTarefas.API.Models
{
    public enum StatusTarefa : int
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluída")]
        Concluida = 3
    }
}
