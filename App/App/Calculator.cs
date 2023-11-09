namespace App;

public class Calculator
{
    private int _a;
    private int _b;

    public Calculator(int a, int b)
    {
        _a = a;
        _b = b;
    }

    public int Add()
    {
        return _a + _b;
    }
}
