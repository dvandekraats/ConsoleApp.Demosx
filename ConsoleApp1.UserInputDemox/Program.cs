// Declare variables
string name = string.Empty;
int age  = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your name:");
name = Console.ReadLine();
Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

//Output results to user
Console.WriteLine($"Fullname: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");