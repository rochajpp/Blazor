using System.Collections.Generic;
using Blazor_Tarefas.Entidades;
using System;

namespace Blazor_Tarefas.Repositorios{

    public class Repositorio : IRepositorio{
        
        public List<Tarefa> ObterTarefas(){
            
            return new List<Tarefa>(){
                new Tarefa{
                    id = new Guid("f0dcda47-1f23-4538-92e0-a47dcdcc7850"),
                    descricao = "Fazer o curso de Blazor",
                    concluida = false,
                    dataCriacao = Convert.ToDateTime("2019-08-11")
                },
                new Tarefa{
                    id = new Guid("d21b0f7e-a5a9-45ee-ad9b-eafd911e22fa"),
                    descricao = "Estudar Blazor",
                    concluida = false,
                    dataCriacao = Convert.ToDateTime("2019-09-05")
                }
            };

        }

    }

}