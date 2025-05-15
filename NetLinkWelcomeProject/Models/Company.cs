using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    internal class Company
    {
        public string Title { get; set; } = null!;
        public Country? Country { get; set; }
        public City? City { get; set; }

        public Company() { }
        public Company(string title) : this(title, null, null) { }
        public Company(string title, Country? country, City? city)
        {
            Title = title;
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Company: {Title} from {Country?.Title} City: {City?.Title}";
        }

    }
}
