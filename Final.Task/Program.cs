using System;

class Program
{
    static void Main()
    {

        // Вариант 0. Успеваемость студентов

        string[] students = { "Анна", "Борис", "Виктор", "Галина" };
        int[] grades = { 85, 92, 78, 95 };

        // таблица «имя — баллы» 

        Console.WriteLine("Таблица успеваемости:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("| Имя     | Баллы       |");
        Console.WriteLine("-------------------------");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"| {students[i],-8}| {grades[i],-12}|");
        }
        Console.WriteLine("-------------------------");

        Console.WriteLine();

        // лучший студент 
        int maxGrade = grades[0];
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > maxGrade)
                maxGrade = grades[i];
        }

        int bestIndex = Array.IndexOf(grades, maxGrade);
        Console.WriteLine($"Лучший студент: {students[bestIndex]} ({maxGrade} баллов)");

        // средний балл
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        Console.WriteLine($"Средний балл группы: {average:F2}");
    }
}