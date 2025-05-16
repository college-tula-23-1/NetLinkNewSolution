using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    internal class Country
    {
        public string Title { get; set; } = "";
        public City? Capital { get; set; }
        public List<City> Cities { get; set; } = new();

        public Country() { }
        public Country(string title) : this(title, null) { }
        public Country(string title, City? capital)
        {
            Title = title;
            Capital = capital;
        }

        public override string ToString()
        {
            return $"capital: {Title} [{Capital?.Title}]";
        }
    }
}
