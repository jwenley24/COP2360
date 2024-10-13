/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Car
{
   public int wheels;
   public string color;
   public int year;
   
   Car()
   {
       year = 1950;
       wheels = 4;
       Color = "Black";
   }
   
   Car(int Year, int Wheels, string Color)
   {
       this.year = Year;
       this.color = Color;
       this.wheels = wheels;
   }
   
   public void info()
   {
       Console.WriteLine("Wheels: " +wheels );
       Console.WriteLine("Color: " +color );
       Console.WriteLine("Year: " +whyeareels );
   }
   
   
}
class HelloWorld {
  static void Main() {
    Car car = new Car(1988,4,"White");
    car.info();
    
  }
}