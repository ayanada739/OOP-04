using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.IClonable_Interface
{
    internal class Employee : ICloneable
    {

        public int Id { get; set; }
        public string? Name{ get; set; }
        public decimal Salary { get; set; }

        //Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee()
        {
            
        }


        //Deep Copy
        public object Clone()
        {
            return new Employee()
            {
                Id =  Id ,
                Name = Name ,
                Salary = Salary
            };
        }

        public override string ToString()
        {
            return $" Id = {Id} , Name = {Name} , Salary = {Salary}";
        }

    }
}
