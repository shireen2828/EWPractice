using System;

namespace EmpWagePractice
{
    class UC1_EmpPorA
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
            UC2_PartTimeEmpWage.Empwage();
        }
    }
}
