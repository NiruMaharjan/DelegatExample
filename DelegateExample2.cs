using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate bool IsPromotable(Employee employee);

    class DelegateExample2
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { ID = 101, Name = "Niru", Experience = 2, Salary = 100000 });
            employeeList.Add(new Employee() { ID = 102, Name = "Srisha", Experience = 1, Salary = 50000, });
            employeeList.Add(new Employee() { ID = 103, Name = "Mili", Experience = 5, Salary = 499900 });
            IsPromotable promotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employeeList, promotable);
            Console.ReadKey();

        }

        public static bool Promote(Employee employee)
        {
            if(employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
           


    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligible)
        {
            foreach(Employee employee in employeeList)
            {
                if(isEligible(employee))
                {
                    Console.WriteLine("congrats " + employee.Name + " You are promoted");
                }
            }

        }
    }

    
}
