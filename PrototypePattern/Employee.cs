using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Employee : IMyCloneable<Employee>, ICloneable
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public virtual Employee MyClone()
        {
            return new Employee(this.Name, this.Position, this.Salary);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"Employee: Name = {Name}, Position = {Position}, Salary = {Salary}";
        }
    }
}
