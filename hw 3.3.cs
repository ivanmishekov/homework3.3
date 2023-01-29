/*
Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

double number = InputInt("Введите число");

for (int result = 1; result <= number; result++)
{
    Console.Write($"{Math.Pow(result, 3)}, ");
}

double InputInt(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue); 
    return result;
}