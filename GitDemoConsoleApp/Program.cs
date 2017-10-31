using System;
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
            string welcomeMessage = "Hello World: Welcome to Git Demo";
            string closeMessage = "\r\n\r\n\r\nPress 'Enter' to close";

            //display our welcome message
            Console.WriteLine(welcomeMessage);

            //wait for user input so we can read the screen
            Console.WriteLine(closeMessage);
            Console.ReadLine();
        }
    }
}
