using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment05
{
    /**
     * Author name: Tetiana Reznychenko
     * Student number: 300870231
     * Description: This program is program to demonstrate understanding of File I/O and Exception Handling.
     * Date: 20 July, 2016 
     * Dame of modification: 22 July, 2016 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Try-Catch for cathing exceptions
            try
            {
                //main menu
                int menuchoice = 0;
                while (menuchoice != 2)
                {

                    Console.WriteLine("Choose your option");
                    Console.WriteLine();
                    Console.WriteLine("1. Display Grades");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine();

                    menuchoice = int.Parse(Console.ReadLine());

                    switch (menuchoice)
                    {
                        case 1:
                            const string FILENAME = "studentInfo.txt";
                            const char DELIM = ',';
                            string lastName;
                            string firstName;
                            string numberID;
                            string course;
                            string grade;

                            Console.WriteLine("Enter the file name: ");
                            string userFile = Convert.ToString(Console.ReadLine());
                            if (userFile == FILENAME)
                            {
                                // opening filestream
                                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                                StreamReader reader = new StreamReader(inFile); 

                                

                                    // setup variables to temporariliy hold my data
                                    string recordString;
                                string[] fields;

                                // read from file and assign the record to recordIN
                                recordString = reader.ReadLine();

                                while (recordString != null)
                                {

                                    fields = recordString.Split(DELIM);
                                    lastName = fields[0];
                                    firstName = fields[1];
                                    numberID = fields[2];
                                    course = fields[3];
                                    grade = fields[4];

                                    Console.WriteLine("Last Name", "Firs tName", "Firs tName", "ID#", "Class", "Grade");
                                    Console.WriteLine("{0} {1} {2} {3} {4}",
                                        lastName,
                                        firstName,
                                        numberID,
                                        course,
                                        grade);

                                    recordString = reader.ReadLine();

                                    // close streams
                                    reader.Close();
                                    inFile.Close();
                                }
                            }
                            else
                            {
                                Console.WriteLine("File does not exists");
                            }
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Sorry, invalid selection");
                            break;
                    }
                }

            }
            catch (Exception exception)
            {

                Console.WriteLine("Error: " + exception.Message);
            }
        }


    
                     
    }
}
