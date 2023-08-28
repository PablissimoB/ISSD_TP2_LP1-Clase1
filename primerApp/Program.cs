using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerApp
{
    class Persona
    {
        public string nombre;
        public int edad;
        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Método para saludar
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}.");
        }
    }

    class Program
    {
        string Saludo(string arg)
        {
            return "Hola desde funcion de "+arg;
        }
        static string SaludoEstatico()
        {
            return "Hola desde funcion estatico";
        }
        void Saludar()
        {
            Console.WriteLine("Hola desde metodo ejecutado por instancia de clase Program");
        }

        static void Main(string[] args)
        {
            Program programa = new Program();
            Console.WriteLine("Hola Mundo");//Saludo Harcodeado
            Console.WriteLine(programa.Saludo("objetoProgram"));//Saludo desde impresion de metodo de objetoProgram
            Console.WriteLine(SaludoEstatico());//Saludo desde impresion de funcion estatico
            programa.Saludar();//Saludo desde metodo de objeto programa
            Persona persona = new Persona("Pedro",25);
            persona.Saludar();//saludo desde metodo de objeto persona
            if(persona.nombre == "Pablo")
            {
                Console.WriteLine("Hola Pablo");
            }
            else
            {
                Console.WriteLine("Hola "+persona.nombre);//saludo desde condicional
            }
            switch (persona.nombre)
            {
                case "Pablo": Console.WriteLine("Hola Pablo");break;
                case "Pedro": Console.WriteLine("Hola Pedro"); break;
                case "default": Console.WriteLine("Hola Persona no identificada"); break;
            }//saludo desde switch
            string saludo = persona.nombre == "Pablo" ? "Hola Pablo" : "Hola " + persona.nombre;
            Console.WriteLine(saludo);//saludo desde ternario
            int anioNacimiento = DateTime.Now.Year;
            Console.WriteLine(anioNacimiento);
            for (int i = 0; i < persona.edad; i++)
            {
                anioNacimiento -= 1;
            }
            Console.WriteLine(anioNacimiento);
            bool verificador = true;
            int edad = persona.edad;
            int contadorLustros = 0;
            while (verificador)
            {
                contadorLustros++;
                edad -= 5;
                if (edad == 0)
                {
                    verificador = false;
                    Console.WriteLine(contadorLustros);
                }
            }
            foreach (string arg in args)
            {
                Console.WriteLine("Argumento: "+arg);
            }
        }
    }
}
