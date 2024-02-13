// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 times

// 0,1,2,3,4,5,6,7,8,9

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}

//Console.WriteLine("Loop Completed");

// Ask User how many times they wish to print hello world and do so accordingly

//Console.Write("How many times would you like to run the print command? ");
//int end = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < end; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}

//Console.WriteLine("Loop Completed");

// While Loop

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello, World! - {counter}");
//    counter++;
//}

// Ask the user for a number and find the total for each number that is entered. Print
// final sum when the user enters -1 to exit

//int num = 0;
//int sum = 0;
//while (num != -1)
//{
//    sum += num;
//    Console.Write("Enter a number to sum (-1 to end): ");
//    num = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine($"Summation is: {sum}");

int num = 0;
int sum = 0;
do
{
    sum += num;
    Console.Write("Enter a number to sum (-1 to end): ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num != -1);

Console.WriteLine($"The summation is: {sum}");
