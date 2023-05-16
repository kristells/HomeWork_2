using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static int programmingScores = 80;
        static int mathGrades = 75;
        static int gradesPhysics = 77; 
        static void Main(string[] args)
        {
            string name = "Игнатьева Кристина Артемовна ";
            int age = 21;
            string emale = " kristells@mail.ru ";

            Console.WriteLine("Имя: " + name + " Возраст: " + age + " Emale: " + emale + " Баллы по программированию: " + 
                programmingScores + " Баллы по математике: " + mathGrades + " Баллы по физике: " + gradesPhysics);
            Console.ReadKey();
            Program.CalculationTotalPoint();
        }
        static void CalculationTotalPoint()
        {
            int totalPoints = programmingScores + mathGrades + gradesPhysics;
            int averageScore = totalPoints / 3;
            Console.WriteLine("Средний балл: " + averageScore);
            Console.ReadKey();
        }
    }
}
