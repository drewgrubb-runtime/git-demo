﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World: Master branch");

            //write some extra messages
            Console.WriteLine("Additional message 1");
            Console.WriteLine("Additional message 2");
            
            //wait for user input so we can reat the screen
            Console.WriteLine("\r\n\r\n\r\nPress 'Enter' to close");
            Console.ReadLine();
        }
    }
}
