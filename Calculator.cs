public class Calculator
{
    public static void Main(string[] args)
    {
        IOperation SumOperation = new Sum();

        float Result = 0.0f;
        int Opcao = 0;
        float Numero1, Numero2;

        Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)\n");
        while (Opcao != 5)
        {
            Console.WriteLine("\nEscolha uma opção: \r\n1-Adição\r\n2-Subtração\r\n3-Multiplicação\r\n4-Divisão\r\n5-Sair\n");
            Opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o primeiro número: ");
            Numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número: ");
            Numero2 = float.Parse(Console.ReadLine());

            switch (Opcao) {
                case 1:
                    Result = SumOperation.DoOperation(Numero1, Numero2);
                    SumOperation.ShowResult(Numero1, Numero2, Result);
                break;
            }
        }

    }
}
