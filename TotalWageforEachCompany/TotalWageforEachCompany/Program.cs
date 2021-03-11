using System;

namespace TotalWageforEachCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 20, 2, 10);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.tostring());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.tostring());
        }
    }
}
