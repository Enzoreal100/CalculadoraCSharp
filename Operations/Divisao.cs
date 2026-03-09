public class Divisao : IOperation
{
    public float DoOperation(float a, float b)
    {
        return a / b;
    }

    public string ShowResult(float a, float b, float result)
    {
        return $"{a} / {b} = {result}";
    }
}