using System;
public class PezDorado: Peces // <- Herencia
{
    public string Escamas { get; set; }

        public void Defensa() // <- Abstraccion
    {
        Console.WriteLine("Encanto");
    }
    public void Metodos() // <- Abstraccion
    {
        Console.WriteLine("Nadando");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Pez normal");
        
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Console.WriteLine("Velocidad Normal");
        Console.WriteLine("Pez utilizado para mascota");
        Console.WriteLine("Pez de agua dulce");
    }

    public override void Comer()
    {
        Console.WriteLine("El pez Dorado come algas");
    }

    public override void Mascota()
    {
        Console.WriteLine("El pez dorado si es una mascota");
    }
        public override void Nadar()
    {
        Console.WriteLine("El pez dorado si es una mascota ligera");
    }

    
}