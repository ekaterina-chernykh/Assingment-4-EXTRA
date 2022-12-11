// Created by: Ekaterina
// Created on: Dec 2022
//
// This program multiplies with and addition while loop

using System;

class Program
{
    public static void Main(string[] args)
    {
        string donutype;
        int amount;
        double price;
        Console.WriteLine("Ekaterina's Small Bakery :)");
        Console.WriteLine("Order your donuts!!");
        Console.WriteLine("Pick a flavour: ");
        Console.WriteLine("1) Old-fashioned");
        Console.WriteLine("2) Chocolate");
        Console.WriteLine("3) Glazed");
        ConsoleKeyInfo donut = Console.ReadKey();
        if (donut.KeyChar.ToString() == "1")
        {
            donutype = "Old-fashioned";
        }
        else if (donut.KeyChar.ToString() == "2")
        {
            donutype = "Chocolate";
        }
        else if (donut.KeyChar.ToString() == "3")
        {
            donutype = "Glazed";
        }
        else
        {
            Console.WriteLine("Invalid option!");
            return;
        }
        Console.Clear();
        Console.WriteLine("Pick an amount: ");
        Console.WriteLine("1) 1 Donut - $2.25");
        Console.WriteLine("2) 2 Donuts - $4.75");
        Console.WriteLine("3) 3 Donuts - $6.70");
        Console.WriteLine("4) 6 Donuts - $10.50");
        Console.WriteLine("5) 12 Donuts - $16.50");
        ConsoleKeyInfo choice = Console.ReadKey();
        if (choice.KeyChar.ToString() == "1")
        {
            amount = 1;
            price = 2.25;
        }
        else if (choice.KeyChar.ToString() == "2")
        {
            amount = 2;
            price = 4.75;
        }
        else if (choice.KeyChar.ToString() == "3")
        {
            amount = 3;
            price = 6.70;
        }
        else if (choice.KeyChar.ToString() == "4")
        {
            amount = 6;
            price = 10.50;
        }
        else if (choice.KeyChar.ToString() == "5")
        {
            amount = 12;
            price = 16.50;
        }
        else
        {
            Console.WriteLine("Invalid option!");
            return;
        }
        Console.Clear();
        Console.WriteLine("Donut: " + donutype);
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("\nDone.");
    }
}