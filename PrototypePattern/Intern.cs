using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Intern : Employee
    {
        public string University { get; set; }
        public int InternshipDuration { get; set; } // in months

        public Intern(string name, string position, decimal salary, string university, int internshipDuration)
            : base(name, position, salary)
        {
            University = university;
            InternshipDuration = internshipDuration;
        }

        public override Employee MyClone()
        {
            return new Intern(this.Name, this.Position, this.Salary, this.University, this.InternshipDuration);
        }

        public override string ToString()
        {
            return $"Intern: Name = {Name}, Position = {Position}, Salary = {Salary}, University = {University}, InternshipDuration = {InternshipDuration} months";
        }
    }
}
