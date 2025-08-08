using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTestService;


public class Calculator
{
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
    public int Division(int a, int b)
    {
        return a / b;
    }
    public int Add(int one, int two)
    {
        return one + two;
    }
    public int Additional(int one, int two, int three)
    {
        return one + two + three;
    }
    public int Multiplication(int one, int two, int three)
    {
        return one * two * three;
    }
}

