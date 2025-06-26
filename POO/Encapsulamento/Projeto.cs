
public class Projeto
{
    public string Nome { get; }
    private List<string> tarefas;

    public int QuantidadeTarefas => tarefas.Count;

    public Projeto(string nome)
    {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"{Nome}");
        Console.WriteLine($"Tarefas: ");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine(tarefa);
        }
        Console.WriteLine($"Total: {QuantidadeTarefas}");
    }
}
