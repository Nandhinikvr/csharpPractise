// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

// Console.WriteLine(
//     "Please enter the temperature to check whether potato can be cooked in that tempeature"
// );
// int temperature = int.Parse(Console.ReadLine() ?? "");

// if (temperature < 180)
// {
//     Console.WriteLine("Temperature is too cold to cook Potato");
// }
// else if (temperature >= 180 && temperature <= 220)
// {
//     Console.WriteLine("Temperature is Perfect to cook Potato");
// }
// else
// {
//     Console.WriteLine("Temperature is Too Hot to cook potato");
// }

// Console.WriteLine(
//     "Please enter the temperature to check whether potato can be cooked in that tempeature"
// );
// int temperature1 = int.Parse(Console.ReadLine() ?? "");
// string result =
//     temperature1 < 180
//         ? "Temperature is too cold to cook Potato"
//         : (temperature1 >= 180 && temperature1 <= 220)
//             ? "Temperature is Perfect to cook Potato"
//             : "Temperature is Too Hot to cook potato";
// Console.WriteLine(result);
// int temperature2 = int.Parse(Console.ReadLine() ?? "");
// switch (temperature2)
// {
//     case < 180:
//     {
//         Console.WriteLine("Temperature is too cold to cook Potato");
//         break;
//     }
//     case > 220:
//     {
//         Console.WriteLine("Temperature is Too Hot to cook potato");
//         break;
//     }
//     default:
//         Console.WriteLine("Temperature is perfect to cook potato");
//         break;
// }

// int temperature3 = int.Parse(Console.ReadLine() ?? "");

// var result1 = temperature3 switch
// {
//     < 180 => "Temp is too cold",
//     > 220 => "Temperature is too hot",
//     _ => "Temperature is perfect",
// };
// Console.WriteLine(result1);
//-----Second Exercise------------------//
Console.WriteLine("8 times table using for");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * 8 = {i * 8}");
}
Console.WriteLine("8 times table using while");
int j = 1;
while (j <= 10)
{
    Console.WriteLine($"{j} * 8 = {j * 8}");
    j++;
}
Console.WriteLine("8 times table using do while");
int k = 1;
do
{
    Console.WriteLine($"{k} * 8 = {k * 8}");
    k++;
} while (k <= 10);
Console.WriteLine("8 times table using forEach");
var tables = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (var item in tables)
{
    Console.WriteLine($"{item} * 8 = {item * 8}");
}
