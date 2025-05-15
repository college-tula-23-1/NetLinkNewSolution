using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    internal class Position
    {
        public string Title { get; set; } = null!;
        public decimal Salary { get; set; }

        public Position() { }
        public Position(string title) : this(title, 0M) { }
        public Position(string title, decimal salary)
        {
            Title = title;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Position: {Title} [{Salary}]";
        }
    }
}
