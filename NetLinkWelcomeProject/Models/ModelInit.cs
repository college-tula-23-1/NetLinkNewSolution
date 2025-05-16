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
            Country russia = new("Russia");
            Country usa = new("Usa");
            Country china = new("China");
            Country korea = new("South Korea");
            Countries.AddRange([russia, usa, china, korea]);

            City moscow = new("Moscow", russia);
            City piter = new("St Peterburg", russia);
            City tula = new("Tula", russia);
            City eburg = new("Ekaterinburg", russia);
            russia.Capital = moscow;
            Cities.AddRange([moscow, piter, tula, eburg]);
            russia.Cities.AddRange([moscow, piter, tula, eburg]);

            City washington = new("Washington", usa);
            City newyork = new("New York", usa);
            City losangeles = new("Los Angeles", usa);
            City boston = new("Boston", usa);
            usa.Capital = washington;
            Cities.AddRange([washington, newyork, losangeles, boston]);
            usa.Cities.AddRange([washington, newyork, losangeles, boston]);

            City beijing = new("Beijing", china);
            City shenzhen = new("Shenzhen", china);
            china.Capital = beijing;
            Cities.AddRange([beijing, shenzhen]);
            china.Cities.AddRange([beijing, shenzhen]);

            City seoul = new("Seoul", korea);
            korea.Capital = seoul;
            Cities.Add(seoul);
            korea.Cities.AddRange([seoul]);

            Company yandex = new("Yandex", russia, moscow);
            Company mail = new("Mail Group", russia, moscow);
            Company psoft = new("Piter Soft", russia, piter);
            Company techart = new("Techart", russia, tula);
            Companies.AddRange([yandex, mail, psoft, techart]);

            Company google = new("Google", usa, losangeles);
            Company amazon = new("Amazon", usa, newyork);
            Company microsoft = new("Microsoft", usa, losangeles);
            Companies.AddRange([google, amazon, microsoft]);

            Company xiaomi = new("Xiaomi", china, beijing);
            Company zte = new("ZTE", china, shenzhen);
            Companies.AddRange([xiaomi, zte]);

            Company samsung = new("Sumsung", korea, seoul);
            Companies.Add(samsung);

            Position manager = new("Manager", 100000);
            Position developer = new("Developer", 160000);
            Position tester = new("Tester", 130000);
            Position saler = new("Saler", 110000);
            Positions.AddRange([developer, manager, tester, saler]);

            Employees.Add(new("Jimmy", new(1990, 10, 21), yandex, manager, 1.1));
            Employees.Add(new("Tommy", new(2001, 1, 11), mail, manager, 1.2));
            Employees.Add(new("Sammy", new(1998, 12, 15), psoft, manager, 1.15));
            Employees.Add(new("Bobby", new(2001, 6, 29), mail, developer, 1.18));
            Employees.Add(new("Jimmy", new(1987, 8, 16), yandex, developer, 1.22));
            Employees.Add(new("Lenny", new(1993, 10, 8), techart, manager, 1.3));
            Employees.Add(new("Tommy", new(1990, 9, 18), psoft, developer, 1.5));
            Employees.Add(new("Jenny", new(2000, 1, 11), yandex, tester, 1.1));
            Employees.Add(new("Kenny", new(2001, 5, 28), google, manager, 1.05));
            Employees.Add(new("Sammy", new(1995, 12, 16), amazon, manager, 1.10));
            Employees.Add(new("Jimmy", new(1989, 3, 10), google, manager, 1.12));
            Employees.Add(new("Bobby", new(1990, 8, 23), xiaomi, manager, 1.1));
            Employees.Add(new("Mikky", new(2001, 1, 7), techart, developer, 1.4));
            Employees.Add(new("Sandy", new(1997, 11, 18), mail, tester, 1.1));

            //yandex.Employees = Employees.Where(e => e.Company == yandex).ToList();
            //mail.Employees = Employees.Where(e => e.Company == mail).ToList();
            //psoft.Employees = Employees.Where(e => e.Company == psoft).ToList();
            //techart.Employees = Employees.Where(e => e.Company == techart).ToList();
            foreach(Company company in Companies)
                company.Employees = Employees.Where(e => e.Company == company).ToList();

        }
    }
}

