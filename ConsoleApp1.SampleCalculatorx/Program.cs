// See https://aka.ms/new-console-template for more information

Console.WriteLine("************ Welcome to the sample calculator **************");

int choice = 0;
while (choice != -1)
{
    // Prompt for user input

    // Show calculator options
    Console.WriteLine("Please select an operation (-1 to exit):");
    Console.WriteLine("1. Addition (+)");
    Console.WriteLine("2. Subtraction (-)");
    Console.WriteLine("3. Multiplication (x)");
    Console.WriteLine("4. Division (/)");
    Console.WriteLine("5. Fibonacci sequence");
    choice = Convert.ToInt32(Console.ReadLine());
    
    // exit iteration, if choice is -1 so that numbers are not asked for again
    if (choice == -1) { continue; };
    Console.Write("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // Make sure accumulator is reset to zero
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
        case 5:
            /* do fibonacci */

            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            Console.WriteLine($"Fibonacci of {num1} to {num2} = {answer}");
            break;
        default:
            Console.WriteLine("Invalid choice, please restart.");
            break;
    }
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();
}

// print output
Console.WriteLine("Thank you for using the sample calculator");

