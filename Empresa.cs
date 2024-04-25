using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace Empresa
{
    class Empresa
    {
        //Propiedades privadas
        private string nombreEmpresa;
        private Empleado empleado;

        //Encapsulamiento
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            private set { nombreEmpresa = value; }
        }

        internal Empleado Empleado
        {
            get { return empleado; }
            private set { empleado = value; }
        }


        //Builder
        public Empresa(string nombreEmpresa, Empleado empleado)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.empleado = empleado;
        }
        public override string ToString()
        {
            return $"Empresa: {NombreEmpresa} ";
        }

        public void Mostrar()
        {
            Console.WriteLine($"Empresa: {nombreEmpresa}");
            Empleado.MostrarInformacion();
        }
    }
}

