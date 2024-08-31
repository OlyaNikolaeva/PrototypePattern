using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Engineer : Employee
    {
        public string Specialization { get; set; }
        public string QualificationLevel { get; set; }

        public Engineer(string name, string position, decimal salary, string specialization, string qualificationLevel)
            : base(name, position, salary)
        {
            Specialization = specialization;
            QualificationLevel = qualificationLevel;
        }

        public override Employee MyClone()
        {
            return new Engineer(this.Name, this.Position, this.Salary, this.Specialization, this.QualificationLevel);
        }

        public override string ToString()
        {
            return $"Engineer: Name = {Name}, Position = {Position}, Salary = {Salary}, Specialization = {Specialization}, QualificationLevel = {QualificationLevel}";
        }
    }
}
