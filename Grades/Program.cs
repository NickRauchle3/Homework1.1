//Nicholas Rauchle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //clarifying variables
            string firstName;
            string lastName;
            int id;
            double quizzes;
            double homeworks;
            double midterm;
            double final;
            double participation;

            //Questions part
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Quizzes?");
            quizzes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Homeworks?");
            homeworks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Participations?");
            participation = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the Midterm?");
            midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the Final Exam?");
            final = Convert.ToDouble(Console.ReadLine());

            //Final Statement
            double FinalGrade;
            FinalGrade = (quizzes + homeworks + final + midterm + participation) / 5;
            Console.WriteLine(firstName + lastName + id + ", your final grade is " + FinalGrade);
            Console.ReadKey();
        }
    }
}
