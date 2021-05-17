using System;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 20. School
            RunTaskSchool();
        }

        static void RunTaskSchool()
        {
            Console.WriteLine("Task 20. School.\n");
            Console.WriteLine("Please, enter a number of students: ");
            int studentsCount = int.Parse(Console.ReadLine());
            School[] students = new School[studentsCount];
            double averageGridPoint = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine("Plase, enter a last name of student: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Plase, enter a first name of student: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Plase, enter an average score of student: ");
                double averageScore = double.Parse(Console.ReadLine());

                students[i] = new School(lastName, firstName, averageScore);
            }
            averageGridPoint = School.GetAverageScoreAllStudents(students);
            Console.WriteLine("{0:f2}", averageGridPoint);

            foreach (var student in students)
            {
                if (student.averageScore <= averageGridPoint)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }

    class School
    {
        static private int studentsCount;

        const int schoolNumber = 116;

        public double averageScore;
        private readonly string firstName;
        private readonly string lastName;

        static School()
        {
            Console.WriteLine($"Static constructor execution - {studentsCount}");
        }

        public School(string lastName, string firstName, double averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.averageScore = averageScore;
            Console.WriteLine($"Default constructor execution - {++studentsCount}");
        }

        public static double GetAverageScoreAllStudents(School[] students)
        {
            double scoreSummary = 0;
            foreach (var student in students)
            {
                scoreSummary += student.averageScore;
            }
            return scoreSummary * 1.0 / studentsCount;
        }

        public static void DisplayStudentsNumber()
        {
            Console.WriteLine(studentsCount);
        }

        public override string ToString()
        {
            return $"{lastName} {firstName} {averageScore}";
        }
    }
}
