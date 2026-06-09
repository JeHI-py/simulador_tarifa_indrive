
    //Entrada de datos, nombre, distancia, hora
    //Variables
string nombre, nombreVehiculo;
double distancia, tarifaBase, costoKM, subtotal, tarifafinal, descuento;
int hora, Tipo_de_vehículo;
bool eshorapico;
Console.WriteLine("Nombre del pasajero");
nombre = Console.ReadLine ();

Console.WriteLine("Ingrese distancia del viaje (km): ");
distancia = double.Parse(Console.ReadLine());

Console.WriteLine("Hora de salida (0 hrs - 23 hrs: )");
hora = int.Parse(Console.ReadLine());

Console.WriteLine("\nTipo de vehículo: ");
Console.WriteLine("1. Económico");
Console.WriteLine("2. Confort");
Console.WriteLine("3. Premium");
Console.WriteLine("4. Moto");

Console.WriteLine("Ingrese una opción");
Tipo_de_vehículo = int.Parse(Console.ReadLine(""));


//Proceso  

switch (Tipo_de_vehículo)
        {
            case 1:
            nombreVehiculo = "confort";
            tarifaBase =2.0;
            costoKM = 1.5;
            break;

            case 2:
            nombreVehiculo = "confort";
            tarifaBase =3.0;
            costoKM = 2.0;
            break;

            case 3:
            nombreVehiculo = "confort";
            tarifaBase =5.0;
            costoKM = 3.0;
            break;

            case 4:
            nombreVehiculo = "Moto";
            tarifaBase =1.5;
            costoKM = 1.0;
            break;

            default:
                Console.WriteLine("\n Opción no válida");
                return;

        }
//Cálculo del subtotal base
subtotal = tarifaBase + costoKM * distancia;

//Condicional de recargo por hora pico
if((hora >= 7 && hora <= 9 ) || (hora >= 17 && hora <= 20))
{
    eshorapico = true;
    subtotal = subtotal * 1.30; //incremento del 30%
}

//Descuento por distancia larga (5%)
if (distancia > 15) ;
{
    descuento = subtotal * 0.5;
    subtotal= subtotal - descuento;
}

//Tarifa minima y redondeo

tarifafinal = Math.Max(subtotal, 5.00);
tarifafinal = Math.Round(tarifafinal, 2);

//Salida
Console.WriteLine("\n");

Console.WriteLine("Pasajero" + nombre);
Console.WriteLine("Vehículo" + Tipo_de_vehículo);
Console.WriteLine("Distancia" + distancia);
Console.WriteLine("Hora pico" + (eshorapico?"Sí (+30%)" : "No")); //InLine if

if (descuento > 0){
    Console.WriteLine("Descuento: s/" + Math.Round(descuento, 2));
    } 
    else
    {
        Console.WriteLine("No aplica descuento");
    }
Console.WriteLine("Tarifa final: s/ " + tarifafinal );









