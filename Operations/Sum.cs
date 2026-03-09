using System;

public class Sum: IOperation
{
    float IOperation.DoOperation(float a, float b)
    {
        return a + b;
    }

    string IOperation.ShowResult(float a, float b, float result)
    {
        return $"\n{a} + {b} = {result}";
    }

}