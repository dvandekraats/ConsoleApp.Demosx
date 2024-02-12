// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail based on input
Console.WriteLine("################## Simple If Results ###################");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Refer student to Administration");
}
Console.WriteLine("################## Simple If Results End ###############");

Console.WriteLine("########### Complex IF..ELSE IF Results ################");
// Complex if...else if..statement - Decide to print letter graded based on grade value
if ((grade >= 0) && (grade < 50))
{
    Console.WriteLine("Student has failed - F");
}
else if ((grade >= 50) && (grade < 60))
{
    Console.WriteLine("Student has failed - D");
}
else if((grade >= 60) && (grade < 65))
{
    Console.WriteLine("Student has passed - C-");
}
else if ((grade >= 65) && (grade < 70))
{
    Console.WriteLine("Student has passed - C");
}
else if ((grade >= 70) && (grade < 75))
{
    Console.WriteLine("Student has passed - C+");
}
else if ((grade >= 75) && (grade < 85))
{
    Console.WriteLine("Student has passed - B");
}
else if ((grade >= 85) && (grade <= 100))
{
    Console.WriteLine("Student has passed - A");
}
else
{
    Console.WriteLine("Please enter a valid grade (0-100)");
}
Console.WriteLine("########### Complex IF..ELSE IF Results End ############");

// The rest of the application
Console.WriteLine("Thank you for using this program");

