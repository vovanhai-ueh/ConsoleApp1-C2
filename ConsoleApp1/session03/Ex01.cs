using System;
using System.Collections.Generic;
using System.Text;


internal class Ex01
{
    public static void Main1(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age:");
        string string_age = Console.ReadLine();        
        byte age;
        do
        {
            bool result = byte.TryParse(string_age, out age);
            if (result == true)
            {

                Console.WriteLine($"Name= {name}, age = {age}");
                break;
            }
            else
            {
                Console.WriteLine("Nhap sai roi. Nhap lai cho dung.");
                Console.Write("Enter your age:");
                string_age = Console.ReadLine();
            }
        } while (true);
    }
}

