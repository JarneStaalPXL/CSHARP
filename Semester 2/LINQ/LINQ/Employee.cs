using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int WarehouseID { get; set; }

        public Employee(string fname, string lname, int id, int warehouseId)
        {
            FirstName = fname;
            LastName = lname;
            ID = id;
            WarehouseID = warehouseId;
        }
    }
}
