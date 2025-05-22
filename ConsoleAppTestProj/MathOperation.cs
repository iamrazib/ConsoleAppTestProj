using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestProj
{
    public class MathOperation
    {
        public int addition(int a, int b) {  return a + b; }
        public int multi(int a, int b) {return a * b; }
        public double divide(double a, double b) {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }
}
