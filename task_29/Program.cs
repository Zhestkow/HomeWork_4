// Задача 29: Напишите метод, который формирует массив из 
// 8 случайных элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]


using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int Num = int.Parse(ReadLine()!);
int[] arrayNew = array(Num);
Print(arrayNew);











// Метод формирования массива

int[] array(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}




// Метод вывода

void Print(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}