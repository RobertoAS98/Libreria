using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Autores
    {
        private string nombre;
        private string nacionalidad;
        private int nacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Nacimiento { get => nacimiento; set => nacimiento = value; }

        public Autores(string nombre, string nacionalidad, int nacimiento)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            Nacimiento = nacimiento;
        }
        public void Imprime()
       
        {
            Console.WriteLine($"{nombre} ({nacionalidad}) ({nacimiento})");
        }


        class Libro
        {
            private string titulo;
            private int año;
            private Editorial editorial;
            private List<Autores>autores= new List<Autores>();


            

        

            public Libro (string titulo, int año, Editorial editorial)
            {
                 this.Titulo = titulo;
                this.Año = año;
                this.Editorial = editorial;
                

            }

            public string Titulo { get => titulo; set => titulo = value; }
            public int Año { get => año; set => año = value; }
            private Editorial Editorial { get => editorial; set => editorial = value; }

            public void AgregaAutor(Autores autor)
            {
                autores.Add(autor);
            }
            
            public void AgregaAutor(string nombre, string nacionalidad, int nacimiento)
            {
             autores.Add(new Autores(nombre, nacionalidad, nacimiento));


            }
            
            
            public void Imprime()

            {
                Console.WriteLine($"{Titulo} ({Año}) {editorial.Nombre}, {editorial.Pais}");
                foreach (Autores a in autores)
                {
                    a.Imprime();
                    
                }
            }
        }
        class Editorial
        {
            private string nombre;
            private string pais;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Pais { get => pais; set => pais = value; }

            public Editorial (string nombre , string pais)
            {
                Nombre = nombre;
                Pais = pais;
            }
            public void Imprime()

            {
                Console.WriteLine($"{Nombre} , {Pais}");
            }
            
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Autores
                Autores Stephen = (new Autores("Stephen Hawking", "Británico", 1942));
                Autores Suzzane = (new Autores("Suzzane Collins", "Americana", 1962));
                Autores Vegetta777 = (new Autores("Vegetta 777 y Wilyrex", "Españoles", 1983));

                //Libros
                Libro l1 = new Libro("A brief history of time", 1988, new Editorial("Bantman Books", "England"));
                l1.AgregaAutor(Stephen);
                l1.Imprime();
                Libro l2 = new Libro("Hunger Games: Sinsajo", 2010, new Editorial("Scholastic Corporation", "United States"));
                l2.AgregaAutor(Suzzane);
                l2.Imprime();
                Libro l3 = new Libro("Wigetta", 2015,new Editorial("Planeta de Libros", "España"));
                l3.AgregaAutor(Vegetta777);
                l3.Imprime();

                Console.ReadKey();
            }

        }



    }
}
