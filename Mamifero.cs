using System;

public abstract class Mamifero: Animal
{
    public int Patas { get; set; }

    public abstract void Caminar();
   
    public string Melena { get; set; }

    public abstract void Cabello();
}