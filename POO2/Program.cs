// Imposto
// ICMS - 10%
// IPI - 5%
// PIS - 3%
// Confins 


double valor = 10;
IImposto[] imposto = new IImposto[]
{
    new ICMS(),
    new IPI(),
    new PIS(),
    new Confins()
};
double totalDeImpostos = CalcularTotalDeImpostos(valor, imposto);
Console.WriteLine($"Valor: {valor}");
Console.WriteLine($"Impostos: {totalDeImpostos}");
Console.ReadLine();

double CalcularTotalDeImpostos(double valor, IImposto[] calculadores)
{
    double total = 0;
    foreach (var calculadora in calculadores)
    {
        total += calculadora.Calcular(valor);
    }
    return total;
}
interface IImposto
{

    double Porcentagem { get;}
    public double Calcular(double valor)
    {
        return valor * this.Porcentagem;
    }

}

class ICMS : IImposto
{
    public double Porcentagem => 0.1;
}  
class IPI : IImposto
{
        public double Porcentagem => 0.05;

    }

class PIS : IImposto
{
        public double Porcentagem => 0.03;


    }

class Confins : IImposto
{
        public double Porcentagem => 0.03;

 }


