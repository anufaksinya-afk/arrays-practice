using System;

class Program
{
    public static int[] GetUnique(int[] source)
    {
        // массив-результат максимального размера
        int[] temp = new int[source.Length];
        int resultCount = 0;   

        // проверка каждого элемента массива
        for (int i = 0; i < source.Length; i++)
        {
            // встречался ли source в temp?
            bool alreadyExists = false;
            for (int j = 0; j < resultCount; j++)
            {
                if (temp[j] == source[i])
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                temp[resultCount] = source[i];
                resultCount++;
            }
        }

        // копируем в массив
        int[] result = new int[resultCount];
        for (int i = 0; i < resultCount; i++)
        {
            result[i] = temp[i];
        }
        return result;
    }

    static void Main()
    {

        // проверка
        int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };

        Console.WriteLine("Исходный:   " + string.Join(", ", source));

        int[] unique = GetUnique(source);
        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }
}
