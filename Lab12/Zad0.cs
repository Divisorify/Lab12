// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class A
{
    public virtual void PokazDane() { Console.WriteLine("Dane klasy A"); }
}

public class B : A
{
    public sealed override void PokazDane() { Console.WriteLine("Dane klasy B"); }
}

public class C : B
{
    // Deklaracja jest niepoprawna ponieważ 
    // metoda PokazDane została zamknięta w klasie B
    //public override void PokazDane() { Console.WriteLine("Dane klasy C"); }
}
