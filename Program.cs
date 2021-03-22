using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();
// Mamifero
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("******************** Mamifero ********************");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Perro p = new Perro();
            p.Nombre = "Perro: Shepsky";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine("Numero de patas:" + p.Patas);
            Console.WriteLine("");

            Gato g = new Gato("Gato: Chay",4,"Si");
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine("Numero de patas:" + g.Patas);
            Console.WriteLine("");

            Caballo c = new Caballo();
            c.Nombre = "Caballo: Shire";
            c.Patas = 4;
            c.Melena = "Liso";
            c.Comer();
            c.Caminar();
            c.Relinchar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine("Numero de patas:" + c.Patas);
            Console.WriteLine("");

            Mono m = new Mono();
            m.Nombre = "Mono: Kandti";
            m.Patas = 4;
            m.Pelaje = "Negro y Cafe";
            m.Comer();
            m.Caminar();
            m.Maullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine("Numero de patas:" + m.Patas);
            Console.WriteLine("");
// AVES     
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("********************** Aves ********************* ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            Aguila a = new Aguila();
            a.Nombre = "Aguila : Real";
            a.Plumaje = "Color  : Negro y Cafe";
            a.Comer();
            a.Volar();
            a.Tamano();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Plumaje);
            Console.WriteLine("");

            Loro l = new Loro();
            l.Nombre = "Loro: Cacatúa";
            l.Plumaje = "Color: Blanco con Copo Verde";
            l.Comer();
            l.Hablar();
            l.Tamano();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Plumaje);
            Console.WriteLine("");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("********************* PECES **********************");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            PezGlobo pg = new PezGlobo();
            pg.Nombre = "Pez: Globo";
            pg.Escamas = "Color: Amarillo Con Negro ";
            pg.Aletas = 3;

            pg.Defensa();
            pg.Tamano();

            Console.WriteLine(pg.Nombre);
            Console.WriteLine(pg.Escamas);
            Console.WriteLine("Numero de Aletas:" + pg.Aletas);
            Console.WriteLine("");

            PezDorado pd = new PezDorado();
            pd.Nombre = "Pez: Dorado";
            pd.Escamas = "Color: Amarillo Oro ";
            pd.Aletas = 5;
            pd.Tamano();

            Console.WriteLine(pd.Nombre);
            Console.WriteLine(pd.Escamas);
            Console.WriteLine("Numero de Aletas:" +pd.Aletas);
            Console.WriteLine("");
        }
    }
}