// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

Console.Clear();

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;
while (count <= number)
{
    double result = Math.Pow(count, 2);
    Console.Write(result);
    if (count != number)
    Console.Write(", ");
    count++;
}