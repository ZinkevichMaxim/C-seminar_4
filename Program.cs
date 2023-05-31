// Является ли число палидроном

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int number = Convert.ToInt32(value);
//     return number;
// }

// int ReverseNumber(int a)
// {
//     int revNum = 0;
//     int temp = a; // 12321
//     while (temp > 0)
//     {
//         revNum = revNum * 10 + temp % 10; // 0 + 1 // 10 + 2 = 12 // 120 + 3=123 // 1230 + 2 //12320  +1 //12321
//         temp /= 10; // 1232 // 123 // 12 // 1 // 0 

//     }
//     return revNum;
// }

// int a = Prompt("Введите 5-и значное число: ");
// int reversed = ReverseNumber(a);

// if (a > 9999 && a < 1000000)
// {
//     if (reversed == a)
//     {
//         Console.WriteLine("Число является полиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ является полиндромом.");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }

// ***********************************************************************************************************************

Console.Clear();

// dotnet run
//**************************************************************************************************************************

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Clear();
// string mess = "Введите число: ";
// int num = Prompt(mess);
// //int summ = GetSumNums(num);
// Console.WriteLine($"Сумма равна = {GetSumNums(num)}");


// // int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int GetSumNums(int number)
// {
//     int sum = 0;

//     for (int i = 1; i <= number; i++)
//     {
//         sum = sum + i;
//         Console.Write(sum + " ");
//     }
//     return sum;
// }

// **************************************************************************************************************************


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// int Form()
// {
//     Console.WriteLine("Введите число:");
//     int count = Convert.ToInt32(Console.ReadLine());
//     return count;
// }
// void DigitInNumber(int number)
// {
//     int i = 0;
//     while (number > 0)
//     {
//         number /= 10;
//         i++;
//     }
//     Console.WriteLine("Количество цифр в числе = " + i);
// }

// DigitInNumber(Form());

//*****************************************************************************************************************

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// string mess = "Введите число: ";
// int num = Prompt(mess);
// int summ = GetSumNums(num);
// Console.WriteLine($"Сумма равна = {GetSumNums(num)}");


// int Prompt(string message)
// {
// Console.WriteLine(message);
// int number = int.Parse(Console.ReadLine());
// return number;
// }

// int GetSumNums(int number)
// {
// int sum = 1;

//      for (int i = 1; i <= number; i++)
// {
//          sum = sum * i;
//          Console.Write(sum + " ");
//      }
//      return sum;
//  }

//***********************************************************************************************************

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void RandomMassive(int val)
// {
//     // int [] array = new int [8];
//     int [] array = new int [val];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);  // генератор [a,b)
//         Console.Write (array[i]+" ");
//     }
// }


// int Prompt (string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     if ((int.TryParse(value, out int val)) == false)
//     {
//         Console.WriteLine("Это не число ");
//     }
//     return val;
// }
// int value = Prompt("Введите число ");
// RandomMassive(value);



