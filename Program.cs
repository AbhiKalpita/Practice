using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//----------------------------Interface Example--------------------
/*interface IFirstName
{
    void FirstName();
}
interface ILastName
{
    void LastName();
}

class FullName : IFirstName, ILastName
{
    public void FirstName()
    {
        Console.Write("Abhishek ");
    }
    public void LastName()
    {
        Console.WriteLine("Ranjan");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FullName name = new FullName();
        name.FirstName();
        name.LastName();
    }
}*/

//--------------Polymorphism Example-----------------
//----Compiletime polymorphism(method overloading)----
/*class Program
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static double add(double a, double b)
    {
        return a + b;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Program.add(2, 3));
        Console.WriteLine(Program.add(2.0, 3.0));

    }
}*/
//----Runtime polymorphism(method overriding)(To perform method overriding in C#, you need to use virtual keyword with base class method and override keyword with derived class method.)
/*class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating..");
    }
}
class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating Bread..");
    }
}
class Overriding
{
   public static void Main(string[] args)
    {
        Dog over = new Dog();
        over.eat();
    }
}*/
   
//-------------------------------Inheritance-------------------------
//----SingleInheritance----
/*class Parent
{
    public void dad(){
        
   Console.WriteLine("I'm Parent");
    }
}
class Child : Parent
{
   public void son(){
       Console.WriteLine("I'm Child");
   }
}
class SingleInheritance
{
    public static void Main(string[] args){

    Child child = new Child();
    child.dad();
    child.son();
    }
}
*/
//----MultiLevel Inheritance----
/*class Parent
{
   public void dad(){ Console.WriteLine("I'm Parent.");}
}
class Son : Parent
{
   public void son(){ Console.WriteLine("I'm Son.");}
}
class GrandeSon : Son
{
   public void gson(){ Console.WriteLine("I'm GrandSon.");}
}
class Program
{
    public static void Main(string[] args)
    {
    GrandeSon grandson = new GrandeSon();
    grandson.dad();
        grandson.son();
        grandson.gson();
    }

}
*/
//----Herarchical Inheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm Dad");
    }
}
class Son : Parent
{
    public void son()
    {
        Console.WriteLine("I'm Son");
    }
}
class GrandSon : Parent
{
    public void gson()
    {
        Console.WriteLine("I'm GrandSon");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        GrandSon grandson = new GrandSon();
        grandson.dad();
        grandson.gson();
        //grandson.son();    //CompileTime Error
    }
}
*/
//----MultipleInheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm dad");
    }
}
class Son
{
    public void son()
    {
        Console.WriteLine("I'm Son");
    }
}
class GrandSon: Son, Parent
{
    public void gson()
    {
        Console.WriteLine("I'm grandSon");
    }
}
*/
//------------------------Abstraction-----------------------
/*abstract class Parent
{
    public abstract void dad();
    public void who()
    {
        Console.WriteLine("I'm Dad.");
    }
}
class Son: Parent
{
    public override void dad()
    {
        Console.WriteLine("I'm Son.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Son son = new Son();
        son.dad();
        son.who();
    }
}
*/