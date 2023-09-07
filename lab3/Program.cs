//Lab #3
//Alan Velazquez
//09/07/2023
//Doing math and an pyramids of the ABC

using System;

//ABC with 5 output lines
Console.WriteLine("    A    ");
Console.WriteLine("   BCD   ");
Console.WriteLine("  EFGHI  ");
Console.WriteLine(" JKLMNOP ");
Console.WriteLine("QRSTUVWXYZ");

Console.WriteLine("");//creastes a space between the two ABC

//ABC with one output line
Console.WriteLine("    A    \n   BCD    \n  EFGHI  \n JKLMNOP \nQRSTUVWXYZ");


Console.WriteLine("");//creates a space between the ABC and the Math program

//Math
Console.Write("Enter first integer: ");//ask for the first integer
string text= Console.ReadLine(); //stores answer as an string
int num1 = int.Parse(text); //converst the string into an integer

Console.Write("Enter second integer: ");//ask for the second integer
string text2= Console.ReadLine();//stores answer as an string
int num2 = int.Parse(text2);//converst the string into an integer

Console.WriteLine("");//makes a space between te input and output

int sum = num1 + num2; //adds the two inputs
Console.WriteLine($"Sum is............{sum}");//prints the answer

int sub = num1 - num2; //subtracts the two inputs
Console.WriteLine($"DIfference is ....{sub}");//prints the answer

int mult = num1 * num2; //multiply the towo inputs
Console.WriteLine($"Product is........{mult}");//prints the answer

int div = num1 / num2;//divides the two inputs
Console.WriteLine($"Quotient is.......{div}");// prints the answer