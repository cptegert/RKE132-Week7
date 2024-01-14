Console.WriteLine("Valige teisendus:");
Console.WriteLine("1. Fahrenheit -> Celsius");
Console.WriteLine("2. Celsius -> Fahrenheit");
int choice = Int32.Parse(Console.ReadLine());


double temperature;
string result;

switch (choice)
{
    case 1:
        Console.WriteLine("Sisestage temperatuur Fahrenheitides:");
        temperature = Convert.ToDouble(Console.ReadLine());
        result = ConvertToCelsius(temperature);
        Console.WriteLine($"Temperatuur Celsiuse kraadides: {result}°C");
        break;

    case 2:
        Console.WriteLine("Sisestage temperatuur Celsiuse kraadides:");
        temperature = Convert.ToDouble(Console.ReadLine());
        result = ConvertToFahrenheit(temperature);
        Console.WriteLine($"Temperatuur Fahrenheitides: {result}°F");
        break;

    default:
        Console.WriteLine("Vale valik.");
        break;
}

static string ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    return celsius.ToString();
}

static string ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    return fahrenheit.ToString();
}