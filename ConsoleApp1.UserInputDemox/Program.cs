﻿// Declare variables

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

//Output results to user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Number of Working Years Remaining: {workingYearsRemaining}");