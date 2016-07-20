using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayMenu();
            int userInput = 0;
            do
            {
                if (userInput == 1)
                {

                }
            }
            while (userInput != 2);

            string lastName;
            string firstName;
            int numberID;
            string course;
            string grade;

            string myFile = "studentInfo.txt";

            if (File.Exists(myFile))
            {
                Console.WriteLine(File.GetCreationTime(myFile));
            }



        }

        static public int DisplayMenu()
        {
            Console.WriteLine("Choose your option");
            Console.WriteLine();
            Console.WriteLine("1. Display Grades");
            Console.WriteLine("2. Exit");
            Console.WriteLine();
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
