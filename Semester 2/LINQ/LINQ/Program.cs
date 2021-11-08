using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        //OEFENING 1
        private static readonly List<int> driehoek = new List<int>()
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
        private static readonly string[] tekst = new string[]
        {
        "langspeelfilm", "vluchtmisdrijf", "dovemansgesprek", "containerpark",
        "confituur", "inox", "valavond", "enerverend", "lopen", "bank", "vieruurtje",
        "waterzooi", "maaltijdcheque", "arrondissement", "eindtermen", "nieuwjaarsbrief"
        };

        //OEFENING 2

        #region WareHouses
        public static List<Warehouse> warehouses = new List<Warehouse>
        {
        new Warehouse("Brug4", 0, "Arendonk", 2370, "Holstraat", 14, 3000, new List<int>{ 4, 3, 1, 5 }),
        new Warehouse("Brug1", 1, "Arendonk", 2370, "Holstraat", 3, 8000, new List<int>{ 1, 4, 3, 5, 2,
        3, 3, 4, 4}),
        new Warehouse("Poort1", 2, "Gent", 9000, "Stropkaai", 12, 7000, new List<int>{ 5, 4, 3, 4 , 4}),
        new Warehouse("Rijsteller", 3, "Hasselt", 3500, "Industrielaan", 1, 2500, new List<int>{ 5, 4,
        3, 5, 2, 3, 4, 4}),
        new Warehouse("Automa klein", 4, "Berchem", 2600, "Nieuwevaart", 77, 10000, new List<int>{ 4 }),
        new Warehouse("Schuifla", 5, "Hasselt", 3500, "Industrielaan", 15, 1500, new List<int>{ 3, 5, 2
        }),
        new Warehouse("Automa groot", 6, "Berchem", 2600, "Nieuwevaart", 76, 30000, new List<int>{ 5 }),
        new Warehouse("Brug2", 7, "Arendonk", 2370, "Molenweg", 7, 3000, new List<int>{ 4, 3, 5, 2 }),
        new Warehouse("Veerhal", 8, "Melle", 9090, "Merelstraat", 48, 500, new List<int>{ 5, 5 }),
        new Warehouse("Poort2", 9, "Gent", 9000, "Burgstraat", 113, 6600, new List<int>{ 1, 2, 1, 1, 2,3}),
        new Warehouse("D1", 10, "Knokke", 8300, "Vaart", 2, 2200, new List<int>{ 5, 4, 1 }),
        new Warehouse("Brug3", 11, "Arendonk", 2370, "Molenweg", 8, 8000, new List<int>{ 5, 2, 3, 5, 5
        }),
        new Warehouse("D2", 12, "Knokke", 8300, "Vaart", 4, 2200, new List<int>{ 2, 3, 4 }),
        new Warehouse("D3", 13, "Knokke", 8300, "Vaart", 6, 2200, new List<int>{ 3, 4, 3 })
        };
        #endregion

        #region Employees
        public static List<Employee> employees = new List<Employee>
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
        #endregion

        static void Main(string[] args)
        {
            Oefening();
        }


        public static void Oefening()
        {
            Console.Clear();

            Console.Write("Please choose ex1 or ex2: ");
            if (Console.ReadLine().ToLower().Contains("ex1"))
            {
                Console.Write("Show exercise output: ");
                string answer = Console.ReadLine().ToLower();

                Console.Clear();
                Console.WriteLine("The output of exercise " + answer.ToUpper() + "\n");
                RunExerciseOefening1(answer);
            }
            else
            {
                Console.Write("Show exercise output: ");
                string answer = Console.ReadLine().ToLower();

                Console.Clear();
                Console.WriteLine("The output of exercise " + answer.ToUpper() + "\n");
                RunExerciseOefening2(answer);
            }
            

            Console.WriteLine("\n\nPress ENTER for different answer");
            Console.ReadLine();
            Oefening();
        }

        public static void RunExerciseOefening1(string subEx)
        {
            switch (subEx)
            {
                case "a":
                    A();
                    break;
                case "b":
                    B();
                    break;
                case "c":
                    C();
                    break;
                case "d":
                    D();
                    break;
                case "e":
                    E();
                    break;
                case "f":
                    F();
                    break;
                default:
                    Oefening();
                    break;
            }

            void A()
            {
                var query = from text in tekst
                            where text.Length > 10
                            select text;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            void B()
            {
                var query2 = from dh in driehoek
                             where dh > 100
                             select dh;

                Console.WriteLine("The average of the numbers that are above 100 is " + query2.Average());
            }
            
            void C()
            {
                var query = from number in driehoek.Distinct()
                            orderby number ascending
                            select number;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            void D()
            {
                var query = from number in driehoek.Distinct()
                            where number % 3 == 0 && number % 5 == 0
                            orderby number ascending
                            select number;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            void E()
            {
                var query = from word in tekst
                            orderby word.Length ascending
                            select word;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            void F()
            {
                var query = from word in tekst
                            orderby word.Substring(0,1) ascending
                            select word;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void RunExerciseOefening2(string subEx)
        {
            switch (subEx)
            {
                case "a":
                    A();
                    break;
                case "b":
                    B();
                    break;
                case "c":
                    C();
                    break;
                case "d":
                    D();
                    break;
                case "e":
                    E();
                    break;
                case "f":
                    F();
                    break;
                default:
                    Oefening();
                    break;
            }

            void A()
            {
                var query = from Warehouse in warehouses
                            where Warehouse.City.Equals("Berchem")
                            select Warehouse.BuildingName;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            void B()
            {
                var query = from Warehouse in warehouses
                            orderby Warehouse.EmployeeSatisfactionRating.Count descending
                            select (Warehouse.BuildingName, Warehouse.City);


                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BuildingName} {item.City}");
                }
            }

            void C()
            {
                var query = from employee in employees
                            orderby employee.LastName ascending
                            select (employee.FirstName, employee.LastName, employee.ID);


                string firstn = "Firstname";
                string lastnm = "Lastname";
                string ID = "ID";

                Console.WriteLine($"{firstn,-20} {lastnm,-20}   {ID}");
                Console.WriteLine($"------------------------------------------------");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.FirstName,-20} {item.LastName,-20}   {item.ID}");
                }
            }

            void D()
            {
                var query = from warehouse in warehouses
                            orderby warehouse.EmployeeSatisfactionRating.Average() descending
                            select warehouse;

                foreach (var item in query)
                {
                    Console.WriteLine(item.BuildingName);
                }
            }

            void E()
            {
                var query = from warehouse in warehouses
                            orderby warehouse.City ascending
                            where warehouse.PostCode < 4000
                            select warehouse;


                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BuildingName,-20} --- {item.City,20}");
                }
            }

            void F()
            {
                var query = from warehouse in warehouses
                            orderby warehouse.StorageCapacity > 2000
                            join employee in employees
                            on warehouse.WarehouseID equals employee.WarehouseID
                            select (employee.FirstName, employee.LastName, warehouse.BuildingName, warehouse.StorageCapacity);



                string firstn = "Firstname";
                string lastnm = "Lastname";
                string bd = "BuildingName";
                string sc = "StorageCapacity";


                Console.WriteLine($"{firstn,-20} {lastnm,-20} {bd,-20} {sc,-20}");
                for (int i = 0; i < 80; i++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();

                foreach (var tuple in query)
                {
                    Console.WriteLine($"{tuple.FirstName,-20} {tuple.LastName,-20} {tuple.BuildingName,-14} {tuple.StorageCapacity,10}m²");
                }
            }

        }

    }
}
