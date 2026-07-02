using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string student = Console.ReadLine();

            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                total = total + marks[i];
            }

            double average = (double)total / 500 * 100;

            Console.WriteLine("\n===== GRADE REPORT =====");
            Console.WriteLine($"Student: {student}");
            Console.WriteLine($"Total Marks: {total}/500");
            Console.WriteLine($"Average: {average}%");

            if (average >= 80)
                Console.WriteLine("Grade: Distinction ");
            else if (average >= 60)
                Console.WriteLine("Grade: First Division");
            else if (average >= 40)
                Console.WriteLine("Grade: Pass ");
            else
                Console.WriteLine("Grade: Fail ");

            Console.WriteLine("========================");
        }
    }
}