using System;
using System.Threading;

// Aplicación Contoso Pets en español
// Gestiona un listado de mascotas y búsqueda avanzada con múltiples términos y animación

class Program
{
    static void Main(string[] args)
    {
        // #1 Variables temporales para datos de cada mascota
        string especieAnimal = "";
        string idAnimal = "";
        string edadAnimal = "";
        string descripcionFisica = "";
        string descripcionPersonalidad = "";
        string apodoAnimal = "";
        string donacionSugeridaTexto = "";

        // #2 Variables de soporte
        int maxMascotas = 8;
        string? entradaUsuario;
        string seleccionMenu = "";
        decimal donacionDecimal;

        // #3 Arreglo para almacenar mascotas en tiempo de ejecución
        string[,] mascotas = new string[maxMascotas, 7];

        // #4 Cargar datos de ejemplo
        for (int i = 0; i < maxMascotas; i++)
        {
            switch (i)
            {
                case 0:
                    especieAnimal = "perro";
                    idAnimal = "d1";
                    edadAnimal = "2";
                    descripcionFisica = "mediano, color crema, hembra, golden retriever de unos 45 libras. entrenada para casa.";
                    descripcionPersonalidad = "le encanta que le rasquen la panza y perseguir su cola. da muchas lamidas.";
                    apodoAnimal = "lola";
                    donacionSugeridaTexto = "85.00";
                    break;
                case 1:
                    especieAnimal = "perro";
                    idAnimal = "d2";
                    edadAnimal = "9";
                    descripcionFisica = "grande, marrón rojizo, macho, golden retriever de unos 85 libras. entrenado para casa.";
                    descripcionPersonalidad = "le encanta que le rasquen las orejas al saludar, ¡y abrazar!";
                    apodoAnimal = "gus";
                    donacionSugeridaTexto = "49.99";
                    break;
                case 2:
                    especieAnimal = "gato";
                    idAnimal = "c3";
                    edadAnimal = "1";
                    descripcionFisica = "pequeño, blanco, hembra, unos 8 libras. entrenada al arenero.";
                    descripcionPersonalidad = "amistosa";
                    apodoAnimal = "snow";
                    donacionSugeridaTexto = "40.00";
                    break;
                case 3:
                    especieAnimal = "gato";
                    idAnimal = "c4";
                    edadAnimal = "3";
                    descripcionFisica = "mediano, pelo largo, amarillo, hembra, unos 10 libras. usa arenero.";
                    descripcionPersonalidad = "le gusta sentarse en tu regazo.";
                    apodoAnimal = "lion";
                    donacionSugeridaTexto = "";
                    break;
                default:
                    especieAnimal = idAnimal = edadAnimal = descripcionFisica = descripcionPersonalidad = apodoAnimal = donacionSugeridaTexto = "";
                    break;
            }

            // Asignar al arreglo
            mascotas[i, 0] = idAnimal;
            mascotas[i, 1] = especieAnimal;
            mascotas[i, 2] = edadAnimal;
            mascotas[i, 3] = apodoAnimal;
            mascotas[i, 4] = descripcionFisica;
            mascotas[i, 5] = descripcionPersonalidad;

            // Parsear donación sugerida o usar valor por defecto
            if (!decimal.TryParse(donacionSugeridaTexto, out donacionDecimal))
                donacionDecimal = 45.00m;

            mascotas[i, 6] = donacionDecimal.ToString("C2");
        }

        // Definir iconos de animación de giro
        string[] spinnerIcons = { "|", "/", "-", "\\" };

        // #5 Menú principal
        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la aplicación Contoso Pets. Opciones principales:");
            Console.WriteLine(" 1. Listar todas las mascotas registradas");
            Console.WriteLine(" 2. Buscar perros por características");
            Console.WriteLine("Escribe 1, 2 o 'salir' para terminar");

            entradaUsuario = Console.ReadLine();
            if (entradaUsuario != null)
                seleccionMenu = entradaUsuario.ToLower().Trim();

            switch (seleccionMenu)
            {
                case "1":
                    // Listar información completa de cada mascota
                    for (int i = 0; i < maxMascotas; i++)
                    {
                        if (!string.IsNullOrEmpty(mascotas[i, 0]))
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ID #: {mascotas[i,0]}");
                            Console.WriteLine($"Especie: {mascotas[i,1]}");
                            Console.WriteLine($"Edad: {mascotas[i,2]}");
                            Console.WriteLine($"Apodo: {mascotas[i,3]}");
                            Console.WriteLine($"Descripción física: {mascotas[i,4]}");
                            Console.WriteLine($"Personalidad: {mascotas[i,5]}");
                            Console.WriteLine($"Donación sugerida: {mascotas[i,6]}");
                        }
                    }
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "2":
                    // Buscar varios términos
                    Console.WriteLine("\nIngresa características de perro separadas por comas:");
                    string? rawInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(rawInput))
                        break;

                    // Separar, limpiar y ordenar términos
                    string[] terminos = rawInput
                        .Split(',', StringSplitOptions.RemoveEmptyEntries);
                    for (int k = 0; k < terminos.Length; k++)
                        terminos[k] = terminos[k].Trim().ToLower();
                    Array.Sort(terminos, StringComparer.Ordinal);

                    bool algunoCoincide = false;

                    // Recorrer cada perro
                    for (int i = 0; i < maxMascotas; i++)
                    {
                        if (mascotas[i,1].Contains("perro"))
                        {
                            string descripcionCompleta = mascotas[i,4] + " " + mascotas[i,5];
                            bool mostrarDatosEstePerro = false;

                            // Para cada término, animar y luego buscar
                            foreach (string term in terminos)
                            {
                                // Animación giratoria con cuenta atrás 2->0
                                for (int cuenta = 2; cuenta >= 0; cuenta--)
                                {
                                    foreach (string icon in spinnerIcons)
                                    {
                                        Console.Write($"\rbuscando nuestro perro {mascotas[i,3]} para {term} {icon} / {cuenta}");
                                        Thread.Sleep(200);
                                    }
                                }
                                Console.WriteLine();

                                // Verificar coincidencia
                                if (descripcionCompleta.Contains(term))
                                {
                                    Console.WriteLine($"Nuestro perro {mascotas[i,3]} coincide con tu búsqueda de {term}");
                                    algunoCoincide = true;
                                    mostrarDatosEstePerro = true;
                                }
                            }

                            // Si hubo coincidencias para este perro, mostrar detalles
                            if (mostrarDatosEstePerro)
                            {
                                Console.WriteLine($"{mascotas[i,3]} (ID #: {mascotas[i,0]})");
                                Console.WriteLine($"Descripción física: {mascotas[i,4]}");
                                Console.WriteLine($"Personalidad: {mascotas[i,5]}\n");
                            }
                        }
                    }

                    // Mensaje si no hubo coincidencias
                    if (!algunoCoincide)
                    {
                        Console.WriteLine($"Ningún perro coincide con: {string.Join(", ", terminos)}");
                    }

                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "salir":
                    // Terminar programa
                    break;

                default:
                    // Opción no válida
                    break;
            }

        } while (seleccionMenu != "salir");
    }
}
