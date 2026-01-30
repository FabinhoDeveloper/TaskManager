using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskManager
{
    internal class TaskService
    {
        private readonly List<TaskModel> TaskList = [];

        public void CreateTask(string Titulo, string Descricao)
        {
            int currentId = this.TaskList.Count + 1;
            TaskModel t = new(currentId, Titulo, Descricao);
            TaskList.Add(t);
        }

        public void ConcluirTask(int Id)
        {
            TaskModel? task = this.TaskList.FirstOrDefault(t => t.Id == Id);
            task?.Concluir();
        }

        public List<TaskModel> ListarTasks()
        {
            return this.TaskList;
        }
    }
}
