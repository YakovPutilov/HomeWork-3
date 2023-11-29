//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться 
// на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.

int CountLength(int num)
{
    int count = 1;
    while (num / 10 > 0)
    {
        num = num / 10;
        count ++;
    }
    return count;
}
int [] CreateArray(int num, int size)
{

    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[size -1 - i] = num % 10;
        num = num / 10;
    }
    return array; 
}

void ShowArray(int [] array)
{
    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int leng = CountLength(number);
//Console.WriteLine(leng);
//Console.WriteLine(number);
//int [] resarray = CreateArray(number, leng);
ShowArray(CreateArray(number, leng));