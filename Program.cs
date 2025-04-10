double numero1 = 10;
double numero2 = 20;
double resultado = Somar(numero1, numero2);
Console.WriteLine($"A soma de {numero1} e {numero2} é: {resultado}");
Console.ReadLine();

static double Somar(double a, double b)
{
    return a + b;
}