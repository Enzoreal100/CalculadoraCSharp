public class Divisao : IOperation
{
    public float DoOperation(float a, float b)
    {
        if (b == 0)
        {
            // Retorna um valor que indica "Erro de Cálculo" em floats
            return float.NaN;
        }

        return a / b;
    }

    public string ShowResult(float a, float b, float result)
    {
        // Verifica se o resultado é um número inválido (divisão por zero)
        if (float.IsNaN(result) || b == 0)
        {
            return "Erro: Não é possível dividir por zero.";
        }

        return $"{a} / {b} = {result}";
    }
}