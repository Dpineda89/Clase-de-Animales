using System;
public class Gato: Mamifero
{
    public Gato(string Nombre,int patas, string melena)
    {
        this.Nombre = Nombre;
        this.Melena = melena;
        this.Patas = patas;
    }

    public string Pelaje { get; set; }

    public void Maullar()
    {
        Console.WriteLine("El Gato Hace : --->  Miau miau miau");
    }
        public override void Comer()
    {
        Console.WriteLine("El Gato come Ratones");
    }

    public override void Caminar()
    {
        Console.WriteLine("El Gato camina en 4 patas");
    }

    public override void Cabello()
    {
        Console.WriteLine("El Gato Tiene Pelaje Peludo y liso");
    }
}