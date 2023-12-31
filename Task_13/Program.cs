﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Алгоритм: 
// 1. Задать число путем записи с терминала.
// 2. Написать вывод при отсутсвии третьей цифры.
// 3. Написать функцию поиска третьей цифры.
// 3. Вывести результат.


long Find(long num) // Функция по нахождению 3-го числа.
{
     if (num > 999)
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        return num;
}

Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

if (number > -100 && number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    long answer = Find(number);
    Console.WriteLine($"{number} -> {answer}");
}


//Более простое решение с поиском номера символа и выводом его.
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// int lenght = number.Length;
// int i = 2;
// if (lenght < 3)
// {
//     Console.WriteLine($"{number} -> третьей цифры нет");
// }
// else
// {
//     char answer = number[i];
//     Console.Write($"{number} -> {answer}");
//}



