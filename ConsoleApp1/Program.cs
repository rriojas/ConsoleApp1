using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Contacto x;
      x = new Contacto();
      Console.WriteLine("Nombre");
      x.Nombre = Console.ReadLine();
      Console.WriteLine("Telefono");
      x.Telefono = Console.ReadLine();
      x.FechaNacimiento = DateTime.Parse("2003/01/01");

      Console.WriteLine(x.ToString());
   

      Console.ReadKey();
    }
  }
}
