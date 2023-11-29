// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива. 
int [] CreateArray (int min, int max, int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (min, max + 1);
    }
    return array;
}

void ShowArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} | ");
    }
    Console.WriteLine ();
} 

double [] ArrayMultiple (int [] array1, int [] array2)
{
    
        double [] multipled_array = new double [array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            multipled_array[i] = array1[i] + (array2[i]*0.01);
        }
    
    return multipled_array;
}

double CountDigit (double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    double res = max - min;
    return res;
}

int [] array1 = CreateArray(1, 99, 10);
int [] array2 = CreateArray(1, 99, array1.Length);
if(array1.Length == array2.Length)
{
       
    double [] resarray = ArrayMultiple(array1, array2);
    ShowArray (resarray);
    Console.WriteLine("Answer is " + CountDigit(resarray));

}
else
{
    Console.WriteLine("Incorrect Input!!");
}