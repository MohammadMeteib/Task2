// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter your name");
var Name = Console.ReadLine();
Console.WriteLine("Enter your language");
var Language = Console.ReadLine();
if (Language == "en")
{ Console.WriteLine("Hello "+Name); }
else if (Language == "es")
{ Console.WriteLine("Hola "+Name); 
} 
else if  (Language == "fr")
    { Console.WriteLine("Bonjour "+Name); }
else if (Language == "tr")
{ Console.WriteLine("Merhaba "+Name);
}

//////// 2
///
Console.WriteLine("--------------------------");
Console.WriteLine("Enter number 1");
string num1 = Console.ReadLine();
Console.WriteLine("Enter number 2");
string num2 = Console.ReadLine();
int Number1 = Convert.ToInt32(num1);
int Number2 = Convert.ToInt32(num2);
if (Number1 > Number2) ;
Console.WriteLine(Number1);
if  (Number2 > Number1);
        Console.WriteLine(Number2);

Console.WriteLine("---------------");

Console.WriteLine("Enter Grade");
string Grade = Console.ReadLine();
int Grades = Convert.ToInt32(Grade);
if (Grades >= 80) 
    Console.WriteLine("A");
else if (Grades >= 70 && Grades < 80)
    Console.WriteLine("B");
else if (Grades >= 60 && Grades < 70)
    Console.WriteLine("C");
else if (Grades >= 50 && Grades < 60)
    Console.WriteLine("D");
else if (Grades >= 50 && Grades < 60)
    Console.WriteLine("F");

