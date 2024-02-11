// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Derrick Vandekraats";
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the name of {0}", name); //Formatted string

int age = 60;
int retirementYearsLeft = 5;
int retirementAge =  age + retirementYearsLeft;
Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

// bool isRetired = false;
bool isRetired = (age >= retirementAge); // Try this line instead
Console.WriteLine("Am I retired? " + isRetired);