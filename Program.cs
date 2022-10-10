//Задача 25. Напишите функцию, используя цикл, который пригимает на вход два числа(A и B), и возводит число A в степень B.

int Product(int _a, int _b)
{
    int _C = 1;
    for (int i = 1; i <= _b; i++)
    {
        _C = (_C * _a);
    }
    return _C;
}

int P = Product(2, 3);
Console.WriteLine($"{P}");



// Задача 27. Напишите программу, которая принимает на вход числои выдает сумму цифр в числе. 452 -> 11;

int A;
Console.Write("Введите Число: ");
int.TryParse(Console.ReadLine(), out A);
string str = A.ToString();
int[] array = new int[str.Length];
int Sum = 0;
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
    Sum = Sum + array[i];
}
Console.WriteLine($"{Sum}");


// Задача 29. Напишите функцию, которая задает массив из 8 элементов и выводит их на экран.

void FillArray(int[] Coll)
{
    int length = Coll.Length;
    int i = 0;
    while (i < length)
    {
        Coll[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] Collection)
{
    int count = Collection.Length;
    int j = 0;
    while (j < count)
    {
        Console.Write($"{Collection[j]}, ");
        j++;
    }
}

int[] Array1 = new int[8];
FillArray(Array1);
Console.Write("[");
PrintArray(Array1);
Console.Write("]");
