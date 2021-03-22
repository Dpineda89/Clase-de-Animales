using System;
public class Caballo: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Caballo() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Caballo(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Relinchar() // <- Abstraccion
    {
        Console.WriteLine("El Caballo: --->  Relincha");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un Caballo Grande");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
        public override void Comer()
    {
        Console.WriteLine("El Caballo come Hierva");
    }

    public override void Caminar()
    {
        Console.WriteLine("El Caballo camina en 4 patas");
    }

    public override void Cabello()
    {
        Console.WriteLine("El Caballo tiene cabello liso y Peludo");
    }
}