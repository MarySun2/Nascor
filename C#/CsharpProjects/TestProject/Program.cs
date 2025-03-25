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

// string ogiriginalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = ogiriginalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message) 
// { 
//     if (letter == 'o') 
//     { 
//         letterCount++; 
//     }
// }

// string newMessage = new String(message);

// // print it out
// Console.WriteLine(newMessage);
// Console.WriteLine($"'o'  appears {letterCount} times.");

//Ejercicio 11 Ejemplo variables
// initialize variables - graded assignments 

// int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// //variable sin inicializar
// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();

//11.1 Ejercicio con matrices

// initialize variables - graded assignments

// initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     // initialize/reset a counter for the number of assignment 
//     int gradedAssignments = 0;

//     // loop through the scores array and complete calculations for currentStudent
//     foreach (int score in studentScores)
//     {
//         // increment the assignment counter
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             // add the exam score to the sum
//             sumAssignmentScores += score;

//         else
//             // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//             sumAssignmentScores += score / 10;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();


// Ejercicio 12
// Console.WriteLine("OPERADOR DE IGUALDAD == ");
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("OPERADOR DE IGUALDAD != ");

//   Console.WriteLine("a" != "a"); // False
//         Console.WriteLine("a" != "A"); // True (C# distingue mayúsculas de minúsculas)
//         Console.WriteLine(1 != 2);     // True

//         string myValue = "a";
//         Console.WriteLine(myValue != "a");

        // Ejemplo de operador condicional (?:)
        //<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

        // Otro ejemplo de operador Condicional
        // int saleAmount = 1001;
        // int discount = saleAmount > 1000 ? 100 : 50;
        // Console.WriteLine($"Discount: {discount}");

        // //Crear un condicional con cara y cruz con 50% probavilidad que salga el dado
        // // primera forma de hacerlo
        // Random coin = new Random();

        // int flip = coin.Next(0, 2);
        // Console.WriteLine((flip == 0) ? "heads" : "tails");

        // // segunda forma de hacerlo
        // Console.WriteLine(coin.Next(0, 2) == 0 ? "heads" : "tails");

        // // Tercera forma de hacerlo
        // Console.WriteLine(new Random().Next(2) == 0 ? "Cara" : "Cruz");

        // Ejercicio 13
// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// Ejercicio 14

// bool flag = false;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }else {
//     Console.WriteLine("No es valido");
// }

// Ejercicio 15
// bool flag = true;
// int value = 0;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// Ejercicio 16
// string name = "steve";

// if (name == "bob") 
//     Console.WriteLine("Found Bob");

// else if (name == "steve") 
//         Console.WriteLine("Found Steve");

// else 
//     Console.WriteLine("Found Chuck");

// Ejercicio 17
// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int total = 0; // Declarar fuera del bucle
// bool found = false; // Declarar fuera del bucle

// foreach (int number in numbers)
// {
//     total += number; // Acumular correctamente

//     if (number == 42)
//     {
//        found = true; // Asignar correctamente
//     }
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

//Ejercicio 18
// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// Ejercicio 19  Caso (if else)

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";

// } else if (product[0] == "02")
// {

//     type = "T-Shirt";

// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";

// } else if (product[1] == "MN")
// {

//     color = "Maroon";

// } else
// {

//     color = "White";

// }

// if (product[2] == "S")
// {
//     size = "Small";

// } else if (product[2] == "M")
// {

//     size = "Medium";

// } else if (product[2] == "L")
// {

//     size = "Large";

// } else
// {

//     size = "One Size Fits All";

// }

// Console.WriteLine($"Product: {size} {color} {type}");


// //Ejercicio 19 con switch

// // SKU = Stock Keeping Unit
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// // Ejemplo de for

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// // Ejemplo de for

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// //Ejemplo  de for
// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// // ejemplo de for con break
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// Ejemplo de for con matrices

// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// //Otro Ejemplo de for con matrices

// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

//Ejemplo de FIZZBUZZ

// using System;

// class Program
// {
//     static void Main()
//     {
//         for (int i = 1; i <= 100; i++)  // Bucle del 1 al 100
//         {
//             if (i % 3 == 0 && i % 5 == 0) // Si es divisible por 3 y 5
//             {
//                 Console.WriteLine($"{i} - FizzBuzz");
//             }
//             else if (i % 3 == 0)  // Si es divisible por 3
//             {
//                 Console.WriteLine($"{i} - Fizz");
//             }
//             else if (i % 5 == 0)  // Si es divisible por 5
//             {
//                 Console.WriteLine($"{i} - Buzz");
//             }
//             else  // Si no es divisible por 3 ni por 5
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }

//Ejemplo While y Do while

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// while

//  Random random = new Random(); // Generador de números aleatorios
//  int current = random.Next(1, 11); // Generar el primer número aleatorio

//         while (current != 7) // Mientras el número no sea 7, sigue ejecutando
//         {
//             Console.WriteLine(current); // Imprime el número
//             current = random.Next(1, 11); // Genera un nuevo número aleatorio
//         }

        // Console.WriteLine(current); // Finalmente imprime el 7 y termina
    

    //Ejercicio siguiente
    
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

//Juego del Desafio

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// Ejercicio 

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");

// do
// {
//     readResult = Console.ReadLine();
    
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//             Console.WriteLine("es true"); // Corregido
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// Console.WriteLine("Sale del bucle");

//TAREA  PRIMERA PARTE

// using System;

// class Program
// {
//     static void Main()
//     {
//         int userNumber;  // Variable para almacenar la entrada del usuario
//         bool isValid = false;  // Bandera para controlar la validación

//         Console.WriteLine("Enter an integer value between 5 and 10");

//         do
//         {
//             string? input = Console.ReadLine();  // Leer entrada del usuario
//             bool isNumber = int.TryParse(input, out userNumber);  // Validar si es un número

//             if (!isNumber)
//             {
//                 Console.WriteLine("Sorry, you entered an invalid number, please try again");
//             }
//             else if (userNumber < 5 || userNumber > 10)
//             {
//                 Console.WriteLine($"You entered {userNumber}. Please enter a number between 5 and 10.");
//             }
//             else
//             {
//                 isValid = true;  // La entrada es válida, salir del bucle
//             }

//         } while (!isValid);  // Repetir mientras la entrada sea inválida

//         Console.WriteLine($"Your input value ({userNumber}) has been accepted.");
//     }
// }

//sEGUNDA PARTE 

// using System;

// class Program
// {
//     static void Main()
//     {
//         string? userRole;
//         bool isValidRole = false;

//         Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

//         do
//         {
//             userRole = Console.ReadLine()?.Trim().ToLower();  // Leer y limpiar entrada

//             if (userRole == "administrator" || userRole == "manager" || userRole == "user")
//             {
//                 isValidRole = true;  // Entrada válida, salir del bucle
//             }
//             else
//             {
//                 Console.WriteLine($"The role name that you entered, \"{userRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//             }

//         } while (!isValidRole);  // Repetir hasta obtener una entrada válida

//         Console.WriteLine($"Your input value ({userRole}) has been accepted.");
//     }
// }

// TERCERA PARTE

