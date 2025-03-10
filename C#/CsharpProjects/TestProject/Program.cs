// See https://aka.ms/new-console-template for more information

// Para Crear un proyecto  es:  dotnet new console -o ./CsharpProjects/TestProject
// Para compilar y ejecutar el proyecto: dotnet run
// Para compilarlo: dotnet build
// Para instalar las dependencias de NuGet: dotnet add package Microsoft.Azure.Cosmos -v 3.19.0



// LLame a diferentes tipos de métodos en la biblioteca de clases .NET usando System.Random y System.Console

// Ejercicio 1
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Ejercicio 2
// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// Ejercicio 3
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// Ejercicio 4
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue= Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

//Ejercicio 5 Matrices

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Ejercicio 6 Matrices
// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Ejercicio 7 Matrices forech
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// Ejercicio 8 Matrices forech
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;

// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// Ejercicio 9 Matrices

 // Declaración del array con identificadores de pedidos
// string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

// Console.WriteLine("Pedidos fraudulentos que comienzan con 'B':");

// // Recorremos el array y filtramos los que comienzan con "B"
//         foreach (string orderID in fraudulentOrderIDs)
//         {
//             if (orderID.StartsWith("B"))
//             {
//                 Console.WriteLine(orderID);
//             }
//         }
    

    //Ejercicio 10 Variables y comentarios

// string firstName = "Bob";
// int widgetsPurchased = 7;
// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

//Ejercicio directrices de codigo

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string ogiriginalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = ogiriginalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    }
}

string newMessage = new String(message);

// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o'  appears {letterCount} times.");