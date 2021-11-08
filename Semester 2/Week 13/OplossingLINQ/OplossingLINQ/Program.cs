using System;
using System.Collections.Generic;
using System.Linq;

namespace OplossingLINQ
{
    class Program
    {


        static void Main(string[] args)
        {
            Oefening1();
            //Oefening2();
            Console.ReadLine();
        }

        private static void Oefening1()
        {
            List<int> driehoek = new List<int>()
            {
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            1, 3, 6, 10, 15, 21, 28, 36, 45,
            1, 4, 10, 20, 35, 56, 84, 120,
            1, 5, 15, 35, 70, 126, 210,
            1, 6, 21, 56, 126, 252,
            1, 7, 28, 84, 210,
            1, 8, 36, 120,
            1, 9, 45,
            1, 10,
            1
            };

            string[] tekst = new string[]
            {
            "langspeelfilm", "vluchtmisdrijf", "dovemansgesprek", "containerpark",
            "confituur", "inox", "valavond", "enerverend", "lopen", "bank", "vieruurtje",
            "waterzooi", "maaltijdcheque", "arrondissement", "eindtermen", "nieuwjaarsbrief"
            };

            Console.WriteLine("OPLOSSING 1A");
            Console.WriteLine();
            var oplossing_1a = from t in tekst
                               where t.Length > 10
                               select t;
            foreach (string item in oplossing_1a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1B");
            Console.WriteLine();
            var oplossing_1b = (from d in driehoek
                                where d > 100
                                select d).Average();
            Console.WriteLine(oplossing_1b);

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1C");
            Console.WriteLine();
            foreach (int item in driehoek.Distinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1D");
            Console.WriteLine();
            var oplossing_1d = from d in driehoek
                               where d % 3 == 0 || d % 5 == 0
                               orderby d
                               select d;
            foreach (int item in oplossing_1d.Distinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1E");
            Console.WriteLine();
            var oplossing_1e = from t in tekst
                               orderby t.Length descending,
                               t ascending
                               select t;
            foreach (string item in oplossing_1e)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1F");
            Console.WriteLine();
            var oplossing_1f = from t in tekst
                               group t by t.Substring(0, 1) into t_grp
                               select t_grp;
            foreach (var grp in oplossing_1f)
            {
                Console.WriteLine($"Groep {grp.Key}:");
                foreach (string item in grp)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1G");
            Console.WriteLine();
            var oplossing_1g = tekst.Join(driehoek, t => t.Length, d => d, (t, d) => (t, d));
            var oplossing_1g2 = from t in tekst
                                join d in driehoek on t.Length equals d
                                orderby d
                                select new { d, t };

            foreach (var item in oplossing_1g)
            {
                Console.WriteLine(item);
            }
            foreach (var item in oplossing_1g2)
            {
                Console.WriteLine($"Lengte: {item.d} - {item.t}");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1H");
            Console.WriteLine();
            foreach (var item in oplossing_1g2.Distinct())
            {
                Console.WriteLine($"Lengte: {item.d} - {item.t}");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 1I");
            Console.WriteLine();
            //char[] klinkers = { 'a', 'e', 'i', 'o', 'u' };
            string strklinkers = "aeiou";
            //string test = "vieruurtje";
            //Console.WriteLine(test.Count(strklinkers.Contains));

            var oplossing_1i = from t in tekst
                               where t.Count(strklinkers.Contains) >= 3
                               select t;

            foreach (string item in oplossing_1i)
            {
                Console.WriteLine(item);
            }
        }
        private static void Oefening2()
        {
            List<Warehouse> warehouses = new List<Warehouse>
                {
                new Warehouse("Brug4", 0, "Arendonk", 2370, "Holstraat", 14, 3000, new List<int>{ 4, 3, 1, 5 }),
                new Warehouse("Brug1", 1, "Arendonk", 2370, "Holstraat", 3, 8000, new List<int>{ 1, 4, 3, 5, 2, 3, 3, 4, 4}),
                new Warehouse("Poort1", 2, "Gent", 9000, "Stropkaai", 12, 7000, new List<int> { 5, 4, 3, 4, 4 }),
                new Warehouse("Rijsteller", 3, "Hasselt", 3500, "Industrielaan", 1, 2500, new List<int>{ 5, 4, 3, 5, 2, 3, 4, 4}),
                new Warehouse("Automa klein", 4, "Berchem", 2600, "Nieuwevaart", 77, 10000, new List<int> { 4 }),
                new Warehouse("Schuifla", 5, "Hasselt", 3500, "Industrielaan", 15, 1500, new List<int>{ 3, 5, 2 }),
                new Warehouse("Automa groot", 6, "Berchem", 2600, "Nieuwevaart", 76, 30000, new List<int> { 5 }),
                new Warehouse("Brug2", 7, "Arendonk", 2370, "Molenweg", 7, 3000, new List<int> { 4, 3, 5, 2 }),
                new Warehouse("Veerhal", 8, "Melle", 9090, "Merelstraat", 48, 500, new List<int> { 5, 5 }),
                new Warehouse("Poort2", 9, "Gent", 9000, "Burgstraat", 113, 6600, new List<int>{ 1, 2, 1, 1, 2, 3}),
                new Warehouse("D1", 10, "Knokke", 8300, "Vaart", 2, 2200, new List<int> { 5, 4, 1 }),
                new Warehouse("Brug3", 11, "Arendonk", 2370, "Molenweg", 8, 8000, new List<int>{ 5, 2, 3, 5, 5 }),
                new Warehouse("D2", 12, "Knokke", 8300, "Vaart", 4, 2200, new List<int> { 2, 3, 4 }),
                new Warehouse("D3", 13, "Knokke", 8300, "Vaart", 6, 2200, new List<int> { 3, 4, 3 })
                };
            List<Employee> employees = new List<Employee>
                {
                new Employee("Jos", "Jansen", 0, 1),
                new Employee("Ted", "Bériault", 1, 0),
                new Employee("Tony", "Hawk", 2, 3),
                new Employee("Peggy", "Corona", 3, 12),
                new Employee("Edna", "Goosen", 4, 0),
                new Employee("Mac", "Kowalski", 5, 11),
                new Employee("Alejandro", "Mendoza", 6, 8),
                new Employee("Aysha", "Lyon", 7, 7),
                new Employee("Tyson", "Dyer", 8, 4),
                new Employee("Nanou", "Hahn", 9, 6),
                new Employee("Kevin", "Hahn", 10, 5),
                new Employee("Kris", "Jacobsen", 11, 1),
                new Employee("Boros", "Orzsebet", 12, 2),
                new Employee("Buday", "Gedeon", 13, 2),
                new Employee("Szölôsi", "Taksony", 14, 1),
                new Employee("Kocsis", "Gyula", 15, 8),
                new Employee("Asif", "Atiyeh", 16, 7),
                new Employee("Ruwayd", "Akram", 17, 13),
                new Employee("Makary", "Sobczak", 18, 12),
                new Employee("Pawel", "Symanski", 19, 1),
                new Employee("Settimio", "Calabresi", 20, 10),
                new Employee("Ivo", "Bellucci", 21, 7),
                new Employee("Matthieu", "Camus", 22, 9),
                new Employee("Jacques", "Huard", 23, 8),
                new Employee("Melville", "Bériault", 24, 4),
                new Employee("René", "Michaud", 25, 9)
                };

            Console.WriteLine("OPLOSSING 2A");
            Console.WriteLine();
            var oplossing_2a = from w in warehouses
                               where w.City == "Berchem"
                               select w.BuildingName;
            foreach (string item in oplossing_2a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2B");
            Console.WriteLine();
            var oplossing_2b = from w in warehouses
                               orderby w.EmployeeSatisfactionRating.Sum() descending
                               select w;
            foreach (Warehouse item in oplossing_2b)
            {
                Console.WriteLine($"{item.BuildingName} - {item.City} ({item.EmployeeSatisfactionRating.Sum()})");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2C");
            Console.WriteLine();
            var oplossing_2c = from e in employees
                               orderby e.LastName
                               select e;
            foreach (Employee item in oplossing_2c)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} - {item.ID}");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2D");
            Console.WriteLine();
            var oplossing_2d = from w in warehouses
                               orderby w.EmployeeSatisfactionRating.Average() descending
                               select w;
            foreach (Warehouse item in oplossing_2d)
            {
                Console.WriteLine($"{item.BuildingName} - {item.City} ({item.EmployeeSatisfactionRating.Average()})");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2E");
            Console.WriteLine();
            var oplossing_2e = from w in warehouses
                               where w.PostCode < 4000
                               group w by w.City into wgrp
                               select wgrp;
            foreach (var grp in oplossing_2e)
            {
                Console.WriteLine($"City: {grp.Key}");

                foreach (Warehouse item in grp)
                {
                    Console.WriteLine($"{item.BuildingName} ({item.PostCode})");
                }
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2F");
            Console.WriteLine();
            var oplossing_2f = from w in warehouses
                               join e in employees on w.WarehouseID equals e.WarehouseID
                               where w.StorageCapacity > 2000
                               select new { w.BuildingName, w.StorageCapacity, e.LastName, e.FirstName };
            foreach (var item in oplossing_2f)
            {
                Console.WriteLine($"{item.BuildingName} ({item.StorageCapacity}) - {item.LastName} {item.FirstName}");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2G");
            Console.WriteLine();
            var oplossing_2g = from e in employees
                               join e_match in employees on e.LastName equals e_match.LastName
                               where e_match.ID != e.ID
                               orderby e_match.LastName
                               select e_match;
            foreach (var item in oplossing_2g)
            {
                Console.WriteLine($"{item.ID} {item.FirstName}");
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2H");
            Console.WriteLine();
            var oplossing_2h = from w in warehouses
                               join e in employees on w.WarehouseID equals e.WarehouseID
                               where w.StorageCapacity > 5000
                               orderby w.WarehouseID
                               select new { w, e };
            foreach (var item in oplossing_2h)
            {
                Console.WriteLine($"{item.e.FirstName} - {item.w.City} {item.w.PostCode} {item.w.Street} {item.w.HouseNumber}");
            }

            var oplossing_2h_met_grouping = from w in warehouses
                                            where w.StorageCapacity > 5000
                                            join e in employees on w.WarehouseID equals e.WarehouseID into we
                                            group we by w into grp
                                            select grp;
            //select new { w.City, emps = we };

            // Create a list where each element is an anonymous type
            // that contains the person's first name and a collection of
            // pets that are owned by them.
            //var query = from person in people
            //            join pet in pets on person equals pet.Owner into gj
            //            select new { OwnerName = person.FirstName, Pets = gj };

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2H MET GROUPING");
            Console.WriteLine();
            foreach (var grp in oplossing_2h_met_grouping)
            {
                Console.WriteLine($"Warehouse {grp.Key.City} {grp.Key.PostCode} {grp.Key.Street} {grp.Key.HouseNumber}");
                foreach (var itm in grp)
                {
                    Console.WriteLine($"\t{itm.Count()} werknemers");
                    foreach (var emp in itm)
                    {
                        Console.WriteLine($"\t\t{emp.FirstName}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("OPLOSSING 2I");
            Console.WriteLine();
            var oplossing_2i = from w in warehouses
                               join e in employees on w.WarehouseID equals e.WarehouseID
                               group e by w.Street into grp
                               select grp;
            foreach (var grp in oplossing_2i)
            {
                Console.WriteLine($"Magazijn in {grp.Key}");
                foreach (var item in grp)
                {
                    Console.WriteLine($"\t{item.FirstName} {item.LastName}");
                }
            }
        }
    }
}
