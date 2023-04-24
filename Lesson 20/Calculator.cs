namespace Lesson_20
{
    public static class Calculator
    {
        //1) Метод получает на вход 3 числа (A, B и С). Верните решение (значение X) линейного уравнения стандартного вида, где A*X+B=C.    
        public static double ReadFromConsole()
        {
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write(";");
            return number;
        }
        public static double FindAndWriteX(double a, double b, double c)
        {
            double x = (c - b) / a;
            Console.WriteLine($"Ответ: X = {x}.");
            Console.WriteLine();
            return x;
        }

        //2) Метод получает на вход 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.  
        public static double ReadNumbersFromConsole()
        {
            double numbers = Convert.ToDouble(Console.ReadLine());
            Console.Write(";");
            return numbers;
        }
        public static double Compare(double n1, double n2)
        {
            double result = 0;
            if (n1 > n2)
            {
                result = n1 + n2;
                Console.WriteLine();
                Console.WriteLine($"Первое число больше второго числа.");
                Console.WriteLine();
            }
            if (n1 == n2)
            {
                result = n1 * n2;
                Console.WriteLine();
                Console.WriteLine($"Первое число равно второму числу.");
                Console.WriteLine();
            }
            if (n1 < n2)
            {
                result = n1 - n2;
                Console.WriteLine();
                Console.WriteLine($"Первое число меньше второго числа.");
                Console.WriteLine();
            }
            Console.WriteLine($"Результат соответствующей операции: {result}.");
            Console.WriteLine();
            return result;
        }

        //3) Метод получает на вход двузначное число. Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.  
        public static int ReadNumberFromConsole()
        {
            int nRead = Convert.ToInt32(Console.ReadLine());
            return nRead;
        }
        public static int CheckAndWriteNumber(int n)
        {
            int nCheck = 0;
            while (n < 10 || n > 100)
            {
                Console.WriteLine();
                Console.Write("Введите двузначное число, которое больше нуля: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (n >= 10 & n < 100)
            {
                Console.WriteLine();
                Console.Write("Прописная запись этого числа: ");
                nCheck = n;
                {
                    int a = (n / 10) * 10;
                    int b = n % 10;

                    if (n > 10 && n < 20)
                    {
                        switch (n)
                        {
                            case 11:
                                Console.Write("'Одиннадцать'.");
                                break;

                            case 12:
                                Console.Write("'Двенадцать.");
                                break;

                            case 13:
                                Console.Write("'Тринадцать'.");
                                break;

                            case 14:
                                Console.Write("'Четырнадцать'.");
                                break;

                            case 15:
                                Console.Write("'Пятнадцать'.");
                                break;

                            case 16:
                                Console.Write("'Шестнадцать'.");
                                break;

                            case 17:
                                Console.Write("'Семнадцать'.");
                                break;

                            case 18:
                                Console.Write("'Восемнадцать'.");
                                break;

                            case 19:
                                Console.Write("'Девятнадцать'.");
                                break;
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        switch (a)
                        {
                            case 10:
                                Console.Write("'Десять'.");
                                break;

                            case 20:
                                Console.Write("'Двадцать" + " ");
                                break;

                            case 30:
                                Console.Write("'Тридцать" + " ");
                                break;

                            case 40:
                                Console.Write("'Сорок" + " ");
                                break;

                            case 50:
                                Console.Write("'Пятьдесят" + " ");
                                break;

                            case 60:
                                Console.Write("'Шестьдесят" + " ");
                                break;

                            case 70:
                                Console.Write("'Семьдесят" + " ");
                                break;

                            case 80:
                                Console.Write("'Восемьдесят" + " ");
                                break;

                            case 90:
                                Console.Write("'Девяносто" + " ");
                                break;
                        }
                        switch (b)
                        {
                            case 1:
                                Console.Write("один'.");
                                break;

                            case 2:
                                Console.Write("два'.");
                                break;

                            case 3:
                                Console.Write("три'.");
                                break;

                            case 4:
                                Console.Write("четыре'.");
                                break;

                            case 5:
                                Console.Write("пять'.");
                                break;

                            case 6:
                                Console.Write("шесть'.");
                                break;

                            case 7:
                                Console.Write("семь'.");
                                break;

                            case 8:
                                Console.Write("восемь'.");
                                break;

                            case 9:
                                Console.Write("девять'.");
                                break;
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            return nCheck;
        }

        //4) Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
        public static double ReadNumber()
        {
            double date = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("-");
            Console.WriteLine();
            return date;
        }
        public static bool CheckNumber(double d)
        {
            if (d >= 0 && d <= 10 || d >= 20 && d <= 30 || d >= 40 && d <= 50)
            {
                if (d >= 0 && d <= 10)
                {
                    Console.WriteLine("принадлежит диапазону от 0 до 10;");
                }

                else if (d >= 20 && d <= 30)
                {
                    Console.WriteLine("принадлежит диапазону от 20 до 30;");
                }

                else if (d >= 40 && d <= 50)
                {
                    Console.WriteLine("принадлежит диапазону от 40 до 50;");
                }
                return true;
            }
            else
            {
                Console.WriteLine("не попадает ни в один из указанных диапазонов.");
                return false;
            }
        }

        //5) Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
        public static int ReadNumbers()
        {
            int nn = Convert.ToInt32(Console.ReadLine());
            Console.Write(";");
            return nn;
        }
        public static int CheckAndAddNumbers(int number1, int number2)
        {
            int sum = 0;
            while (number1 == number2)
            {
                Console.WriteLine();
                Console.WriteLine("Введите разные числа.");
                Console.WriteLine();
                Console.Write("Введите первое целое число: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(";");
                Console.Write("Введите второе целое число, которое больше первого числа: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(";");
            }
            if (number1 != number2)
            {
                while ((number2 - number1) < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Числа не образуют диапазон. Второе число должно быть больше первого числа. Введите другие числа.");
                    Console.WriteLine();
                    Console.Write("Введите первое целое число: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(";");
                    Console.Write("Введите второе целое число, которое больше первого числа: ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(";");
                }
                while (Math.Abs(number2 - number1) < 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите другие числа.");
                    Console.WriteLine();
                    Console.Write("Введите первое целое число: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(";");
                    Console.Write("Введите второе целое число, которое больше первого числа не менее, чем на 7: ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(";");
                }
                for (int i = number1; i <= number2; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
                Console.WriteLine();
                Console.WriteLine("Сумма всех чисел, которые делятся на 7 без остатка, из диапазона от первого до второго числа равна" + " " + sum + ".");
                Console.WriteLine();
            }
            return sum;
        }

        //6) Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.
        public static int ReadFibonachi()
        {
            int fibonachi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("-");
            Console.WriteLine();
            return fibonachi;
        }
        public static int FindFibonachiValue(int Np)
        {
            int fb1 = 1;
            int fb2 = 1;
            int valueFb = 0;
            while (Np < 0)
            {
                Console.Write("Введите целое положительное число: ");
                Np = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-");
                Console.WriteLine();
            }

            if (Np == 1 || Np == 2)
            {
                Console.WriteLine("соответствует в ряду Фибоначчи числу " + 1 + ".");
                Console.WriteLine();
            }
            else
            {
                for (int i = 2; i < Np; i++)
                {
                    valueFb = fb1 + fb2;
                    fb1 = fb2;
                    fb2 = valueFb;
                }
                Console.WriteLine("соответствует в ряду Фибоначчи числу " + valueFb + ".");
                Console.WriteLine();
            }
            return valueFb;
        }

        //7) Метод получает на вход число. Найти количество нечетных цифр этого числа.
        public static int ReadNumericFromConsole()
        {
            int wholeNumber = Convert.ToInt32(Console.ReadLine());
            return wholeNumber;
        }
        public static int FindOdd(int valueNumber)
        {
            int odd = 0;

            while (valueNumber != 0)
            {
                int tmp = valueNumber % 10;
                valueNumber /= 10;
                if (tmp % 2 != 0)
                {
                    odd++;
                }
            }
            Console.WriteLine("Количество нечетных цифр введённого числа: " + odd + ".");
            Console.WriteLine();
            return odd;
        }

        //8) Метод получает на вход число. Найти число, которое является зеркальным.
        public static int ReadNumeric()
        {
            int numeric = Convert.ToInt32(Console.ReadLine());
            return numeric;
        }
        public static int ReverseNumeric(int SE)
        {
            string ESS = "";
            int ES = 0;
            while ((SE < 10) || (SE % 10 == 0))
            {
                Console.Write("Введите другое число, которое больше 10 и не заканчивается на нуль: ");
                SE = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (SE != 0)
            {
                ESS += SE % 10;
                SE /= 10;
            }
            ES = Convert.ToInt32(ESS);
            Console.WriteLine("Число, которое является зеркальным отображением последовательности цифр заданного числа: " + ES + ".");
            Console.WriteLine();
            return ES;
        }

        //9) Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
        public static int Read()
        {
            int numeric = Convert.ToInt32(Console.ReadLine());
            return numeric;
        }
        public static bool CompareNumbers(int firstNumber, int secondNumber)
        {
            string result1 = "ДА.";
            string result2 = "НЕТ.";
            bool answer;
            if (Math.Abs(firstNumber) == Math.Abs(secondNumber))
            {
                Console.WriteLine(result1);
                Console.WriteLine();
                answer = true;
            }
            else
            {
                int LED = 0;
                while (firstNumber != 0)
                {
                    int oneTemp = firstNumber % 10;
                    firstNumber /= 10;
                    int secondCopy = secondNumber;
                    while (secondCopy != 0)
                    {
                        int secondTemp = secondCopy % 10;
                        secondCopy /= 10;
                        if (Math.Abs(oneTemp) == Math.Abs(secondTemp))
                        {
                            LED++;
                            break;
                        }
                    }
                }
                if (LED > 0)
                {
                    Console.WriteLine(result1);
                    Console.WriteLine();
                    answer = true;
                }
                else
                {
                    Console.WriteLine(result2);
                    Console.WriteLine();
                    answer = false;
                }
            }
            return answer;
        }
    }
}
