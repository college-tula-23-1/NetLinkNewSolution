using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    internal class City
    {
        public string Title { get; set; } = "";
        public Country? Country { get; set; }
        
        public City() { }
        public City (string title, Country country)
        {
            Title = title;
            Country = country;
        }

        public override string ToString()
        {
            return $"City: {Title} [{Country?.Title}]";
        }
    }
}
