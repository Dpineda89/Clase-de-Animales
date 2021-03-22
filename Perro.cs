using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Perro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() // <- Abstraccion
    {
        Console.WriteLine(" El Perro Hace:  ---> Guau... Guau... Guau... ");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un Perro Grande");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Console.WriteLine("Es una Mezcla entre un pastor y un Siberiano");
        Console.WriteLine("Es un perro inteligente y obediente");
    }

    public override void Comer()
    {
        Console.WriteLine("Él perro come doggie");
    }

    public override void Caminar()
    {
        Console.WriteLine("El perro camina en 4 patas");
    }

    public override void Cabello()
    {
        Console.WriteLine("El perro tiene cabello liso");
    }
}