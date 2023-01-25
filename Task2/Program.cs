// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!);

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Введенное число не является четвертью, нужно ввести число от 1 до 4, попробуйте снова");
}
else
{
    if (quarter < 3)
    {
        if (quarter == 1)
        {
            Console.WriteLine("Диапозон координат в первой четверти: x > 0, y > 0");
       }
        else
        {
            Console.WriteLine("Диапозон координат во второй четверти: x < 0, y > 0");
        }
    }
    else
    {
        if (quarter == 3)
        {
            Console.WriteLine("Диапозон координат в третьей четверти: x < 0, y < 0");
        }
        else
        {
            Console.WriteLine("Диапозон координат в четвертой четверти: x > 0, y < 0");
        }
    }
}