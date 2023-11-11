using System.Reflection;

namespace App;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		var app = builder.Build();

		app.MapGet("/", () => $"Wersja: {Assembly.GetExecutingAssembly().GetName().Version!}");

		app.MapGet("/add", (HttpContext httpContext) =>
		{
			var a = httpContext.Request.Query["a"].ToString();
			var b = httpContext.Request.Query["b"].ToString();

			if (string.IsNullOrEmpty(a)) a = "0";
			if (string.IsNullOrEmpty(b)) b = "0";

			try
			{
				Calculator calculator = new(int.Parse(a), int.Parse(b));

				return Results.Text(calculator.Add().ToString(), "text/plain");
			}
			catch (Exception ex)
			{
				return Results.Text($"Error: {ex.Message}", "text/plain");
			}
		});

		app.Run();
	}
}