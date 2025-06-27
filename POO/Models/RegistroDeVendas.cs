public class RegistroDeVendas
{
    private int totalDeVendas;

    public void AdicionarVenda(int valor)
    {
        totalDeVendas += valor;
    }

    public int ObterTotal()
    {
        return totalDeVendas;
    }
}