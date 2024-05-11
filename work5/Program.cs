namespace Nekit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Среднее арифметическое четырех чисел
            Console.WriteLine("Введите четыре числа для расчета среднего арифметического:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Среднее арифметическое чисел: " + average);

            // Задание 2: Выбор операции над двумя числами
            Console.WriteLine("Введите два числа для выполнения операций:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию: 1. Сложение 2. Вычитание 3. Умножение 4. Деление 5. Остаток");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Результат: {a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Результат: {a} * {b} = {a * b}");
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine($"Результат: {a} / {b} = {a / b}");
                    else
                        Console.WriteLine("Ошибка: деление на ноль.");
                    break;
                case 5:
                    Console.WriteLine($"Результат: {a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции. Попробуйте снова.");
                    break;
            }

            // Задание 3: Конвертация температур
            Console.WriteLine("Выберите исходную шкалу температур: 1. Цельсий 2. Кельвин 3. Фаренгейт");
            int scaleFrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите температуру:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите шкалу для конвертации: 1. Цельсий 2. Кельвин 3. Фаренгейт");
            int scaleTo = Convert.ToInt32(Console.ReadLine());

            ConvertTemperature(scaleFrom, scaleTo, temperature);

            // Задание 4: Извлечение имени файла из пути
            Console.WriteLine("Введите путь к файлу:");
            string path = Console.ReadLine();
            string fileName = path.Split(new char[] { '/', '\\' }).Last();
            Console.WriteLine("Имя файла: " + fileName);

            // Задание 5: Поиск самого длинного слова в предложении
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string longestWord = sentence.Split(' ').OrderByDescending(w => w.Length).First();
            Console.WriteLine($"Самое длинное слово: {longestWord}");

            // Задание 6: Поэлементное умножение элементов массивов
            double[] array1 = new double[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] array2 = new double[] { 0, 1, 2, 3, 4 };
            double[] results = new double[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                results[i] = array1[i] * (i < array2.Length ? array2[i] : 1);
            }
            Console.WriteLine("Результаты поэлементного умножения: " + string.Join(", ", results));

            // Задание 7: Нахождение максимального и минимального числа
            Console.WriteLine("Введите пять чисел (через пробел):");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length == 5)
            {
                Console.WriteLine("Максимальное число: " + numbers.Max());
                Console.WriteLine("Минимальное число: " + numbers.Min());
            }
            else
            {
                Console.WriteLine("Ошибка: Необходимо ввести ровно пять чисел.");
            }

            // Задание 8: Вывод ступеней
            Console.WriteLine("Введите количество ступеней:");
            if (int.TryParse(Console.ReadLine(), out int steps) && steps > 0)
            {
                for (int i = 1; i <= steps; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите положительное число.");
            }
        }

        static void ConvertTemperature(int from, int to, double temp)
        {
            double result;
            switch (from)
            {
                case 1: // Цельсий
                    if (to == 2) // К Кельвину
                    {
                        result = temp + 273.15;
                        Console.WriteLine("Цельсий > Кельвин: " + result);
                    }
                    else if (to == 3) // К Фаренгейту
                    {
                        result = (temp * 9 / 5) + 32;
                        Console.WriteLine("Цельсий > Фаренгейт: " + result);
                    }
                    else
                        Console.WriteLine("Цельсий > Цельсий: " + temp);
                    break;
                case 2: // Кельвин
                    if (to == 1) // К Цельсию
                    {
                        result = temp - 273.15;
                        Console.WriteLine("Кельвин > Цельсий: " + result);
                    }
                    else if (to == 3) // К Фаренгейту
                    {
                        result = (temp - 273.15) * 9 / 5 + 32;
                        Console.WriteLine("Кельвин > Фаренгейт: " + result);
                    }
                    else
                        Console.WriteLine("Кельвин > Кельвин: " + temp);
                    break;
                case 3: // Фаренгейт
                    if (to == 1) // К Цельсию
                    {
                        result = (temp - 32) * 5 / 9;
                        Console.WriteLine("Фаренгейт > Цельсий: " + result);
                    }
                    else if (to == 2) // К Кельвину
                    {
                        result = (temp - 32) * 5 / 9 + 273.15;
                        Console.WriteLine("Фаренгейт > Кельвин: " + result);
                    }
                    else
                        Console.WriteLine("Фаренгейт > Фаренгейт: " + temp);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор шкалы.");
                    break;
            }
        }
    }
}
