// Define Variables for Data & Computation
using System.Transactions;

double PL, MT, FT, FG;
string[] Students = { "Gnosis", "Justyna", "Tachanka" };
int[] StudID = { 1, 2, 3 };

// Using a do-while in order for the Program to be repeated in case there is no record found
// when searching for the Students in the Student Records of the Array.

// Update: I will use while loop only.

while (true)
{
    // Defined Database of Students' Names
    string selectedStudent;
    string resultStudent = null;
    int resultStudID = -1;

    // Student Records Validation

    Console.WriteLine("======= Good Day! =======");
    Console.WriteLine("|| Enter Student Name  ||");
    Console.WriteLine("==    Input it below   ==");
    selectedStudent = Console.ReadLine();

    // Process for Records Validationp

    for (int i = 0; i < Students.Length; i++)
    {
        if (selectedStudent == Students[i])
        {
            resultStudent = selectedStudent;
            resultStudID = StudID[i]; break;
        }
    }

    if (resultStudent != null)
    {
        Console.WriteLine("\n\nStudent " + resultStudent + " found! Matched Records.");
        Console.WriteLine(resultStudent + " is Student ID No. " + resultStudID);
        Thread.Sleep(2000);

        Console.Clear();

        Console.WriteLine("============= Grades Evaluator ============");
        Console.WriteLine("You may now input the following Term Grades");
        Console.WriteLine("===========================================");
        Console.WriteLine("Enter PRELIM Grade below:");
        PL = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter MIDTERM Grade below:");
        MT = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter FINALTERM Grade below:");
        FT = double.Parse(Console.ReadLine());
        Console.WriteLine("\nCalculating...\n");
        Thread.Sleep(2000);

        /* This is where the fun begins  (COMPUTATION)
         
                                 PRELIM + MIDTERM + FINALTERM
               Final Grade  =   ------------------------------
                                              3
            
               Evaluation of Grade (Passed or Failed)
               Score is  75 and above means Passed, otherwise/below 75 is failed.

        */

        FG = (PL + MT + FT) / 3;

        Console.WriteLine(resultStudent + "'s Average Grade is " + FG);
        Thread.Sleep(1000);

        if (FG >= 75)
        {
            Console.WriteLine("To Evaluate the Grade, " + resultStudent + " has PASSED.\n");
        }
        else
        {
            Console.WriteLine("To Evaluate the Grade, " + resultStudent + " has FAILED.\n");
        }

        Console.WriteLine("Evaluation Complete. Exiting Program.");
        Thread.Sleep(3000);
        return;
    }
    else
    {
        Console.WriteLine(selectedStudent + " not found. Not in Records.");
        Console.WriteLine("Please re-input and try again...");
        Console.ReadKey();
        Console.Clear();
    }
}