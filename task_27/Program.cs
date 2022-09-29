//   Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

//   452 -> 11
//   82 -> 10
//   9012 -> 12


using static System.Console;
Clear();
WriteLine("Введите число: ");
int Num = Convert.ToInt32(ReadLine());
Write(NumberSum(Num));










int NumberSum(int Number)
{
int result=0;
int n=1;
int i=1;
while (Number%n!=Number)
{
    n=n*10;
    result=result+Number/(n/10)%10;
    i++;
}
return result;
}

