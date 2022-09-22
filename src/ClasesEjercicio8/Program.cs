using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos instancias 
            Familia Nuevo = new Familia("ninguno");//Llama al constructor por defecto
            Gato gatoSimpson = new Gato();//Llama al constructor por defecto
            
            Perro perroSimpson = new Perro("Ayudante de Santa");//Llaman al segundo constructor
            Humano hijoSimpson = new Humano("Bart");
            Humano hijaSimpson = new Humano("Lisa");
            
            //Utilizo las instancias
            perroSimpson.ladrar();
            gatoSimpson.maullar();
            gatoSimpson.respirar();
            Nuevo.respirar();
            Console.WriteLine(Nuevo.getInfo());
            hijaSimpson.hablar();

            Console.WriteLine("");
            Console.WriteLine(gatoSimpson.getInfo());
            gatoSimpson.setInfo("Bola de Nieve");
            Console.WriteLine(gatoSimpson.getInfo());
            Console.WriteLine("");
            
            Console.WriteLine(perroSimpson.getInfo());
            perroSimpson.setApodoPerro("huesos");
            Console.WriteLine(perroSimpson.getApodoPerro());

            Console.Read();
        }
    }
    
    class Familia
    {
        //Campos de clases o variables
        private string nombreIntegrante;
        
        //Constructores
        public Familia()
        {
            this.nombreIntegrante = "nada";
        }
        public Familia(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        //Getters y Setters
        public string getInfo()
        {
            return(nombreIntegrante);
        }
        public void setInfo( string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        //Metodos de la clase
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
    }
   
    class Gato
    {
        //Campos de clases o variables
        private string nombreIntegrante;
        
        //Constructores
        public Gato()
        {
            this.nombreIntegrante = "nada";
        }
        public Gato(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }
        
        //Getters y Setters
        public string getInfo()
        {
            return(nombreIntegrante);
        }
        public void setInfo( string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        //Metodos de la clase
         public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void maullar()
        {
            Console.WriteLine("miau");
        }
    }
    
    class Perro
    {
        //Campos de clases o variables
        private string nombreIntegrante;
        private string apodo;
        
        //Constructores
        public Perro()
        {
            this.nombreIntegrante = "nada";
        }
        public Perro(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }
        
        //Getters y Setters 
        public string getInfo()
        {
            return(nombreIntegrante);
        }
        public void setInfo( string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }
        public void setApodoPerro(string apodo)
        {
            this.apodo = apodo;
        }
        public string getApodoPerro()
        {
            return (this.apodo);
        }

        //Metodos de la clase
         public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void ladrar()
        {
            Console.WriteLine("gua");
        }
    }
    
    class Humano
    {
        //Campos de clases o variables
        private string nombreIntegrante;

        //Constructores
        public Humano()
        {
            this.nombreIntegrante = "nada";
        }
        public Humano(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        //Getters y Setters
        public string getInfo()
        {
            return(nombreIntegrante);
        }
        public void setInfo( string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        //Metodos de la clase
         public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void hablar()
        {
            Console.WriteLine("soy una persona");
        }
    }
}
