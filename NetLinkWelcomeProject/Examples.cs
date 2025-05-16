using NetLinkWelcomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinkWelcomeProject
{
    static class Examples
    {
        static List<Airflight> airflights = new List<Airflight>()
        {
            new(){ Name = "ASD-123", Departure = "Moscow", Arrival = "St Peterburg", Price = 7500 },
            new(){ Name = "HJK-893", Departure = "St Peterburg", Arrival = "Ekaterinburg", Price = 12000 },
            new(){ Name = "SD-101", Departure = "Moscow", Arrival = "Kazan", Price = 10000 },
            new(){ Name = "ERT-246", Departure = "St Peterburg", Arrival = "Moscow", Price = 8000 },
            new(){ Name = "POY-987", Departure = "Kazan", Arrival = "Irkutsk", Price = 20000 },
            new(){ Name = "NM-550", Departure = "St Peterburg", Arrival = "Vladivostok", Price = 30000 },
            new(){ Name = "LKE-231", Departure = "Moscow", Arrival = "Vladivostok", Price = 32000 },
            new(){ Name = "AXC-775", Departure = "Irkutsk", Arrival = "Moscow", Price = 23000 },
            new(){ Name = "LKL-56", Departure = "Kazan", Arrival = "Moscow", Price = 11000 },
            new(){ Name = "WQ-200", Departure = "Moscow", Arrival = "Kaliningrad", Price = 9000 },
        };
        public static void LinqWelcomeExample()
        {
            List<Airflight> airflightsFromMoscow = new List<Airflight>();

            foreach (var flight in airflights)
                if (flight.Departure?.ToLower() == "moscow")
                    airflightsFromMoscow.Add(flight);


            foreach (var flight in airflightsFromMoscow)
                Console.WriteLine(flight);
            Console.WriteLine();


            var airflightsLinqOperations = from flight in airflights
                                           where flight.Departure?.ToLower() == "moscow"
                                           select flight;

            foreach (var flight in airflightsLinqOperations)
                Console.WriteLine(flight);
            Console.WriteLine();


            var airflightsLinqMethods = airflights
                                        .Where(f => f.Departure?.ToLower() == "moscow");

            foreach (var flight in airflightsLinqMethods)
                Console.WriteLine(flight);
            Console.WriteLine();
        }

        public static void LinqSelectExample()
        {
            //var departuresMethods = airflights.Select(f => f.Departure);

            //foreach (var item in departuresMethods)
            //    Console.WriteLine(item);
            //Console.WriteLine();


            var pairsCitiesOperations = from flight in airflights
                                        select new
                                        {
                                            flight.Departure,
                                            flight.Arrival,
                                        };

            foreach (var item in pairsCitiesOperations)
                Console.WriteLine(item);
            Console.WriteLine();

            var pairsCitiesMethods = airflights.Select(flight => new
            {
                flight.Departure,
                flight.Arrival,
            });

            foreach (var item in pairsCitiesMethods)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        public static void LinqSelectTwoExample()
        {
            var employees = ModelInit.Employees;

            var selectOperations = from employee in employees
                                   select new
                                   {
                                       employee.Name,
                                       Position = employee.Position?.Title,
                                       employee.Salary,
                                   };
            //Console.WriteLine(selectOperations.First().GetType());
            foreach (var e in selectOperations)
                Console.WriteLine(e);
            Console.WriteLine();

            var selectMethods = employees.Select(employee => new
            {
                employee.Name,
                Position = employee.Position?.Title,
                employee.Salary,
            });

            foreach (var e in selectMethods)
                Console.WriteLine(e);
            Console.WriteLine();
            Console.WriteLine();

            var countries = ModelInit.Countries;
            var cities = ModelInit.Cities;

            var countriesCitiesOpers = from country in countries
                                       from city in cities
                                       where (city.Country == country)
                                       select new
                                       {
                                           Country = country.Title,
                                           City = city.Title,
                                       };

            foreach (var item in countriesCitiesOpers)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        public static void LinqWhereExample()
        {
            var employees = ModelInit.Employees;

            var emplyeesRussianOperators = from e in employees
                                           where e?.Company?.Country?.Title == "Russia"
                                                 && e.Age >= 25
                                           select e;

            foreach (var e in emplyeesRussianOperators)
                Console.WriteLine(e);
            Console.WriteLine();

            var employeeRussianMethods = employees.Where(e =>
                e?.Company?.Country?.Title == "Russia" && e.Age >= 25);

            foreach (var e in employeeRussianMethods)
                Console.WriteLine(e);
            Console.WriteLine();

            //var companies = ModelInit.Companies;
            //foreach(var c in companies)
            //{
            //    Console.WriteLine(c.Title);
            //    foreach(var e in c.Employees)
            //        Console.WriteLine($"\t{e.Name}");
            //}
        }

        public static void LinqOrderByExample()
        {
            var employees = ModelInit.Employees;

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine();

            //var employeesSortNameOperators = from e in employees
            //                                 orderby e.Name descending
            //                                 select e;

            //foreach (var e in employeesSortNameOperators)
            //    Console.WriteLine(e);
            //Console.WriteLine();

            //var employeesSortAgeOperators = from e in employees
            //                                 orderby e.Age
            //                                 select e;

            //foreach (var e in employeesSortAgeOperators)
            //    Console.WriteLine(e);
            //Console.WriteLine();

            //var employeesSortNameAgeOperators = from e in employees
            //                                    orderby e.Name, e.Age descending
            //                                    select e;

            //foreach (var e in employeesSortNameAgeOperators)
            //    Console.WriteLine(e);
            //Console.WriteLine();


            // Methods
            //var employeesSortNameMethods = employees.OrderBy(e => e.Name);
            //var employeesSortNameMethods = employees.OrderByDescending(e => e.Name);

            //foreach (var e in employeesSortNameMethods)
            //    Console.WriteLine(e);
            //Console.WriteLine();

            //var employeesSortAgeMethods = employees.OrderBy(e => e.Age);

            //foreach (var e in employeesSortAgeMethods)
            //    Console.WriteLine(e);
            //Console.WriteLine();

            //var employeesSortNameAgeMethods = employees.OrderBy(e => e.Name)
            //                                           .ThenByDescending(e => e.Age);

            //foreach (var e in employeesSortNameAgeMethods)
            //    Console.WriteLine(e);
            //Console.WriteLine();


            var employeesSortCompanyMethods = employees
                .OrderBy(e => e.Company?.Title, new LengthStringComparer()!);

            foreach (var e in employeesSortCompanyMethods)
                Console.WriteLine(e);
            Console.WriteLine();
        }
    }

    class LengthStringComparer : IComparer<String>
    {
        public int Compare(string? x, string? y)
        {
            return (x?.Length ?? 0) - (y?.Length ?? 0);
        }
    }
}
