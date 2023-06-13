namespace Blazor_Tarefas.Entidades{ 

    using System;
    public class Tarefa{
        public Guid id { get; set;}
        public string descricao { get; set;}
        public bool concluida { get; set;}
        public DateTime dataCriacao { get; set; }
    }
}