// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

Console.WriteLine(
    "Please enter the temperature to check whether potato can be cooked in that tempeature"
);
int temperature = int.Parse(Console.ReadLine() ?? "");

if (temperature < 180)
{
    Console.WriteLine("Temperature is too cold to cook Potato");
}
else if (temperature >= 180 && temperature <= 220)
{
    Console.WriteLine("Temperature is Perfect to cook Potato");
}
else
{
    Console.WriteLine("Temperature is Too Hot to cook potato");
}

Console.WriteLine(
    "Please enter the temperature to check whether potato can be cooked in that tempeature"
);
int temperature1 = int.Parse(Console.ReadLine() ?? "");
string result =
    temperature1 < 180
        ? "Temperature is too cold to cook Potato"
        : (temperature1 >= 180 && temperature1 <= 220)
            ? "Temperature is Perfect to cook Potato"
            : "Temperature is Too Hot to cook potato";
Console.WriteLine(result);
int temperature2 = int.Parse(Console.ReadLine() ?? "");
switch (temperature2)
{
    case < 180:
    {
        Console.WriteLine("Temperature is too cold to cook Potato");
        break;
    }
    case > 220:
    {
        Console.WriteLine("Temperature is Too Hot to cook potato");
        break;
    }
    default:
        Console.WriteLine("Temperature is perfect to cook potato");
        break;
}

int temperature3 = int.Parse(Console.ReadLine() ?? "");

var result1 = temperature3 switch
{
    < 180 => "Temp is too cold",
    > 220 => "Temperature is too hot",
    _ => "Temperature is perfect",
};
Console.WriteLine(result1);
