﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KolchakovaA.Sprint0.Task0.V0.Lib;

namespace Tyuiu.KolchakovaA.Sprint0.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //Из библиотеки Tyuiu.KolchakovaA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Амира"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
