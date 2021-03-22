using System;
public class Aguila: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Plumaje { get; set; }

    public Aguila() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Aguila(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    /*public void Volar() // <- Abstraccion
    {
        Console.WriteLine("Vuela alto");
    }*/

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
        Console.WriteLine("Velocidad alta");
    }
    public override void Comer()
    {
        Console.WriteLine("Él aguila come ratones");
    }

    public override void Volar()
    {
        Console.WriteLine("Él aguila vuela mas alto que los demas animales");
    }
}