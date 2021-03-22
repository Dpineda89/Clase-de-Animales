using System;
public class Mono: Mamifero
{
    public string Pelaje { get; set; }

    public void Maullar()
    {
        Console.WriteLine("El Mono Hace: ---> AAaaa... Uuuuu... UaUuAAaaaa..");
    }
        public override void Comer()
    {
        Console.WriteLine("El Mono come Bananas");
    }

    public override void Caminar()
    {
        Console.WriteLine("El Mono camina en 4 patas");
    }

    public override void Cabello()
    {
        Console.WriteLine("El Mono tiene cabello liso y en otros peludo");
    }
}
