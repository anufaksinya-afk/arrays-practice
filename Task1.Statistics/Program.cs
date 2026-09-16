using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Создаём массив из 10 случайных чисел в диапазоне [1, 100]
        Random rnd = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101);  // 101 — верхняя граница НЕ включается
        }

        // Выводим массив в одну строку через string.Join
        Console.WriteLine("Массив: " + string.Join(", ", numbers));

        // Считаем сумму и произведение
        int sum = 0;
        long product = 1;   // long — потому что произведение быстро растёт
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];
        }
        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product);

        // Считаем чётные числа
        int evenCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                evenCount++;
        }
        Console.WriteLine("Чётных чисел: " + evenCount);

        // Считаем числа, большие среднего арифметического
        double average = (double)sum / numbers.Length;
        int aboveAvg = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
                aboveAvg++;
        }
        Console.WriteLine($"Больше среднего ({average:F1}): {aboveAvg}");
    }
}
