using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session02
{
    internal class Ex01
    {
        static void Main111(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your YOB: ");
            int yob = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            float height = Convert.ToSingle(Console.ReadLine());



            Console.WriteLine($"Họ và tên: {name}, Age: {2026-yob+1}");
            //Console.WriteLine("Họ và tên: {0}, Age: {1}",name,age);

            string greating ="\n\n\tHola \"pakon\"";
            Console.WriteLine(greating);

            Console.ReadKey();
        }
    }
}
