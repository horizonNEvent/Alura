public class Certificado
{
    private Profissao profissao;

    public Certificado(Profissao profissao)
    {
        this.profissao = profissao;
    }

    public void Emitir()
    {
        Console.WriteLine($"Certificado emitido para: {profissao.Titulo}");
    }

}
