using Lesson_20;

//1) Метод получает на вход 3 числа (A, B и С). Верните решение (значение X) линейного уравнения стандартного вида, где A*X+B=C.
Console.WriteLine();
Console.WriteLine("1.Метод получает на вход 3 числа (A, B и С). Дано линейное уравнение стандартного вида: 'A*X + B = C'. Найдём 'X':");
Console.WriteLine();
Console.Write("Введите число 'A' (отличное от 0): ");
double a = Calculator.ReadFromConsole();
Console.WriteLine();
Console.Write("Введите число 'B': ");
double b = Calculator.ReadFromConsole();
Console.WriteLine();
Console.Write("Введите число 'C': ");
double c = Calculator.ReadFromConsole();
Console.WriteLine();
double x = Calculator.FindAndWriteX(a, b, c);
Console.WriteLine();

//2) Метод получает на вход 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.
Console.WriteLine();
Console.WriteLine("2.Метод получает на вход 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.");
Console.WriteLine();
Console.Write("Введите первое число: ");
double n1 = Calculator.ReadNumbersFromConsole();
Console.WriteLine();
Console.Write("Введите второе число: ");
double n2 = Calculator.ReadNumbersFromConsole();
Console.WriteLine();
double result = Calculator.Compare(n1, n2);
Console.WriteLine();

//3) Метод получает на вход двузначное число. Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
Console.WriteLine();
Console.WriteLine("3.Метод получает на вход двузначное число. Верните прописную запись этого числа.");
Console.WriteLine();
Console.Write("Введите двузначное число: ");
int n = Calculator.ReadNumberFromConsole();
Calculator.CheckAndWriteNumber(n);
Console.WriteLine();

//4) Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
Console.WriteLine();
Console.WriteLine("4.Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50.");
Console.WriteLine();
Console.Write("Введите число: ");
double d = Calculator.ReadNumber();
Console.WriteLine();
bool range = Calculator.CheckNumber(d);
Console.WriteLine();
Console.WriteLine($"{range}.");
Console.WriteLine();

//5) Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("5.Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.");
Console.WriteLine();
Console.Write("Введите первое целое число: ");
int number1 = Calculator.ReadNumbers();
Console.WriteLine();
Console.Write("Введите второе целое число: ");
int number2 = Calculator.ReadNumbers();
Console.WriteLine();
Calculator.CheckAndAddNumbers(number1, number2);
Console.WriteLine();

//6) Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.
Console.WriteLine();
Console.WriteLine("6.Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.");
Console.WriteLine();
Console.Write("Введите целое положительное число: ");
int Np = Calculator.ReadFibonachi();
Console.WriteLine();
Calculator.FindFibonachiValue(Np);
Console.WriteLine();

//7) Метод получает на вход число. Найти количество нечетных цифр этого числа.
Console.WriteLine();
Console.WriteLine("7.Метод получает на вход число. Найти количество нечетных цифр этого числа.");
Console.WriteLine();
Console.Write("Введите целое положительное число: ");
int valueNumber = Calculator.ReadNumericFromConsole();
Console.WriteLine();
Calculator.FindOdd(valueNumber);
Console.WriteLine();

//8) Метод получает на вход число. Найти число, которое является зеркальным.
Console.WriteLine();
Console.WriteLine("8.Метод получает на вход число. Найти число, которое является зеркальным.");
Console.WriteLine();
Console.Write("Введите целое положительное число: ");
int SE = Calculator.ReadNumeric();
Console.WriteLine();
Calculator.ReverseNumeric(SE);
Console.WriteLine();

//9) Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
Console.WriteLine();
Console.WriteLine("9.Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры?");
Console.WriteLine();
Console.Write("Введите первое целое число: ");
int firstNumber = Calculator.Read();
Console.WriteLine();
Console.Write("Введите второе целое число: ");
int secondNumber = Calculator.Read();
Console.WriteLine();
bool answer = Calculator.CompareNumbers(firstNumber, secondNumber);
Console.WriteLine($"{answer}.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Конец!");