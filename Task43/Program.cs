// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 
// Вывод формулы:
// y = k1 * x + b1 => y = k1 * (y - b2)/k2 + b1 => y = (b1 + (-b2*k1/k2))/(1 - k1/k2)
// x = (y - b2)/k2
// или
// x = (b1 - b2) / (k2 - k1)
// y = k1 * x + b1

Console.Clear();

double Prompt(string message){
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] FindCrossPoint (double b1, double k1, double b2, double k2){
    // Уравнения прямых: y = k1 * x + b1, y = k2 * x + b2
    double[] coordinates = new double[2];

    if (k1 == k2) {
        Console.WriteLine("Прямые параллельны"); 
        coordinates[0] = -1;
        coordinates[1] = -1;
        return coordinates;
    }

    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    coordinates[0] = x;
    coordinates[1] = y;

    return coordinates;
}

double[] coordinates = FindCrossPoint(Prompt("Введите значение b1: "), 
                                    Prompt("Введите значение k1: "), 
                                    Prompt("Введите значение b2: "),
                                    Prompt("Введите значение k2: "));

Console.WriteLine($"Координаты точки пересечения прямых = ({coordinates[0]}, {coordinates[1]})");