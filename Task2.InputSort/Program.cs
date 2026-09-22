using System;

class Program
{
    static void Main()
    {

        // количество элементов N с проверкой
        int n;
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            string input = Console.ReadLine();

            try
            {
                n = int.Parse(input);
                if (n > 0)
                    break;

                Console.WriteLine("Число должно быть больше 0. Попробуйте снова.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число. Попробуйте снова.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком большое. Попробуйте снова.");
            }
        }

        // вводим массив с клавиатуры
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Элемент [{i}]: ");
                string input = Console.ReadLine();

                try
                {
                    arr[i] = int.Parse(input);
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число. Попробуйте снова.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число слишком большое. Попробуйте снова.");
                }
            }
        }

        Console.WriteLine();

        Console.WriteLine("Исходный массив:  " + string.Join(", ", arr));

        // обратный порядок (выводим с конца, не изменяя массив)
        Console.Write("Обратный порядок: ");
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine();

        // сортировка через Array.Sort
        Array.Sort(arr);
        Console.WriteLine("Отсортированный:  " + string.Join(", ", arr));

        // максимум и минимум
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}