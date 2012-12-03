using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manee.INV.Service.ServiceInf;

using Spring.Context;
using Spring.Context.Support;

namespace Manee.INV.Service.Test
{
    [TestClass]
    public class Calculator_Test
    {
        private ICalculatorService calculatorService;

        public ICalculatorService CalculatorService
        {
            set { calculatorService = value; }
        }

        [TestMethod]
        public void TestMultiply()
        {
            IApplicationContext appContext = ContextRegistry.GetContext();

            calculatorService = (ICalculatorService)appContext.GetObject("calculatorService");
            
            double expected = 2 * 2;

            double actual = calculatorService.multiply(2, 2);

            Assert.AreEqual(expected, actual, "Failed");
        }
    }
}
