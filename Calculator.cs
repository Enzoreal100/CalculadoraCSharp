public class Calculator
{
    public static void Main(string[] args)
    {
        IOperation sumOperation = new Sum();
        IOperation subtractionOperation = new Subtraction();
        IOperation multiplicationOperation = new Multiplication();
        IOperation divisaoOperation = new Divisao();

        float result;
        int opcao = 0;
        float numero1, numero2;

        Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)\n");
        while (opcao != 5)
        {
            Console.WriteLine("\nEscolha uma opção: \r\n1-Adição\r\n2-Subtração\r\n3-Multiplicação\r\n4-Divisão\r\n5-Sair\n");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("\nErro: Opção inválida. Por favor, insira um número.");
                continue;
            }

            if (opcao == 5)
                break;
            else if (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            Console.WriteLine("\nDigite o primeiro número: ");
            if (!float.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("\nErro: Entrada inválida. Por favor, insira um número.");
                continue;
            }
            Console.WriteLine("\nDigite o segundo número: ");
            if (!float.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("\nErro: Entrada inválida. Por favor, insira um número.");
                continue;
            }

            switch (opcao) {
                case 1:
                    result = sumOperation.DoOperation(numero1, numero2);
                    Console.WriteLine(sumOperation.ShowResult(numero1, numero2, result));
                break;
                case 2:
                    result = subtractionOperation.DoOperation(numero1, numero2);
                    Console.WriteLine(subtractionOperation.ShowResult(numero1, numero2, result));
                break;
                case 3:
                    result = multiplicationOperation.DoOperation(numero1, numero2);
                    Console.WriteLine(multiplicationOperation.ShowResult(numero1, numero2, result));
                break;
                case 4:
                    result = divisaoOperation.DoOperation(numero1, numero2);
                    Console.WriteLine(divisaoOperation.ShowResult(numero1, numero2, result));
                break;
            }
        }

    }
}
