// See https://aka.ms/new-console-template for more information

// Welcome Message
using System.IO.Pipes;

Console.WriteLine("************ Welcome to the sample calculator **************");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options
Console.WriteLine("Please select an operation:");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (x)");
Console.WriteLine("4. Division (/)");
int choice = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option
//if(choice == 1)
//{
//    /* do addition */
//    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//}
//else if(choice == 2)
//{
//    /* do subtraction */
//    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

//}
//else if (choice == 3)
//{
//    /* do multiplication */
//    Console.WriteLine($"{num1} X {num2} = {num1 * num2}");

//}
//else if (choice == 4)
//{
//    /* do division */
//    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

//}
//else
//{
//    Console.WriteLine("Invalid choice, please restart.");
//}
/* Switch statement */
int answer = 0;
switch (choice)
{
    case 1:
        /* do addition */
        answer = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case 2:
        /* do subtraction */
        answer = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case 3:
        /* do multiplication */
        answer = num1 * num2;
        Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
        break;
    case 4:
        /* do division */
        answer = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Invalid choice, please restart.");
        break;
}

// print output
Console.WriteLine($"The result is: {answer}");

