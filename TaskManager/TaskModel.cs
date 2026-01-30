using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    internal class TaskModel(int Id, string Titulo, string Descricao)
    {
        public int Id = Id;
        public string Titulo = Titulo;
        public string Descricao = Descricao;
        public bool Finalizada { get; set; } = false;

        public void Concluir() 
        {
            this.Finalizada = true;
        }
    }
}
