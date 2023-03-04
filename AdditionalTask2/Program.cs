// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями 
// и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.
// [1,2,3,3] -> [1,2,3,4]

Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MakeValuesUniqueInArray(int[] array, int min, int max){
    for (int i = 0; i < array.Length - 1; i++){
        if (array[i] == array[i+1]) array[i+1] = new Random().Next(min, max+1);
    }
}

int[] CreateIntArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}

int minValue = Prompt("Введите минимальное значение чисел в массиве: ");
int maxValue = Prompt("Введите максимальное значение чисел в массиве: ");

int[] array = CreateIntArray(Prompt("Введите длину массива: "), minValue, maxValue);

PrintArray(array);
MakeValuesUniqueInArray(array, minValue, maxValue);
Console.WriteLine();
PrintArray(array);