using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KolchakovaA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KolchakovaA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numArray = new int[] { 1, 2, 3, 4, 5, };

            //Пример циклической структуры находитя в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numArray));

            //Пример циклической структуры находитя в библиотеке классов в методе SubtactioArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numArray));

            //Пример циклической структуры находитя в библиотеке классов в методе MultplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numArray));
             Console.ReadKey();
        }

    }
}