class Program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("------------------");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0")
            {
                continuar = false;
                continue;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            try
            {
                switch (opcao)
                {
                    case "1":
                        resultado = calculadora.Somar(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case "2":
                        resultado = calculadora.Subtrair(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case "3":
                        resultado = calculadora.Multiplicar(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case "4":
                        resultado = calculadora.Dividir(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
