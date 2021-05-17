using System;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 20. School
            //RunTaskSchool();

            // Task 21. Belavia
            RunTaskBelavia();
        }

        private static void RunTaskBelavia()
        {
            Console.WriteLine("Task 21. Belavia.\n");
            Console.WriteLine("Please, enter a number of flights:");
            Belavia[] flights = new Belavia[int.Parse(Console.ReadLine())];

            for (int i = 0; i < flights.Length; i++)
            {
                Console.WriteLine("Plase, enter a flight destination:");
                string destination = Console.ReadLine();
                Console.WriteLine("Plase, enter a number of aircraft:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Plase, enter a type of aircraft:");
                string type = Console.ReadLine();

                flights[i] = new Belavia(destination, number, type);
            }
            Console.WriteLine("Plase, choose a flight type:");
            Belavia.DisplaySuitableByType(flights, Console.ReadLine());
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

    class Belavia
    {
        string destination;
        string aircraftType;
        int aircraftNumber;

        public Belavia(string destination, int aircraftNumber, string aircraftType)
        {
            this.destination = destination;
            this.aircraftNumber = aircraftNumber;
            this.aircraftType = aircraftType;
        }

        public static void DisplaySuitableByType(Belavia[] flightShedule, string aircraftType)
        {
            int flightsDisplayed = 0;

            foreach (var flight in flightShedule)
            {
                if (flight.aircraftType == aircraftType)
                {
                    flightsDisplayed++;
                    Console.WriteLine(flight);
                }
            }
            if (flightsDisplayed == 0)
            {
                Console.WriteLine("No flights detected.");
            }
        }

        public override string ToString()
        {
            return $"{destination} {aircraftNumber} {aircraftType}";
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
