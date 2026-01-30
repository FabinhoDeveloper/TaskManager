using TaskManager;
using System.Collections;

namespace TaskManager;
public class Program
{
    public static int ShowOptions()
    {
        Console.WriteLine("Digite sua opção: (1) -  Criar Task; (2) - Listar Tasks; (3) - Concluir Task; (0) - Sair;");
        
        if (int.TryParse(Console.ReadLine(), out int option))
        {
            return option;
        }

        return -1;
    }
    public static void Main()
    {
        TaskService taskService = new();

        while (true)
        {
            int option = ShowOptions();
            switch (option)
            {
                case 1:
                    Console.Write("Digite o título da task: ");
                    string Titulo = Console.ReadLine();

                    Console.Write("Digite a descrição da task: ");
                    string Descricao = Console.ReadLine();

                    taskService.CreateTask(Titulo, Descricao);

                    Console.WriteLine("Task inserida com sucesso!");
                    break;

                case 2:
                    List<TaskModel> listTasks = taskService.ListarTasks();

                    Console.WriteLine("""
                            =================================
                            Lista de Tasks 
                            =================================
                        """);
                    foreach (var t in listTasks)
                    {
                        Console.WriteLine($"Título: {t.Titulo}; Descrição: {t.Descricao}; Concluída: {t.Finalizada}");
                    }

                    break;

                case 3:
                    Console.Write("Digite o ID da task: ");
                    int idConcluir = int.Parse(Console.ReadLine());
                    taskService.ConcluirTask(idConcluir);
                    Console.WriteLine("Task concluída com sucesso!");
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}