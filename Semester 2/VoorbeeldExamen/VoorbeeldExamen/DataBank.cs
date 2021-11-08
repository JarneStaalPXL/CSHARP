using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldExamen
{
    public static class DataBank
    {
        public static string DataFolder = "";
        public static List<Student> listStudenten = new List<Student>();
        public static DataSet dsStudent = new DataSet("Studenten");
        public static Dictionary<string, string> dictVakken = new Dictionary<string, string>()
        {
            {"PRO","Programmeren"},
            {"SNE","Systemen en netwerken"},
            {"DVG","Digitale vormgeving"},
            {"IOT","Internet Of Things"},
        };
    }
}
