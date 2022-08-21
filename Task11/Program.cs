// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000); //10, 99 + 1
//  Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

//  int firstDigit = number / 100;
//  int secondDigit = number % 10;
//  int nov = firstDigit*10+secondDigit;
//  Console.WriteLine($"{number} => {nov} ");

// С помощью метода:

int number = new Random().Next(100, 1000); //10, 99 + 1
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int RemoveSecond(int num)
{
 int firstDigit = num / 100;
 int secondDigit = num % 10;
 int nov = firstDigit*10+secondDigit;
 Console.WriteLine($"{number} => {nov} ");
 return nov;
 }
 int result = RemoveSecond(number);
 Console.WriteLine($"{number} => {result} ");