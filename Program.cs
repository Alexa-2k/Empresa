using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Empresa;

namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado bruce = new Empleado("Bruce Wayne", 45, "CEO" );
            Empresa wayne = new Empresa("Wayne Enterprises", bruce);
            
            wayne.Mostrar();
            
        }
    }
}
