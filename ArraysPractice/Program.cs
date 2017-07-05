using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int[] myFirstArray;
            //Declare and initialize
            string[] myStringArray = { "first", "second", "third", "fourth" };
            //Declare and initialize a char array with letters of last name
            char[] lastName = { 'j', 'a', 'c', 'o', 'b', 's', 'o', 'n' };
            //I want my console to print 3 elements of array
            Console.WriteLine(lastName[0]);
            Console.WriteLine(lastName[3]);
            Console.WriteLine(lastName[1]);
            //Create the following arrays and print using correct index numbers:
            //Array of top 10 vacation spots, print first and last
            string[] vacationSpots = { "Mexico", "Florida", "Hawaii", "Italy", "Myrtle Beach", "Las Vegas", "Aruba", "New York", "London", "Bahamas" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);
            //Array of ages of 3 children, print each age
            int[] ages = { 4, 11, 9 };
            Console.WriteLine(ages[0]);
            Console.WriteLine(ages[1]);
            Console.WriteLine(ages[2]);

            Console.Write(ages[0] + " " + ages[1] + " " + ages[2]);  //Adding space will read int as string
            //Array of GPAs on a 4.0 scale for 8 students, don't print
            double[] gpa = { 2.0, 2.5, 2.7, 3.0, 3.2, 3.5, 3.8, 4.0 };
            //Array of first letter of 4 classmastes' names, print all on same line
            char[] firstLetter = { 'C', 'M', 'J', 'S' };
            Console.WriteLine("\n{0}, {1}, {2}, {3}", firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);

            //dataType[] nameOfArray = new dataType[#ofElements];
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];

            //nameofArray[index] = Element;
            studentsInClass[0] = "Jordan";

            Console.WriteLine("Please enter in the name of the next student.");
            studentsInClass[1] = Console.ReadLine();
            Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]); //To display input with placeholder

            //Ask user for input
            Console.WriteLine("Please enter the age of the person in the first seat.");
            //Create new int array with 21 spots
            int[] ageofStudentsInClass = new int[21];
            //Assign value of int at index 0 to user's input converted to int
            ageofStudentsInClass[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("The age of the student in the first seat is " + ageofStudentsInClass[0]); //To display input with concatenation
            //Create new string variable and set equal to int at index of 0, convert to string
            string firstIndex = ageofStudentsInClass[0].ToString();
        }
    }
}