using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    internal class Empleado
    {
        private string name;
        private string job;
        private byte age;

        //Encapsulamiento
        public string Nombre
        {
            get { return name; }
            private set { name = value; }
        }
        public string Cargo
        {
            get { return job; }
            private set { job = value; }
        }
        public byte Edad
        {
            get { return age; }
            private set { age = value; }
        }

        //Constructor
        public Empleado(string name, byte age, string job)
        {
            this.name = name;
            this.job = job;  
            this.age = age;
        }

        public override string ToString()
        {
            return $"Empleado: {Nombre} Edad: {Edad}  Cargo: {Cargo} ";
        }

        public void MostrarInformacion()
        {
            string informe = $"Nombre del empleado: {this.Nombre} \nEdad: {this.Edad} \nCargo en la empresa: {this.Cargo}";
            Console.WriteLine(informe);
        }

    }
}
