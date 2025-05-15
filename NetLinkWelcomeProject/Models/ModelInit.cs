using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject.Models
{
    static class ModelInit
    {
        public static List<City> Cities = new List<City>();
        public static List<Country> Countries = new List<Country>();
        public static List<Position> Positions = new List<Position>();
        public static List<Company> Companies = new List<Company>();
        public static List<Employee> Employees = new List<Employee>();

        static ModelInit()
        {
            Countries.Add(new("Russia"));
            Countries.Add(new("Usa"));
            Countries.Add(new("China"));
            Countries.Add(new("South Korea"));

            Cities.Add(new("Moscow", Countries[0]));
            Cities.Add(new("St Peterburg", Countries[0]));
            Cities.Add(new("Tula", Countries[0]));
            Cities.Add(new("Ekaterinburg", Countries[0]));
            Countries[0].Capital = Cities[0];

            Cities.Add(new("Washington", Countries[1]));
            Cities.Add(new("New York", Countries[1]));
            Cities.Add(new("Los Angeles", Countries[1]));
            Cities.Add(new("Boston", Countries[1]));
            Countries[1].Capital = Cities[4];

            Cities.Add(new("Beijing", Countries[2]));
            Cities.Add(new("Shenzhen", Countries[2]));
            Countries[2].Capital = Cities[8];

            Cities.Add(new("Seoul", Countries[3]));
            Countries[3].Capital = Cities[10];

            Companies.Add(new("Yandex", Countries[0], Cities[0]));
            Companies.Add(new("Mail Group", Countries[0], Cities[0]));
            Companies.Add(new("Piter Soft", Countries[0], Cities[1]));
            Companies.Add(new("Techart", Countries[0], Cities[2]));

            Companies.Add(new("Google", Countries[1], Cities[6]));
            Companies.Add(new("Amazon", Countries[1], Cities[5]));
            Companies.Add(new("Microsoft", Countries[1], Cities[6]));

            Companies.Add(new("Xiaomi", Countries[2], Cities[8]));
            Companies.Add(new("ZTE", Countries[2], Cities[9]));

            Companies.Add(new("Sumsung", Countries[3], Cities[10]));

            Positions.Add(new("Manager", 100000));
            Positions.Add(new("Developer", 160000));
            Positions.Add(new("Tester", 130000));
            Positions.Add(new("Saler", 110000));

            Employees.Add(new("Jimmy", new(1990, 10, 21), Companies[0], Positions[0], 1.1));
            Employees.Add(new("Tommy", new(2001, 1, 11), Companies[1], Positions[0], 1.2));
            Employees.Add(new("Sammy", new(1998, 12, 15), Companies[2], Positions[0], 1.15));
            Employees.Add(new("Bobby", new(2001, 6, 29), Companies[1], Positions[1], 1.18));
            Employees.Add(new("Jimmy", new(1987, 8, 16), Companies[0], Positions[1], 1.22));
            Employees.Add(new("Lenny", new(1993, 10, 8), Companies[3], Positions[0], 1.3));
            Employees.Add(new("Tommy", new(1990, 9, 18), Companies[2], Positions[1], 1.5));
            Employees.Add(new("Jenny", new(2000, 1, 11), Companies[0], Positions[2], 1.1));
            Employees.Add(new("Kenny", new(2001, 5, 28), Companies[4], Positions[0], 1.05));
            Employees.Add(new("Sammy", new(1995, 12, 16), Companies[5], Positions[0], 1.10));
            Employees.Add(new("Jimmy", new(1989, 3, 10), Companies[4], Positions[0], 1.12));
            Employees.Add(new("Bobby", new(1990, 8, 23), Companies[7], Positions[0], 1.1));
            Employees.Add(new("Mikky", new(2001, 1, 7), Companies[3], Positions[1], 1.4));
            Employees.Add(new("Sandy", new(1997, 11, 18), Companies[1], Positions[2], 1.1));
            Employees.Add(new("Tonny", new(1998, 7, 21), Companies[0], Positions[3], 1.7));

        }
    }
}
