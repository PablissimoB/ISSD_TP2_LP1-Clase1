using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerApp
{
    // declaracion de clases Ejercitacion
     class Institucion
    {
        //declaracion de atributos
        public string Name;
        public DateTime fechaFundacion;
        
        //metodo constructor
        public Institucion (string name, DateTime fechaFundacion)
        {
            this.Name = name;
            this.fechaFundacion = fechaFundacion;
        }
        //funcion
        public int cantidadAnios()
        {
            return DateTime.Now.Year - fechaFundacion.Year;
        }

    }
    // declaracion de clases
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
        public void saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}.");
        }
    }

    //Clase Program
    class Program
    {
        //funcion que recibe un argumento
        string saludo(string arg)
        {
            return "Hola desde funcion de "+arg;
        }
        //Funcion estatica
        static string saludoEstatico()
        {
            return "Hola desde funcion estatico";
        }
        //Metodo
        void saludar()
        {
            Console.WriteLine("Hola desde metodo ejecutado por instancia de clase Program");
        }

        //Funcion ejercitacion
        static int potencia (int basePotencia, int exponente)
        {
            int resultado = 1;
            //uso de for
            for(int i = 0; i < exponente; i++)
            {
                resultado = resultado* basePotencia;
            }

            return resultado;
        }

        //Funcion ejercitacion
        static int factorial( int numero)
        {
            int resultado = 1;
            //uso de for
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Program programa = new Program(); //creacion de objeto de clase Program
            DateTime fecha = new DateTime(2000,12,2);
            Institucion institucion = new Institucion("ISSD", fecha);
            Console.WriteLine(institucion.cantidadAnios());
            Console.WriteLine("Hola Mundo");//Saludo Harcodeado
            Console.WriteLine(programa.saludo("objetoProgram"));//Saludo desde impresion de metodo de objetoProgram
            Console.WriteLine(saludoEstatico());//Saludo desde impresion de funcion estatico
            programa.saludar();//Saludo desde metodo de objeto programa
            Persona persona = new Persona("Pedro", 25);
            persona.saludar();//saludo desde metodo de objeto persona
            // uso de if
            if (persona.nombre == "Juan")
            {
                Console.WriteLine("Hola Juan");
            }
            else if (persona.nombre == "Pedro")
            {

            }
            else
            {
                Console.WriteLine("Hola " + persona.nombre);//saludo desde condicional
            }
            //uso de operador ternario
            string mayorDe18 = persona.edad > 18 ? "es mayor" : "es menor";
            Console.WriteLine("La persona "+mayorDe18);
            //uso de switch
            switch (persona.nombre)
            {
                case "Pablo": Console.WriteLine("Hola Pablo"); break;
                case "Pedro": Console.WriteLine("Hola Pedro"); break;
                case "default": Console.WriteLine("Hola Persona no identificada"); break;
            }//saludo desde switch
            string saludo = persona.nombre == "Pablo" ? "Hola Pablo desde ternario" : "Hola desde ternario" + persona.nombre;
            Console.WriteLine(saludo);//saludo desde ternario
            int anioNacimiento = DateTime.Now.Year;
            for (int i = 0; i < persona.edad; i++)
            {
                anioNacimiento -= 1;
            }
            Console.WriteLine("El año de nacimiento es " + anioNacimiento);
            Console.WriteLine("El factorial de 5 es "+factorial(5));
            Console.WriteLine("La potencia de 3 elevado a la 3 es "+potencia(3,3));
            bool verificador = true;
            int edad = persona.edad;
            int contadorLustros = 0;
            //uso de while
            while (verificador)
            {
                contadorLustros++;
                edad -= 5;
                if (edad == 0)
                {
                    verificador = false;
                    Console.WriteLine("La cantidad de lustros es de " + contadorLustros);
                }
            }
            //uso de foreach con argumentos del metodo Main
            foreach (string arg in args)
            {
                Console.WriteLine("Argumento: " + arg);
            }
        }
    }
}
