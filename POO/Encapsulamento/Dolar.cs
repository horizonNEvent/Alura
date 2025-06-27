namespace Encapsulamento
{
    public class Dolar
    {
        double cotacaoDolar = 5.25;

        public double ConverterParaDolares(double valorReais)
        {
            return valorReais / cotacaoDolar;
        }
    }
}