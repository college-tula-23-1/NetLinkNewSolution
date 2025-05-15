using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    internal class Employee
    {
        public string Name { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int Age => DateTime.Now.Year - BirthDate.Year;

        public Company? Company { get; set; }
        public Position? Position { get; set; }
        public double Rate { get; set; }
        public decimal Salary => Position!.Salary * (decimal)Rate;

        public Employee() { }
        public Employee(string name)
            : this(name, DateTime.Now, null, null, 1.0) { }
        public Employee(string name, 
                        DateTime birthDate, 
                        Company? company, 
                        Position? position, 
                        double rate)
        {
            Name = name;
            BirthDate = birthDate;
            Company = company;
            Position = position;
            Rate = rate;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToShortDateString()}) " +
                $"In {Company?.Title} [{Position?.Title} ({Salary})]";
        }
    }
}
