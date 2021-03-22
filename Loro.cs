using System;
public class Loro: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Plumaje { get; set; }
    
    public Loro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Loro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Hablar");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Un Ave Mediana");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Console.WriteLine("Velocidad normal");
    }

    public override void Volar()
    {
        Console.WriteLine("El Loro vuela mas Bajo");
    }

    public override void Comer()
    {
        Console.WriteLine("El Loro come granos y semillas");
    }
}