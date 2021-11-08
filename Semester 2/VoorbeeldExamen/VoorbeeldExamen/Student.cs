using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldExamen
{
    public class Student : Initialiseren, IStudentVak
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string VakCode { get; set; }
        public DataTable dtStudent { get; set; }
        public string VakVolledig => DataBank.dictVakken[VakCode];

        public Student(){}

        public Student(string[] geg)
        {
            Initaliseer();
            Naam = geg[0];
            Voornaam = geg[1];
            VakCode = geg[2];

            VoegRijToe();
        }

        public override void Initaliseer()
        {
            string tbname = "student";
            if (DataBank.dsStudent.Tables.Contains(tbname))
            {
                dtStudent = DataBank.dsStudent.Tables[tbname];
            }
            else
            {
                dtStudent = new DataTable(tbname);
                dtStudent.Columns.Add("Naam", typeof(string));
                dtStudent.Columns.Add("Voornaam", typeof(string));
                dtStudent.Columns.Add("VakCode", typeof(string));
                DataBank.dsStudent.Tables.Add(dtStudent);
            }
        }

        public void VoegRijToe()
        {
            DataRow dr = dtStudent.NewRow();
            dr["Naam"] = Naam;
            dr["Voornaam"] = Voornaam;
            dr["VakCode"] = VakCode;
            dtStudent.Rows.Add(dr);
        }

        public override string ToString()
        {
            return $"{Voornaam} {Naam.ToUpper()} {VakCode.ToUpper()} ({VakVolledig.ToLower()})";
        }
    }
}
