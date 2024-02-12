// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable / global scope
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
//if ((grade < 0) || (grade > 100))
//{
//    Console.WriteLine("Invalid value entered");
//}
//else
if ((grade >= 0) && (grade < 50))
{
    Console.WriteLine("Student has failed - F");
}
else if ((grade >= 50) && (grade < 60))
{
    Console.WriteLine("Student has failed: D");
}
else if((grade >= 60) && (grade < 65))
{
    Console.WriteLine("Student has passed: C-");
}
else if ((grade >= 65) && (grade < 70))
{
    Console.WriteLine("Student has passed: C");
}
else if ((grade >= 70) && (grade < 75))
{
    Console.WriteLine("Student has passed: C+");
}
else if ((grade >= 75) && (grade < 85))
{
    Console.WriteLine("Student has passed: B");
}
else if ((grade >= 85) && (grade <= 100))
{
    Console.WriteLine("Student has passed: A");
}
else
{
    Console.WriteLine("Please enter a valid grade (0-100)");
}
Console.WriteLine("########### Complex IF..ELSE IF Results End ############");

//Ternary operator - used to assign a value to a variable based on condition.
Console.WriteLine("############# Ternary Operator Result ##################");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student has {passStatus}");

Console.WriteLine("############# Ternary Operator Result End ##############");

//Switch statements - used to evaluate a value and take an action
Console.WriteLine("############## Switch Statement Result ##################");
/*
 * Write a program to accept an integer as the day of the week and print 
 * the appropriate message as outlined below.
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday
 * 4 - Wednesday
 * 5 - Thursday
 * 6 - Friday
 * 7 - Saturday
 */

Console.Write("Enter a day number (1-7)");
int dayInt = Convert.ToInt32(Console.ReadLine());
string? dayString = null; 
//dayString = dayInt == 1 ? "Sunday" : 
//                  (dayInt == 2 ? "Monday" : 
//                  (dayInt == 3 ? "Tuesday" : 
//                  (dayInt == 4 ? "Wednesday" : 
//                  (dayInt == 5 ? "Thursday" : 
//                  (dayInt == 6 ? "Friday" : "Saturday")))));
switch (dayInt)
{
    case 1:
        dayString = "Sunday";
        break;
    case 2:
        dayString = "Monday";
        break;
    case 3:
        dayString = "Tuesday";
        break;
    case 4:
        dayString = "Wednesday";
        break;
    case 5:
        dayString = "Thursday";
        break;
    case 6:
        dayString = "Friday";
        break;
    case 7:
        dayString = "Saturday";
        break;
    default:
        Console.WriteLine("Invalid day number entered!!");
        break;
}

Console.WriteLine($"Today is {dayString}");

Console.WriteLine("############## Switch Statement Result End ##############");

// The rest of the application
Console.WriteLine("Thank you for using this program");

