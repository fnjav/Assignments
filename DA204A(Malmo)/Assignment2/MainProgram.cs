// Filip Andersson Vestman 4/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 2";
            var menu = new Menu();
            menu.Start();
        }
    }
}