using System;

namespace StudentGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maxPoints = { 10, 50, 30, 10 };
            int[] studentScores = new int[4];
            int totalScore = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Введите баллы за задание №{i + 1} (Максимум {maxPoints[i]} баллов): ");
                studentScores[i] = int.Parse(Console.ReadLine());
                totalScore += studentScores[i];
            }

            Console.WriteLine($"Общая сумма баллов: {totalScore}");
            Console.WriteLine($"Оценка по 5-бальной шкале: {GetGrade(totalScore)}");
        }

        static string GetGrade(int score)
        {
            if (score >= 70) return "5 (отлично)";
            if (score >= 40) return "4 (хорошо)";
            if (score >= 20) return "3 (удовлетворительно)";
            return "2 (неудовлетворительно)";
        }
    }
}
