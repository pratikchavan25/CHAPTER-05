// See https://aka.ms/new-console-template for more information

// 5. WAP to accept a number from the user & check number is +ve or -ve or zero ?

using System.ComponentModel.Design;

Console.WriteLine("enter a number");

int number  = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Number is positive");
}
else if (number < 0)
{
    Console.WriteLine("Number is negative");
}
else if (number == 0)
{
    Console.WriteLine("Number is equal to zero");
}
else
{
    Console.WriteLine(" ");
}



