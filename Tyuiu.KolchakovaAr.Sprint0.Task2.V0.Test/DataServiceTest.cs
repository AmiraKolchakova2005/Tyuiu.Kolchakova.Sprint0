using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KolchakovaA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KolchakovaA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid ()
        {
            //Область создания методов тестирования, методов из библиотеки
            var res = DataService.GetMessage(name);


            //Вызываем класс Assert и метод Arequal
            Assert.AreEqual("Привет, Амира", res);
        }   
    }
}
