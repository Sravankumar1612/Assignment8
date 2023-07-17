using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class EmpSalary
    {
        //Method for calculating salary
        public double EmployeeSalary(int whours,int nwdays,int projecthandles,int extras) 
        {
            double Salary = 0;
            Salary = whours*nwdays*100+projecthandles*3000+extras*2000;
            return Salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int extras=0,whours,nwdays,projecthandles=0;
            //Choose the type(in the form of number assigned to them
            Console.WriteLine("Enter the type of emp(number):\n HR--- 1\nAdmin--- 2\nSoftware Developer--- 3");
            int typeofEmp=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter working hours");
            whours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No.of working days");
            nwdays = int.Parse(Console.ReadLine());
            //Check which type of employee
            if (typeofEmp < 1 && typeofEmp > 3) 
            {
                Console.WriteLine("Choose the correct employee(Number from 1-3)"); 
            }
            else if (typeofEmp == 1)
            {
                extras = 0;
                projecthandles = 0;
            }
            else if (typeofEmp == 2)
            {
                extras = 0;
                Console.WriteLine("Enter No.of projects handled");
                projecthandles = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter No.of projects handled");
                projecthandles = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Extra working days");
                extras = int.Parse(Console.ReadLine());
            }
            EmpSalary empSalary = new EmpSalary();
            //return the salary amount
            Console.WriteLine( empSalary.EmployeeSalary(whours,nwdays,projecthandles,extras));
            Console.ReadKey();
        }
    }
}
