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
// Console.WriteLine("8 times table using for");
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{i} * 8 = {i * 8}");
// }
// Console.WriteLine("8 times table using while");
// int j = 1;
// while (j <= 10)
// {
//     Console.WriteLine($"{j} * 8 = {j * 8}");
//     j++;
// }
// Console.WriteLine("8 times table using do while");
// int k = 1;
// do
// {
//     Console.WriteLine($"{k} * 8 = {k * 8}");
//     k++;
// } while (k <= 10);
// Console.WriteLine("8 times table using forEach");
// var tables = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// foreach (var item in tables)
// {
//     Console.WriteLine($"{item} * 8 = {item * 8}");
// }
//<<<<<------------------------Third Exercise---------------->
// void IncrementAges(int[] ages)
// {
//     for (var i = 0; i < ages.Length; i++)
//     {
//         ages[i]++;
//     }
// }

// var ages = new[] { 25, 30, 50 };
// IncrementAges(ages);
// Console.WriteLine(string.Join(", ", ages));

// Console.WriteLine("What is your age?");
// var response = Console.ReadLine();
// var responseIsValidNumber = int.TryParse(response, out var age);

// if (responseIsValidNumber)
// {
//     Console.WriteLine($"In 5 years, you will be {age + 5}.");
// }
// else
// {
//     Console.WriteLine($"Sorry, I didn't understand your response.");
// }
Animal? GetPetType()
{
    Console.WriteLine("What type of animal is your pet?");
    var response = Console.ReadLine() ?? "";
    Enum.TryParse(typeof(Animal), response, out var petType);
    Console.WriteLine(typeof(Animal));
    return (Animal?)petType;
}

Console.WriteLine("Welcome to the veterinary centre!");
Console.WriteLine(
    GetPetType() != null
        ? "Great, please come through."
        : "Sorry, we only work with dogs, cats and fish."
);

enum Animal
{
    Dog,
    Cat,
    Fish,
}
