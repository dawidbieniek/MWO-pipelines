namespace App;

public class Calculator
{
    private float _a;
    private float _b;

    public Calculator(float a, float b)
    {
        _a = a;
        _b = b;
    }

    public float Add()
    {
        return _a + _b;
    }
}
