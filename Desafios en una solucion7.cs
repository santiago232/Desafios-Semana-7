using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char[,] tablero = new char[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = ' ';
            }
        }

        MostrarTablero(tablero);

        int[,] compras = {
            {100, 150, 200, 120, 180},
            {80, 90, 120, 150, 100},
            {200, 180, 250, 300, 220},
            {150, 160, 170, 140, 190},
            {300, 280, 320, 350, 290}
        };

        CalcularTotalesYDescuentos(compras);

        List<string> tareas = new List<string>();

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Mostrar tareas");
            Console.WriteLine("3. Salir");

            Console.Write("Elija una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la tarea: ");
                    string nuevaTarea = Console.ReadLine();
                    tareas.Add(nuevaTarea);
                    Console.WriteLine("Tarea agregada con éxito.");
                    break;
                case "2":
                    Console.WriteLine("\nLista de tareas:");
                    foreach (var tarea in tareas)
                    {
                        Console.WriteLine(tarea);
                    }
                    break;
                case "3":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, elija nuevamente.");
                    break;
            }
        }
    }

    static void MostrarTablero(char[,] tablero)
    {
        Console.WriteLine("Tablero de ToTiTo:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j]);
                if (j < 2)
                {
                    Console.Write(" | ");
                }
            }
            Console.WriteLine();
            if (i < 2)
            {
                Console.WriteLine("---------");
            }
        }
    }

    static void CalcularTotalesYDescuentos(int[,] compras)
    {
        for (int cliente = 0; cliente < compras.GetLength(0); cliente++)
        {
            int totalCompras = 0;
            for (int compra = 0; compra < compras.GetLength(1); compra++)
            {
                totalCompras += compras[cliente, compra];
            }

            double descuento = 0;
            if (totalCompras >= 500)
            {
                descuento = totalCompras * 0.1;
            }

            Console.WriteLine($"Cliente {cliente + 1}: Total compras = {totalCompras}, Descuento = {descuento}");
        }
    }
}
