using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Warehouse
    {
        public string BuildingName { get; set; }
        public int WarehouseID { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int StorageCapacity { get; set; }
        public List<int> EmployeeSatisfactionRating {get;set;}

        public Warehouse(string buildingname, int warehouseid, string city, int postcode, string street
            , int housenr, int storageCapacity, List<int> employeestatisfactrating)
        {
            BuildingName = buildingname;
            WarehouseID = warehouseid;
            City = city;
            PostCode = postcode;
            Street = street;
            HouseNumber = housenr;
            StorageCapacity = storageCapacity;
            EmployeeSatisfactionRating = employeestatisfactrating;
        }
    }
}
