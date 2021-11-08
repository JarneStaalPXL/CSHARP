using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OplossingLINQ
{
    class Warehouse
    {
        public string BuildingName { get; set; }
        public int WarehouseID { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int StorageCapacity { get; set; }
        public List<int> EmployeeSatisfactionRating { get; set; }

        public Warehouse(string buildingname, int warehouseid, string city, int postcode, string street, int housenumber, int capacity, List<int> rating)
        {
            BuildingName = buildingname;
            WarehouseID = warehouseid;
            City = city;
            PostCode = postcode;
            Street = street;
            HouseNumber = housenumber;
            StorageCapacity = capacity;
            EmployeeSatisfactionRating = rating;
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int WarehouseID { get; set; }

        public Employee(string firstname, string lastname, int id, int warehouseid)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            WarehouseID = warehouseid;
        }
    }
}
