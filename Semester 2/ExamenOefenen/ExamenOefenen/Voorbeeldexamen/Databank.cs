using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExamenOefenen.Voorbeeldexamen
{
    public class Databank
    {
        public static Dictionary<string, string> DictVakken = new Dictionary<string, string>
        {
            {"PRO", "Programmeren" },
            {"SNE", "Systemen en netwerken" },
            {"DVG", "Digitale Vormgeving" },
            {"IOT", "Internet of things" }
        };
        public static List<Student> ListStudenten = new List<Student>();
        public static DataSet DsStudent = new DataSet("StudentenDB");

        public static string DataFolder = @"";
    }
}
