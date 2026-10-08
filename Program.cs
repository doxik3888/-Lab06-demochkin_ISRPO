using System;
// for (int i =10; i>=1; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i =2; i<=50; i += 2)
// {
//     Console.WriteLine(i);
// }

// int a = 0;
// int s = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         a += i;
//     }
//     if (i % 7 == 0)
//     {
//         s++;
//     }
// }
// Console.WriteLine(a);
// Console.WriteLine(s);

// int number = Convert.ToInt32(Console.ReadLine());
// int chet = 0;
// int nechet = 0;

// while (number != 0)
// {
//     if (number % 2 == 0)
//     {
//         chet++;
//     }
//     else
//     {
//         nechet++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(chet);
// Console.WriteLine(nechet);

// string pasword;
// int i = 3;
// bool flag = false;
// do
// {
//     Console.WriteLine("Введите пароль: ");
//     pasword = Console.ReadLine();
//     i--;
//     if (pasword == "qwerty")
//     {
//         flag = true;
//     }
// }
// while (pasword != "qwerty" && i > 0);

// if (flag)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
// }

// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {

//     Console.WriteLine($"{num} x {i} = {num*i}"7);
// }

// for (int i = 1; i <= 30; i++)
// {
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     else if(i % 3 == 0)
//     {
//         continue;
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

int random = Random.Shared.Next(1, 100);
int a;
bool flag = false;
int s = 1;
for (int i = 1; i <= 5; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a == random)
    {
        flag = true;
        break;
    }
    else
    {
        if (random < a)
        {
            Console.WriteLine("Меньше");
        }
        else
        {
            Console.WriteLine("Больше");
        }
    }
    s++;
}
if (flag)
{
    Console.WriteLine($"Вы победили! Попыток:{s}");
}
else
{
    Console.WriteLine($"Вы проиграли, было число {random}");
}