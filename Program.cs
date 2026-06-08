//Entrada de datos, nombre, distancia, hora
Console.WriteLine("Nombre del pasajero");
string nombre = Console.ReadLine ();

Console.WriteLine("Ingrese distancia del viaje (km): ");
double distancia = double.Parse(Console.ReadLine());

Console.WriteLine("Hora de salida (0 hrs - 23 hrs: )");
int hora = int.Parse(Console.ReadLine());

Console.WriteLine("\nTipo de vehículo: ");
Console.WriteLine("1. Económico");
Console.WriteLine("2. Confort");
Console.WriteLine("3. Premium");
Console.WriteLine("4. Moto");

Console.WriteLine("Ingrese una opción");
int Tipo_de_vehículo = int.Parse(Console.ReadLine(""));

//Proceso

