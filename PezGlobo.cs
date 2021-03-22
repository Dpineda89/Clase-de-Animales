using System;
public class PezGlobo: Peces // <- Herencia
{
    public string Escamas { get; set; }

        public void Defensa() // <- Abstraccion
    {
        Console.WriteLine("Inflaser");
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
        Console.WriteLine("Velocidad Lenta");
    }
    public override void Comer()
    {
        Console.WriteLine("El pez Globo come algas");
    }

    public override void Mascota()
    {
        Console.WriteLine("El pez Globo es Mascota");
    }
        public override void Nadar()
    {
        Console.WriteLine("El pez Globo si es una mascota con poco mas de delicadeza");
    }
}
