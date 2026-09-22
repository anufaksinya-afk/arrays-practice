using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // заполняю массив из 5 элементов
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            while (true)   
            {
                Console.Write($"Введите элемент [{i}]: ");
                string input = Console.ReadLine();

                try
                {
                    arr[i] = int.Parse(input);
                    break;  
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.WriteLine();

        // запрос с обработкой исключения
        while (true)
        {
            Console.Write($"Введите индекс для вывода (0-{arr.Length - 1}): ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Console.WriteLine($"Элемент [{index}] = {arr[index]}");
                break;  
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}
