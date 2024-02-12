// See https://aka.ms/new-console-template for more information


Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Add numbers
int sum = num1 + num2;

/*
    MATH Operations
 */
// Subtract numbers
int difference = num1 - num2;
// Multiply numbers
int product = num1 * num2;
// Divide numbers
int quotient = num1 / num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("************************ Start Of MATH Results **************************");
Console.WriteLine();
Console.WriteLine($"The sum of {num1} + {num2} is: {sum}");
Console.WriteLine($"The difference between {num1} - {num2} is: {difference}");
Console.WriteLine($"The product of {num1} X {num2} is: {product}");
Console.WriteLine($"The quotient of {num1} / {num2} is: {quotient}");
Console.WriteLine($"The modulus of {num1} % {num2} is: {mod}");
Console.WriteLine();
Console.WriteLine("************************ End Of MATH Results **************************");


/*
    LOGIC Operations 
 */
var isGreaterThan = num1 > num2;
var isLessThan = num1 < num2;
var isEqualTo = num1 == num2;
var isNotEqualTo = num1 != num2;
var isGreaterThanOrEqualTo = num1 >= num2;
var isLessThanOrEqualTo = num1 <= num2;

Console.WriteLine("************************ LOGIC Results **************************");
Console.WriteLine();
Console.WriteLine($"is {num1} greater than {num2}? result: {isGreaterThan}");
Console.WriteLine($"is {num1} less than {num2}? result: {isLessThan}");
Console.WriteLine($"is {num1} equal to {num2}? result: {isEqualTo}");
Console.WriteLine($"is {num1} not equal to {num2}? result: {isNotEqualTo}");
Console.WriteLine($"is {num1} greater than or equal to {num2}? result: {isGreaterThanOrEqualTo}");
Console.WriteLine($"is {num1} less than or equal to {num2}? result: {isLessThanOrEqualTo}");
Console.WriteLine();
Console.WriteLine("************************ End Of LOGIC Results **************************");

/*
    ASSIGNMENT Operations 
 */
int randomValue = 5;
int increaseValue = num1 += randomValue;
int decreaseValue = num1 -= randomValue;
int multiplyValue = num1 *= randomValue;
int divideValue = num1 /= randomValue;

Console.WriteLine("************************ ASSIGNMENT Results **************************");
Console.WriteLine();
Console.WriteLine($"is {num1} greater than {num2}? result: {isGreaterThan}");
Console.WriteLine($"is {num1} less than {num2}? result: {isLessThan}");
Console.WriteLine($"is {num1} equal to {num2}? result: {isEqualTo}");
Console.WriteLine($"is {num1} not equal to {num2}? result: {isNotEqualTo}");
Console.WriteLine($"is {num1} greater than or equal to {num2}? result: {isGreaterThanOrEqualTo}");
Console.WriteLine($"is {num1} less than or equal to {num2}? result: {isLessThanOrEqualTo}");
Console.WriteLine();
Console.WriteLine("************************ End Of ASSIGNMENT Results **************************");





