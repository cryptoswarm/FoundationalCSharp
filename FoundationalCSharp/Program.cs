//  Perform basic operations on numbers in C#

// var firstOperand = 16;
// var secondOperand = 15;
// Console.WriteLine(firstOperand + secondOperand);

// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");


// string firstName = "Bob";
// int widgetsSold = 7;
// var result = firstName + widgetsSold;
// Console.WriteLine(result);

//parentheses as overloded operator
// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Perform basic math operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// division using literal decimal data
Console.WriteLine("""
                    ***********************************************
                    ****  division using literal decimal data  ****
                    ***********************************************
                """);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// division using literal decimal data
Console.WriteLine("""
                    *******************
                    ****  Casting  ****
                    *******************
                """);

int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1);

Console.WriteLine("""
                    ********************************************
                    ****  remainder after integer division  ****
                    ********************************************
                """);
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

Console.WriteLine("""
                    ************************************************************
                    ****  Position the increment and decrement operators    ****
                    ************************************************************
                """);

// Both the increment and decrement operators have an interesting quality
//  — depending on their position, they perform their operation before or after they retrieve their value. 
//  In other words, if you use the operator before the value as in ++value, 
//  then the increment will happen before the value is retrieved. 
//  Likewise, value++ will increment the value after the value has been retrieved.
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

Console.WriteLine("""
                    *********************************************************************
                    ****  Complete the challenge to convert Fahrenheit to Celsius    ****
                    *********************************************************************
                """);

int fahrenheit = 94;
decimal degreeInCelsius = (fahrenheit - 32) * (5m / 9m);
Console.WriteLine(degreeInCelsius);
