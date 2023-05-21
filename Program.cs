// Семинар 1
/*
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
*/
// ctrl + /(+ - это не клавиша, а одновременное нажатие ctrl и /)

// Ввод чисел
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n} + {m} = {n + m}");
// желтое выделение - это предупреждение
// красное выделение - это ошибка
// $"" - интерполяция строк


// Пользователь вводит 2 числа. Необходимо вывести наибольшее из них, в случае, если
// числа равны, то предупредить об этом пользователя
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// // Фигурные скобки({}) ставятся тогда, когда внутри блока условия/цикла выполняется более 1 строчке кода
// if (n > m)
//     Console.WriteLine(n);
// else if (n < m)
//     Console.WriteLine(m);
// else
//     Console.WriteLine(m);

// do-while, while, for(foreach)

// int i = 1;
// while (i < 10)
// {
//     Console.Write($"{i} ");
//     i++; // i = i + 1;
// }

// int i = 1;
// do{
//     Console.Write($"{i} ");
//     i++;
// }
// while (i < 10);

// For
// for (begin;condition;step)

// for(int i = 0; i < 10; i++)
//     Console.Write($"{i} ");

// Console.WriteLine();

// for(int i = 10; i > 0; i--)
//     Console.Write($"{i} ");

// Console.WriteLine();

// for(int i = 0; i < 10; i+=2)
//     Console.Write($"{i} ");

//Семинар 2

// Console.Clear();
// int number = new Random().Next(10, 100); // [10; 99]
// Console.WriteLine(number);
// int n1 = number / 10;
// int n2 = number % 10;
// // 1 == 2, 1 > 2, 1 < 2
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);

// Console.Clear();
// int number = new Random().Next(100, 1000); // [100; 999]
// Console.WriteLine(number);
// int n1 = number / 100;
// int n2 = number % 10;
// Console.Write (n1);
// Console.Write (n2);

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n % m == 0)
// Console.WriteLine("Кратно");
// else
// Console.WriteLine ($"Не кратно, остаток {n % m}");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 161 == 0) // n % 7 == 0 && n % 23 == 0
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n * n == m || m * m == n)
// Console.WriteLine("yes");
// else 
// Console.WriteLine("no");
