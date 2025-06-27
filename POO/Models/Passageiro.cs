public class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; set; }

    public Passageiro(string nome, int idade, int quantidadeBilhetes)
        : base(nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Bilhetes adquiridos: {QuantidadeBilhetes}");
        Console.WriteLine(new string('-', 30));
    }
}