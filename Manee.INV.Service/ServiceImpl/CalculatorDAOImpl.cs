using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;

namespace Manee.INV.Service.ServiceImpl
{
    public class CalculatorDAOImpl : ICalculatorDAO
    {
        public double multiply(double a, double b) {
            return (a * b);
        }
    }
}
