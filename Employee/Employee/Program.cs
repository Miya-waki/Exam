using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee(1,"Amol",123465,10);
            Employee o2 = new Employee(2, "Vaibhav",123465);
            Employee o3 = new Employee(3, "Hemant");
            Employee o4 = new Employee(4);
            Employee o5 = new Employee();

            Console.WriteLine("EmpNo: " + o1.EmpNoProp + "\n" + "Name: " + o1.NameProp + "\n" + "Basic: " 
                + o1.BasicProp + "\n" + "DeptNo: " + o1.DeptNoProp + "\n" + "Net Salary: " + o1.GetNetSalary() + "\n");

            o2.DeptNoProp = 12;
            Console.WriteLine("EmpNo: " + o2.EmpNoProp + "\n" + "Name: " + o2.NameProp + "\n" + "Basic: " 
                + o2.BasicProp + "\n" + "DeptNo: " + o2.DeptNoProp + "\n" + "Net Salary: " + o2.GetNetSalary() + "\n");

            o3.BasicProp = 430000;
            o3.DeptNoProp = 9;
            Console.WriteLine("EmpNo: " + o3.EmpNoProp + "\n" + "Name: " + o3.NameProp + "\n" + "Basic: " 
                + o3.BasicProp + "\n" + "DeptNo: " + o3.DeptNoProp + "\n" + "Net Salary: " + o3.GetNetSalary() + "\n");

            o4.NameProp = "Konark";
            o4.BasicProp = 520000;
            o4.DeptNoProp = 8;
            Console.WriteLine("EmpNo: " + o4.EmpNoProp + "\n" + "Name: " + o4.NameProp + "\n" + "Basic: " 
                + o4.BasicProp + "\n" + "DeptNo: " + o4.DeptNoProp + "\n" + "Net Salary: " + o4.GetNetSalary() + "\n");

            o5.EmpNoProp = -1;
            o5.NameProp = "    ";
            o5.BasicProp = 100000;
            o5.DeptNoProp = 0;
            Console.WriteLine("EmpNo: " + o5.EmpNoProp + "\n" + "Name: " + o5.NameProp + "\n" + "Basic: " 
                + o5.BasicProp + "\n" + "DeptNo: " + o5.DeptNoProp + "\n" + "Net Salary: " + o5.GetNetSalary() + "\n");

            Console.ReadLine();
        }
    }

    class Employee
    {
        private string Name;
        private int EmpNo;
        private decimal Basic;
        private short DeptNo;

        public Employee()
        {

        }

        public Employee(int EmpNo)
        {
            this.EmpNo = EmpNo;
        }

        public Employee(int EmpNo,string Name)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
        }

        public Employee(int EmpNo, string Name,decimal Basic)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
        }

        public Employee(int EmpNo, string Name, decimal Basic, short DeptNo)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public string NameProp
        {
            set
            {
                string str = "";
                char[] chars = value.ToCharArray();

                foreach (char ch in chars)
                {
                    if(ch != ' ')
                        str += ch;
                }

                if (!str.Equals(""))
                    Name = value;
                else
                    Console.WriteLine("Name field should not be blank");
            }
            get
            {
                return Name;
            }
        }

        public int EmpNoProp
        {
            set
            {
                if(value > 0)
                    EmpNo = value;
                else
                    Console.WriteLine("Employee Number must be greater than 0");
            }
            get
            {
                return EmpNo;
            }
        }

        public decimal BasicProp
        {
            set
            {
                if(value > 200000 && value < 600000)
                    Basic = value;
                else
                    Console.WriteLine("Basic value must be between 200000 and 600000");
            }
            get
            {
                return Basic;
            }
        }

        public short DeptNoProp
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Department Number must be greater than 0");
            }
            get
            {
                return DeptNo;
            }
        }

        public decimal GetNetSalary()
        {
            decimal Deductions = 25000;
            decimal NetSalary = Basic - Deductions;

            return NetSalary;
        }
    }
}
