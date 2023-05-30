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

// **Task 1**

// Console.Clear();
// Console.Write("Введите 1 число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2 число: ");
// int b = int.Parse(Console.ReadLine()!);
// // == - проверка на равенство
// // = - присвоение значения
// // != - проверка на неравенство
// // >= or <=
// // => or =< - ERROR
// if (b * b == a)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");

// **Task 3**

// Console.Clear();
// Console.Write("Введите номер дня недели: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблиись!\nВведите номер дня недели: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");
// else if (n == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");

// **Task 5**

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write($"{i} ");

// Task 7

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n % 10);


// **Теория**

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n > 99 || n < 1000);
// //                   0    +     1   = 1(True)     

// // || - или(дизъюнкция) - +
// // && - и(конъюкция) - *
// if (n % 3 == 0 && n % 7 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// **Demo Task # 2**

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

// **Task 11**

// Console.Clear();
// int number = new Random().Next(100, 1000); // [100; 999]
// Console.WriteLine(number);
// Console.WriteLine(number / 100 * 10 + number % 100);

// **Task 12**

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n % m == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"no, ostatok {n % m}");

// **Task 14**


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 161 == 0) // n % 7 == 0 && n % 23 == 0
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// **Task 16**

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n * n == m || m * m == n)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// // **Теория(Char)**

// // "String"
// // 'String'
// // char s = 'f';
// // string stroka = "5";
// // //               0123456789...
// // Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 5);

// // string -> int (+)
// // char -> int (-) (utf-8)
// // char -> string -> int

// // 2145235 = 2 + 1 + 4 + 5 + 2 + 3 + 5 = 22
// // -2147000000 < int < 2147000000

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// int summa = 0;
// for (int i = 0; i < number.Length; i++)
//     summa = summa + Convert.ToInt32(number[i].ToString());
// Console.WriteLine(summa);
// ```

// // **Demo Task # 3**

// Console.Clear();
// Console.Write("Введите координату Х: ");
// double x = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y: ");
// double y = Double.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");
// ```

// // **Задача 18**

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// double x = Double.Parse(Console.ReadLine()!);
// while (x < 1 || x > 4)
// {
//     Console.Write("Вы ошиблись!\nВведите номер четверти: ");
//     x = Double.Parse(Console.ReadLine()!);
// }
// if (x == 1)
//     Console.WriteLine("x > 0 && y > 0");
// else if (x == 2)
//     Console.WriteLine("x < 0 && y > 0");
// else if (x == 3)
//     Console.WriteLine("x < 0 && y < 0");
// else
//     Console.WriteLine("x > 0 && y < 0");
// ```

// // **Задача 21**

// Console.Clear();
// Console.Write("Координату X(1): ");
// double x1 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Y(1): ");
// double y1 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату X(2): ");
// double x2 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Y(2): ");
// double y2 = double.Parse(Console.ReadLine()!);
// double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine($"Расстояние равно {Math.Round(S, 3)}");
// // pow - возведение в степень
// // round - округление числа
// // sqrt - квадратный корень числа
// ```

// // **Задача 22**

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n); // Модуль числа
// for (int i = 1; i <= n; i++)
//     Console.Write($"{i * i} ");
// ```

// // **Теория(array)**

// // array
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n]; // Массив по умолчанию(числовой) заполняется нулями
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1; 10]
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
// ```

// // **Задача 24**

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма от 1 до {n}: {((n + 1) / 2.0) * n}");
// ```

// // **Задача 26**

// ```csharp
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0, m = n;
// while (n > 0)
// {
//     n = n / 10;
//     count++;
// }
// Console.WriteLine($"В числе {m} {count} цифр");
// ```

// // **Задача 28**

// ```csharp
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 1;
// for (int i = 2; i <= n; i++)
//     result *= i;
// Console.WriteLine($"{n}! = {result}");
// ```

// // **Задача 30**

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2);
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");