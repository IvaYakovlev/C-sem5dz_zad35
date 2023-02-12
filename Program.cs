// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5

Console.Clear();
int a = 123;
int b = 0;
int c = 1000;
int [] massiv = GetRandomArray (a, b, c);
Console.WriteLine ($"Массив случайных чисел [{String.Join (", ", massiv)}]");
int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}




int result = comparsion (massiv);

Console.WriteLine ($"количество цифр в диапазоне {result}");


int comparsion (int [] a){
int count = 0;
for (int i = 0; i<a.Length; i++)
{
   
    if (a[i]>10 && a[i]<99){
        count+=1;
    }

}
return count;
}



