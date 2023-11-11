namespace App;

public class Calculator(int a, int b)
{
	private int _a = a;
	private int _b = b;

	public int Add() => _a + _b;
}