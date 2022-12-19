// See https://aka.ms/new-console-template for more information
// int MaxNumber (int num)
// {
//     int a = num/10;
//     int b = num%10;
//     if (a>b)
//     {
//          return a;
//     }     
//     else
//     {
//         return b;
//     }

// }

// int randomNumber = new Random().Next(10,99+1);
// Console.WriteLine(randomNumber);

// int result = MaxNumber (randomNumber);
// Console.WriteLine(result);

// int DeleteNumber (int num)
// {
//     int sot = num/100;
//     int ed = num%10;
//     return sot*10 + ed;
// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);




// Console.WriteLine("************  Задача ************");

// Console.WriteLine(" Введите число N:  ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" Это число :  {a1} ");

// bool ctatnost(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool rez = ctatnost(a1);
// Console.WriteLine($" Число Делится  :  {rez} ");






// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine($" \n \r ************  Задача № 10 ************ \n \r");

Console.WriteLine(" Введите число :  ");
int nnn = Convert.ToInt32(Console.ReadLine());



int DeleteNumber(int num)
{
    int sot = num / 10;
    int ed = sot % 10;
    return ed;
}

if (nnn > 99 && nnn < 1000)
{
    int result = DeleteNumber(nnn);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine(" число не трехзначное ");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine($"\n \r************  Задача № 13 ************  \n \r");

Console.WriteLine(" Введите число :  ");
int nn = Convert.ToInt32(Console.ReadLine());

if (nn < 99)
{
    Console.WriteLine(" Нет третий цифры... ");
}
else
{
    while (nn > 999)
    {
        nn = nn / 10;
    }
    nn = nn % 10;
    Console.WriteLine($" третья цифра {nn}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine($"\n \r************  Задача № 15 ************ \n \r");

Console.WriteLine(" Введите число дня недели:  ");
int Dn = Convert.ToInt32(Console.ReadLine());

if (Dn > 0 && Dn < 8)
{
    if (Dn < 6)
    {
        Console.WriteLine(" Рабочий день:  ");
    }
    else
    {
        Console.WriteLine(" Выходной день:  ");
    }
}
else
{
    Console.WriteLine(" ДЕНЬ вышел за рамки недели !!! ");

}
