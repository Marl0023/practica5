using practica5;

Productos miProducto = new Productos();
int opcion;
string opcion2;
do
{

    Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE PRODUCTOS\n");
    Console.WriteLine("************* MENÚ DE OPCIONES ***********");
    Console.WriteLine("* 1 - Insertar Productos *");
    Console.WriteLine("* 2 - Mostrar Productos *");
    Console.WriteLine("* 3 - Eliminar Productos *");
    Console.WriteLine("* 4 - Ordenar productos *");
    Console.WriteLine("* 5 - Modificar productos *");
    Console.WriteLine("* 6 - Buscar productos *");
    Console.WriteLine("* 0 - Para salir del sistema *");
    Console.WriteLine("******************************************\n");
    do
    {
        Console.Write("Ingrese una opción: ");
        opcion = int.Parse(Console.ReadLine());
    } while (opcion > 6 || opcion < 0);
    switch (opcion)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            miProducto.registrar();
            break;
        case 2:
            miProducto.mostrar();
            break;
        case 3:
            Console.Write("\nIngrese el nombre a eliminar: ");
            string nom = Console.ReadLine();
            miProducto.eliminar(nom);
            break;
        case 4:
            miProducto.ordenar();
            break;
        case 5: miProducto.modificar(); break;
        case 6:
            Console.Write("\nIngrese el producto a buscar: ");
            string bu = Console.ReadLine();
            if (miProducto.buscar(bu) != -1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl producto se encuentra registrado!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nProducto no existe!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            break;
    }
    Console.Write("\nPara regresar al menú escriba [si] para salir cualquier otra tecla: ");
    opcion2 = Console.ReadLine();
    Console.Clear();
} while (opcion2 == "si");