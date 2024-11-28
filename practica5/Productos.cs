using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5
{
    internal class Productos
    {
        private string[] producto = new string[0];
        private double[] precio = new double[0];
        private int cantidad;
        public void registrar()
        {
            Array.Resize(ref producto, producto.Length + 1);
            Array.Resize(ref precio, precio.Length + 1);
            Console.Write("\nIngrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            if (buscar(nombre) == -1)
            {
                producto[cantidad] = nombre;
                Console.Write("Ingrese el precio del producto: ");
                double precioPro = double.Parse(Console.ReadLine());
                precio[cantidad] = precioPro;
                cantidad++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProducto registrado con éxito!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nProducto ya se encuentra registrado!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void mostrar()
        {
            for (int y = 0; y < cantidad; y++)
            {
                Console.SetCursorPosition(0, 14);
                Console.Write("POSICIÓN");
                Console.SetCursorPosition(10, 14);
                Console.Write("PRODUCTO");
                Console.SetCursorPosition(30, 14);
                Console.Write("PRECIO" + "\n");
                for (int x = 0; x < cantidad; x++)
                {
                    Console.SetCursorPosition(0, x + 15);
                    Console.Write(x);
                    Console.SetCursorPosition(10, x + 15);
                    Console.Write(producto[x]);
                    Console.SetCursorPosition(30, x + 15);
                    Console.Write(precio[x] + "\n");
                }
            }
        }
        public int buscar(string pro)
        {
            int indice = Array.IndexOf(producto, pro);
            return indice;
        }
        public void eliminar(string nombreEliminar)
        {
            if (buscar(nombreEliminar) != -1)
            {
                for (int j = buscar(nombreEliminar); j < cantidad - 1; j++)
                {
                    producto[j] = producto[j + 1];
                    precio[j] = precio[j + 1];
                }
                Array.Resize(ref producto, producto.Length - 1);
                Array.Resize(ref precio, precio.Length - 1);
                cantidad--;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProducto eliminado con éxito!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nProducto no existe!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void ordenar()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - i - 1; j++)
                {
                    if (string.Compare(producto[j], producto[j + 1]) > 0)
                    {
                        string temp = producto[j];
                        double temp2 = precio[j];
                        producto[j] = producto[j + 1];
                        precio[j] = precio[j + 1];
                        producto[j + 1] = temp;
                        precio[j + 1] = temp2;
                    }
                }
            }
            Console.WriteLine("\nSe ordeno satisfactoriamente!");
        }
        public void modificar()
        {
            Console.Write("\nIngrese producto a modificar: ");
            string pro = Console.ReadLine();
            int indice = buscar(pro);
            if (indice != -1)
            {
                Console.Write("\nIngrese el nuevo producto: ");
                string nuevo_pro = Console.ReadLine();
                Console.Write("Ingrese su nuevo precio: ");
                double nuevo_pre = double.Parse(Console.ReadLine());
                producto[indice] = nuevo_pro;
                precio[indice] = nuevo_pre;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProducto modificado correctamente!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nProducto no existe!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
