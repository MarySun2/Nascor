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

// Declarar el array de cadenas

// string[] myStrings = new string[2] 
// { 
//     "I like pizza. I like roast chicken. I like salad", 
//     "I like all three of the menu choices" 
// };

// // Bucle externo para recorrer cada cadena en el array
// foreach (string myString in myStrings)
// {
//     string tempString = myString;  // Copia de la cadena actual
//     int periodLocation;  // Almacena la ubicación del punto

//     // Bucle interno para extraer frases separadas por "."
//     do
//     {
//         periodLocation = tempString.IndexOf("."); // Buscar el primer punto

//         if (periodLocation != -1)
//         {
//             // Extraer la frase hasta el punto, eliminar espacios en blanco
//             string sentence = tempString.Substring(0, periodLocation).Trim();
//             Console.WriteLine(sentence); // Mostrar la frase

//             // Eliminar la parte procesada + el punto, para continuar con la siguiente frase
//             tempString = tempString.Remove(0, periodLocation + 1).TrimStart();
//         }
//         else
//         {
//             // Si no hay más puntos, imprimir el resto de la cadena
//             Console.WriteLine(tempString.Trim());
//         }

//     } while (periodLocation != -1); // Continuar mientras haya puntos en la cadena
// }

// Ejercicio Practico
// Matriz multidimensional para almacenar los datos de las mascotas
// string[,] ourAnimals = new string[,]
// {
//     {"1", "Gato", "2", "Negro y blanco", "Juguetón", "Michi"},
//     {"2", "Perro", "3", "Marrón", "Amigable", "Max"},
//     {"3", "Gato", "", "Gris", "", ""},
//     {"4", "Perro", "5", "Negro", "Leal", "Rex"}
// };

// while (true) // Bucle principal del menú
// {
//     // Menú principal
//     Console.WriteLine("\n--- Contoso Pets ---");
//     Console.WriteLine("1. Mostrar todas las mascotas");
//     Console.WriteLine("2. Agregar nueva mascota");
//     Console.WriteLine("3. Salir");
//     Console.Write("Seleccione una opción: ");

//     string option = Console.ReadLine();

//     // Manejo de opciones
//     if (option == "1") 
//     {
//         Console.WriteLine("\nLista de Mascotas:");
//         for (int i = 0; i < ourAnimals.GetLength(0); i++)
//         {
//             Console.WriteLine($"ID: {ourAnimals[i, 0]}, Especie: {ourAnimals[i, 1]}, Edad: {ourAnimals[i, 2]} años, Color: {ourAnimals[i, 3]}, Personalidad: {ourAnimals[i, 4]}, Alias: {ourAnimals[i, 5]}");
//         }
//     }
//     else if (option == "2") 
//     {
//         Console.Write("Ingrese la especie (Gato o Perro): ");
//         string species = Console.ReadLine().Trim();

//         if (species.ToLower() != "gato" && species.ToLower() != "perro")
//         {
//             Console.WriteLine("⚠ Especie no válida. Solo se aceptan 'Gato' o 'Perro'.");
//             continue;
//         }

//         string newId = (ourAnimals.GetLength(0) + 1).ToString();
//         Console.Write("Ingrese la edad (si no se conoce, deje vacío): ");
//         string age = Console.ReadLine().Trim();

//         Console.Write("Ingrese el color o características físicas: ");
//         string physicalDesc = Console.ReadLine().Trim();

//         Console.Write("Ingrese la personalidad (si no se conoce, deje vacío): ");
//         string personality = Console.ReadLine().Trim();

//         Console.Write("Ingrese el alias (si no tiene, deje vacío): ");
//         string alias = Console.ReadLine().Trim();

//         // Crear nueva matriz para agregar el nuevo animal
//         string[,] updatedAnimals = new string[ourAnimals.GetLength(0) + 1, 6];

//         for (int i = 0; i < ourAnimals.GetLength(0); i++)
//         {
//             for (int j = 0; j < ourAnimals.GetLength(1); j++)
//             {
//                 updatedAnimals[i, j] = ourAnimals[i, j];
//             }
//         }

//         // Agregar nuevo animal
//         updatedAnimals[ourAnimals.GetLength(0), 0] = newId;
//         updatedAnimals[ourAnimals.GetLength(0), 1] = species;
//         updatedAnimals[ourAnimals.GetLength(0), 2] = age;
//         updatedAnimals[ourAnimals.GetLength(0), 3] = physicalDesc;
//         updatedAnimals[ourAnimals.GetLength(0), 4] = personality;
//         updatedAnimals[ourAnimals.GetLength(0), 5] = alias;

//         ourAnimals = updatedAnimals; // Actualizar la matriz principal

//         Console.WriteLine("🐶🐱 ¡Mascota agregada con éxito!");
//     }
//     else if (option == "3")
//     {
//         Console.WriteLine("Saliendo del programa...");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("⚠ Opción no válida. Intente de nuevo.");
//     }
// }

//Ejemplo Mascotas

//  string[,] ourAnimals = {
//         { "c1", "Cat", "2", "Small black cat", "Playful and energetic", "" },
//         { "c2", "Cat", "3", "Large white cat", "Calm and affectionate", "Whiskers" },
//         { "d1", "Dog", "5", "Brown Labrador", "Loyal and protective", "" },
//         { "c4", "Cat", "", "", "", "" } // Datos incompletos
//     };

//     while (true)
//     {
//         // En caso que sea Exit
//         Console.WriteLine("Enter 4 to complete nickname and personality description, or type 'exit' to quit:");
//         string userInput = Console.ReadLine();
//         if (userInput.ToLower() == "exit")
//             break;

//         //En caso que sea 4
//         if (userInput == "4")
//         {
//             for (int i = 0; i < ourAnimals.GetLength(0); i++)
//             {
//                 if (string.IsNullOrWhiteSpace(ourAnimals[i, 5])) // Nickname vacío
//                 {
//                     Console.Write($"Enter a nickname for ID #: {ourAnimals[i, 0]}: ");
//                     string nickname;
//                     do
//                     {
//                         nickname = Console.ReadLine();
//                         if (string.IsNullOrWhiteSpace(nickname))
//                             Console.Write("Nickname cannot be empty. Enter a valid nickname: ");
//                     } while (string.IsNullOrWhiteSpace(nickname));
//                     ourAnimals[i, 5] = nickname;
//                 }

//                 if (string.IsNullOrWhiteSpace(ourAnimals[i, 4])) // Descripción de personalidad vacía
//                 {
//                     Console.Write($"Enter a personality description for ID #: {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level): ");
//                     string personality;
//                     do
//                     {
//                         personality = Console.ReadLine();
//                         if (string.IsNullOrWhiteSpace(personality))
//                             Console.Write("Personality description cannot be empty. Enter a valid description: ");
//                     } while (string.IsNullOrWhiteSpace(personality));
//                     ourAnimals[i, 4] = personality;
//                 }
//             }
//             Console.WriteLine("Nickname and personality description fields are complete for all of our friends.\nPress the Enter key to continue.");
//             Console.ReadLine();
//         }
//     }


//Ejercicio con matrices  

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//     string message = "";  // Variable para almacenar las letras.
//     double total = 0;     // Variable para almacenar la suma de los números.

//     foreach (string value in values)
//     {
//         if (value.All(char.IsLetter))  // Si es alfabético, concatenar.
//         {
//             message += value;
//         }
//         else  // Si no es alfabético, intentar convertirlo a número.
//         {
//             if (double.TryParse(value, out double num)) 
//             {
//                 total += num;  // Si es numérico, sumarlo al total.
//             }
//         }
//     }

// Mostrar el resultado.
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");


// Una forma mas sencilla de realizar el ejercicio
//     string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// Ejercicio x por realizar

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// //int result1 = (int)Math.Round(value1 / value2);
// int result1 = Convert.ToInt32(value1/value2);
// decimal result2 = value2 / (decimal)value3;
// float result3 = value3 / value1;

// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//Ejercicio de  Sort() y Reverse()

//     string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//
// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//Clear() y Resize()

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//////////////////////////////////////////////////////////////////
// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//////////////////////////////////////////////////////////////////////
// string[] pallets =  ["B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Cambio de tamaño de la matriz para quitar elementos

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

//join
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

//split
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//Ejercicio invertir palabras
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] palabras = pangram.Split(' '); // 1. Dividir en palabras

// for (int i = 0; i < palabras.Length; i++)
// {
//     char[] letras = palabras[i].ToCharArray(); // 2. Convertir palabra en array de letras
//     Array.Reverse(letras);                     // 3. Invertir las letras
//     palabras[i] = new string(letras);         // 4. Volver a convertir en palabra
// }

// string resultado = String.Join(" ", palabras); // 5. Unir todas las palabras con espacio
// Console.WriteLine(resultado);

// Otra Forma de Hacerlo
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

//
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderIDs = orderStream.Split(',');

// Array.Sort(orderIDs);

// foreach (var orderID in orderIDs)
// {
//     if (orderID.Length == 4)
//     {
//         Console.WriteLine(orderID);
//     }
//     else
//     {
//         Console.WriteLine($"{orderID} - Error");
//     }
// }

// Otro Ejercicio  
// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

//Ejercicio 
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);


//Ejercicio  numero de facturas mediante la interpolacion de cadenas

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// //
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string input = "Pad this";
//  Console.WriteLine(input.PadLeft(12));
//  Console.WriteLine(input.PadRight(12));
//  Console.WriteLine(input.PadLeft(12, '-'));
//  Console.WriteLine(input.PadRight(12, '-'));

//
// string paymentId = "769C";

//  var formattedLine = paymentId.PadRight(6);

//  Console.WriteLine(formattedLine);
//

// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);

//  Console.WriteLine(formattedLine);

//

//  string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine("1234567890123456789012345678901234567890");
//  Console.WriteLine(formattedLine);

//Ejercicio del REto microsoft con chat gpt

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine("Here's a quick comparison:\n");

// //Agregar el cuerpo del mensaje
// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");

// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// //Counstruccion del mensaje de comparacion
// string comparisonMessage = "";

// comparisonMessage = 
//     $"{currentProduct,-18} {currentReturn:P2}   {currentProfit:C}\n" +
//     $"{newProduct,-18} {newReturn:P2}   {newProfit:C}";

// // Your logic here

// Console.WriteLine(comparisonMessage);


//Ejercicio del REto microsoft con la plataforma

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// IndexOf() y Substring()

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

//Para que no se muestre el parentesis se agrega + 1 al opengPosition

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// 

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//IndexOf() y LastIndexOf

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

//

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
//}

//IndexOfAny()

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");

// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;

// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

//
// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

//Remove ()  Replace()

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

//

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

//Reto microsoft

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// // 1. Extraer la cantidad de la etiqueta <span>...</span>
// int startSpan = input.IndexOf("<span>") + "<span>".Length; // Encontrar el inicio de <span>
// int endSpan = input.IndexOf("</span>"); // Encontrar el final de </span>
// string quantity = input.Substring(startSpan, endSpan - startSpan); // Extraer el contenido entre las etiquetas <span> y </span>

// // 2. Eliminar las etiquetas <div> y </div>
// string output = input.Replace("<div>", "").Replace("</div>", ""); // Eliminar las etiquetas <div> y </div>

// // 3. Reemplazar &trade; con &reg;
// output = output.Replace("&trade;", "&reg;"); // Reemplazar el símbolo ™ por ®

// // 4. Mostrar los resultados
// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");


// // otra forma de hacerlo

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// // Extract the "quantity"
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
// int quantityEnd= input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// // Remove the opening <div> tag
// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// output = output.Remove(divStart, openDiv.Length);

// // Remove the closing </div> tag and add "Output:" to the beginning
// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine(quantity);
// Console.WriteLine(output);

//Metodos

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

//Ejercicio Metodo 01

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

//Ejercicio 02 Metodos
// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

//Ejercicio de metodos 03
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("A fortune teller whispers the following words:");
//         TellFortune();

//         // Puedes llamar al método otra vez si quieres otra predicción
//         // TellFortune();
//     }

//     static void TellFortune()
//     {
//         Random random = new Random();
//         int luck = random.Next(100); // Genera un número entre 0 y 99

//         string[] text = {
//             "You have much to",
//             "Today is a day to",
//             "Whatever work you do",
//             "This is an ideal time to"
//         };

//         string[] good = {
//             "look forward to.",
//             "try new things!",
//             "is likely to succeed.",
//             "accomplish your dreams!"
//         };

//         string[] bad = {
//             "fear.",
//             "avoid major decisions.",
//             "may have unexpected outcomes.",
//             "re-evaluate your life."
//         };

//         string[] neutral = {
//             "appreciate.",
//             "enjoy time with friends.",
//             "should align with your values.",
//             "get in tune with nature."
//         };

//         // Selecciona el tipo de suerte según el valor de luck
//         string[] fortune = (luck > 75) ? good :
//                            (luck < 25) ? bad :
//                            neutral;

//         for (int i = 0; i < 4; i++)
//         {
//             Console.Write($"{text[i]} {fortune[i]} ");
//         }

//         Console.WriteLine(); // Salto de línea al final
//     }
// }

// Ejercio 03 otra forma de hacerlo 
// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }


//Ejercicio Metodos

// int[] schedule = {800, 1200, 1600, 2000};

// // LLamar al metodo que se Muestra en pantalla
// DisplayAdjustedTimes(schedule, 6, -6);

// // Metodo
// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
// {
//     int diff = 0;
// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
// }

// for (int i = 0; i < times.Length; i++) 
// {
//     int newTime = ((times[i] + diff)) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
// }

// }

// ejemplo de metodo globales

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students)  
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// siguiente ejercicio metodo

// double pi = 3.14159;

// //Llamada al metodo
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// // Metodos
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

//Ejercicio 1 Metodos

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// Ejercicio 2 Metodos

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// Ejercicio 3 Metodo: corregir errores en cadenas

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

//Ejercicio

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// //LLamada del metodo
// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();


// //Metodo 
// void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
// {
//     if (inviteOnly)
//     {
//         // search guestList before adding rsvp
//          bool found = false;
//     foreach (string guest in guestList)
//     {
//         if (guest.Equals(name)) {
//             found = true;
//             break;
//         }
//     }
//     if (!found)
//     {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//     }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

//Desafio contoso metodo con parametros

// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     // display internal email addresses
//     DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// }

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// }

// void DisplayEmail(string first, string last, string domain = "contoso.com") 
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}

//pracctica con metodos

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

//METODOS PARTE 2

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }

////
//Metodo que devuelve cadenas

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");
//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }
//     return result.Trim();
// }

// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

////
/// Metodo Palindromo
// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end) 
//     {
//         if (word[start] != word[end]) 
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

////
/// Ejercicio Devolver matrices de metodos

// int target = 60;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[] result = TwoCoins(coins, target);

// int[] TwoCoins(int[] coins, int target)
// {
//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 return new int[] { curr, next };
//             }

//         }
//     }

//     return new int[0];
// }

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
// }
////
//Otro ejercicio de monedas

// int target = 80;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }

////
/// Juego de reto
// using System;

// Random random = new Random();

// Console.WriteLine("¿Quieres jugar? (S/N)");
// if (ShouldPlay())
// {
//     Console.WriteLine("¡Perfecto! 🎲 Empecemos el juego.");
//     PlayGame();
// }
// else
// {
//     Console.WriteLine("¡No quieres jugar! Nos vemos en otra ocasión. 👋");
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         int target = GetTarget();  // Número aleatorio entre 1 y 5
//         int roll = GetRoll();      // Número aleatorio entre 1 y 6

//         Console.WriteLine($"\n¡Lanza un número mayor que {target} para ganar!");
//         Console.WriteLine($"Has lanzado un {roll}");
//         Console.WriteLine(WinOrLose(roll, target));

//         Console.WriteLine("\n¿Quieres jugar otra vez? (S/N)");
//         play = ShouldPlay();  // Preguntar si quiere seguir
//     }

//     // Mensaje final cuando ya no quiere jugar
//     Console.WriteLine("¡No quieres jugar! Nos vemos en otra ocasión. 👋");
// }

// // Genera un número objetivo aleatorio entre 1 y 5
// int GetTarget()
// {
//     return random.Next(1, 6); // 6 no se incluye, así que genera entre 1 y 5
// }

// // Genera un número aleatorio de dado (entre 1 y 6)
// int GetRoll()
// {
//     return random.Next(1, 7); // 7 no se incluye, así que genera entre 1 y 6
// }

// // Pregunta al usuario si quiere jugar y devuelve true o false
// bool ShouldPlay()
// {
//     string response = Console.ReadLine().Trim().ToLower();

//     // Validación: mientras la respuesta no sea válida, vuelve a preguntar
//     while (response != "s" && response != "si" && response != "n" && response != "no")
//     {
//         Console.WriteLine("Por favor escribe S/Sí para sí o N/No para no:");
//         response = Console.ReadLine().Trim().ToLower();
//     }

//     return response == "s" || response == "si";
// }

// // Determina si el jugador gana o pierde
// string WinOrLose(int roll, int target)
// {
//     if (roll > target)
//     {
//         return "¡Ganaste! 🎉";
//     }
//     else
//     {
//         return "¡Perdiste! 😢";
//     }
// }

//Ejercicio nuevo metodo
using System;

// class Program
// {
//     static void Main()
//     {
//         // Lista de animales
//         string[] pettingZoo = 
//         {
//             "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//             "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//             "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
//         };

//         // Paso 1: Mezclar animales
//         RandomizeAnimals(pettingZoo);

//         // Paso 2: Dividir en grupos
//         string[,] group = AssignGroup(pettingZoo, 6); // 6 grupos para School A

//         // Paso 3: Imprimir nombre de la escuela
//         Console.WriteLine("School A");

//         // Paso 4: Imprimir los grupos
//         PrintGroup(group);
//     }

//     // Método para mezclar los animales
//     static void RandomizeAnimals(string[] array)
//     {
//         Random rng = new Random();
//         for (int i = array.Length - 1; i > 0; i--)
//         {
//             int j = rng.Next(i + 1);
//             // Intercambiar elementos
//             string temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//     }

//     // Método para dividir los animales en grupos
//     static string[,] AssignGroup(string[] animals, int groupCount)
//     {
//         int animalsPerGroup = animals.Length / groupCount;
//         string[,] result = new string[groupCount, animalsPerGroup];

//         int index = 0;
//         for (int i = 0; i < groupCount; i++)
//         {
//             for (int j = 0; j < animalsPerGroup; j++)
//             {
//                 result[i, j] = animals[index++];
//             }
//         }

//         return result;
//     }

//     // Método para imprimir los grupos
//     static void PrintGroup(string[,] group)
//     {
//         for (int i = 0; i < group.GetLength(0); i++)
//         {
//             Console.Write($"Group {i + 1}: ");
//             for (int j = 0; j < group.GetLength(1); j++)
//             {
//                 Console.Write(group[i, j]);
//                 if (j < group.GetLength(1) - 1)
//                     Console.Write(", ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// //Manera simple de hacerlo 
// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
// }

// void RandomizeAnimals() 
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

//Metodos
// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

//metodo 2
// double pi = 3.14159;

// PrintCircleInfo(12);
// PrintCircleInfo(24);


// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

//metodo 3
// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

//Metodo 4
// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

//Metodo 5

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

//Metodos opcionales

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;
// Console.WriteLine("Ejercicio1");
// RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
// Console.WriteLine("Ejercicio2");
// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// Console.WriteLine("Ejercicio3");
// ShowRSVPs();

// void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
// {
//         if (inviteOnly)
//         {
//             bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name)) {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

//Metodo 6

string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++) 
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++) 
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}