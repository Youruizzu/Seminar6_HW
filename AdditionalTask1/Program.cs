// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, 
// или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShiftArray(int[] array, bool leftOrRight){
    // leftOfRight = true -> Shift to Left
    // leftOfRight = false -> Shift to Right
    int temp = 0;
    if (leftOrRight == true){
        for(int i = 0; i < array.Length-1; i++){
            temp = array[i];
            array[i] = array[i+1];
            array[i+1] = temp;
        }
    }
    else {
        for(int i = array.Length-1; i > 0; i--){
            temp = array[i];
            array[i] = array[i-1];
            array[i-1] = temp;
        }
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

int[] array = CreateIntArray(Prompt("Введите длину массива: "), 
                            Prompt("Введите минимальное значение чисел в массиве: "),
                            Prompt("Введите максимальное значение чисел в массиве: "));

PrintArray(array);
Console.WriteLine();
ShiftArray(array, true);
PrintArray(array);
Console.WriteLine();
ShiftArray(array, false);
ShiftArray(array, false);
PrintArray(array);