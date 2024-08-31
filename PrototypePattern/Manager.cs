using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Manager : Employee
    {
        public int NumberOfSubordinates { get; set; }
        public string Department { get; set; }

        public Manager(string name, string position, decimal salary, int numberOfSubordinates, string department)
            : base(name, position, salary)
        {
            NumberOfSubordinates = numberOfSubordinates;
            Department = department;
        }

        public override Employee MyClone()
        {
            return new Manager(this.Name, this.Position, this.Salary, this.NumberOfSubordinates, this.Department);
        }

        public override string ToString()
        {
            return $"Manager: Name = {Name}, Position = {Position}, Salary = {Salary}, NumberOfSubordinates = {NumberOfSubordinates}, Department = {Department}";
        }
    }
}
