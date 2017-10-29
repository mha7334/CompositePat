using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Rahul = new Employee { EmpID = 1, Name = "Rahul-President" };

            Employee Amit = new Employee { EmpID = 2, Name = "Amit-VicePresident" };
            Employee Mohan = new Employee { EmpID = 3, Name = "Mohan-ExecutivePresident" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Employee Rita = new Employee { EmpID = 4, Name = "Rita-Director" };
            Employee Hari = new Employee { EmpID = 5, Name = "Hari-Director" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Employee Kamal = new Employee { EmpID = 6, Name = "Kamal-RegularEmp" };
            Employee Raj = new Employee { EmpID = 7, Name = "Raj-RegularEmp" };

            Contractor Sam = new Contractor { EmpID = 8, Name = "Sam-RegularEmp" };
            Contractor tim = new Contractor { EmpID = 9, Name = "Tim-RegularEmp" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmpID, Rahul.Name);

            foreach (Employee manager in Rahul)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                }
            }
            Console.ReadKey();
        }
    }
    }

