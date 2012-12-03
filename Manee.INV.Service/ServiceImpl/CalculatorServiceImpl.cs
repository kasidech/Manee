using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;

namespace Manee.INV.Service.ServiceImpl
{
    public class CalculatorServiceImpl : ICalculatorService
    {
        private ICalculatorDAO calculatorDAO;

        public ICalculatorDAO CalculatorDAO
        {
            set { this.calculatorDAO = value; }
        }


        public double multiply(double a, double b)
        {
            return calculatorDAO.multiply(a, b);
        }
    }
}
