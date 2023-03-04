// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++){
        array[i] = Prompt($"Введите {i}-е число массива: ");
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

void ShowNumbersHighterThanZeroInArray(int[] array){
    string numbersHighterThanZero = "Числа больше нуля: ";
    for(int i = 0; i < array.Length; i++){
        if(array[i]>0) numbersHighterThanZero += $"{array[i]} ";
    }
    Console.WriteLine(numbersHighterThanZero);
}

int[] array = CreateArray(Prompt("Введите размер массива: "));
PrintArray(array);
ShowNumbersHighterThanZeroInArray(array);