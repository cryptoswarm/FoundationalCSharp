
using System.Text;
//basic string formatting
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World!\"");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//Verbatism string

Console.WriteLine(@"Generating invoices for customer ""Contoso Corp"" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory:   ");


// Unicode escape characters
//using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).
// Console.WriteLine("\u3053");

//// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

//String concatenation
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

////Or better


firstName = "Bob";
message = new StringBuilder("Hello ").Append(firstName).ToString();
Console.WriteLine(message);

firstName = "Foo";
string greeting = "Hello";
message = greeting + " " + firstName + "!";
Console.WriteLine(message);

//Or better

Console.WriteLine(new StringBuilder().Append("Hello ").Append("Bob!").ToString());

//// Challenge: Format and display instructions

/**
// Desired output
// View English output:
//   c:\Exercise\ACME\data.txt

// Посмотреть русский вывод:
//   c:\Exercise\ACME\ru-RU\data.txt
*/
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output:\n  c:\\Exercise\\{projectName}\\data.txt");
Console.WriteLine($"{russianMessage}:\n  c:\\Exercise\\{projectName}\\ru-RU\\data.txt");



