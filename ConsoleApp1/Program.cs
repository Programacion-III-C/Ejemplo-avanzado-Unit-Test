using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaModelo p = new PersonaModelo();
            p.Obtener(p.GetLastId());
            Console.WriteLine(p.Id);
            Console.ReadKey();

        }
    }
}
