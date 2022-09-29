//   Напишите метод, который принимает на вход два числа (A и B) и 
//   возводит число A в натуральную степень B с использованием цикла.

//   3, 5 -> 243 (3⁵)
//   2, 4 -> 16

using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int Num1 = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int Num2 = Convert.ToInt32(ReadLine());
Write($"{Num1} в натуральной степени {Num2} равно {NumDeg(Num1, Num2)}");





















//   Метод который принимает на вход два числа (A и B) и 
//   возводит число A в натуральную степень B с использованием цикла.

int NumDeg(int number1, int number2)
{
    int result = 1;
        for (int i = 1; i<= number2; i++)
        {
        result=result*number1;
        }
    return result;  
}

// int NumDeg(int number1, int number2)
// {
//     int result = 1;
//     int i = 1;
//        while ( i<= number2)
//         {
//         result=result*number1;
//         i++;
//         }
//     return result;  
// }
