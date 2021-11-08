using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExamenOefenen.Voorbeeldexamen
{
    public class Student : Initaliseren
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string VakCode { get; set; }

        public string VakVolledig => Databank.DictVakken[VakCode];


        public DataTable DtStudent
        {
            get; set;
        }
        public Student()
        {
                
        }

        public Student(string[] studgeg)
        {
            MaakKolommen();
            if (studgeg.Length > 2)
            {
                Naam = studgeg[0];
                Voornaam = studgeg[1];
                VakCode = studgeg[2];
                VoegRijToe();
            }
        }

        public override void MaakKolommen()
        {
            string tableName = "student";
            if (Databank.DsStudent.Tables.Contains(tableName))
            {
                DtStudent = Databank.DsStudent.Tables[tableName];
            }
            else
            {
                //Create Tabel
                DtStudent = new DataTable(tableName);
                DtStudent.Columns.Add("Voornaam", typeof(string));
                DtStudent.Columns.Add("Naam", typeof(string));
                DtStudent.Columns.Add("VakCode", typeof(string));
                // Tabel toevoegen aan dataset
                Databank.DsStudent.Tables.Add(DtStudent);
            }
        }

        public void VoegRijToe()
        {
            DataRow dr = DtStudent.NewRow();
            dr["Voornaam"] = Voornaam;
            dr["Naam"] = Naam;
            dr["VakCode"] = VakCode;
            DtStudent.Rows.Add(dr);
            //DtStudent.Rows.Add(Voornaam, Naam, VakCode);
        }

        public override string ToString()
        {
            return $"{Voornaam} {Naam.ToUpper()} - {VakCode.ToUpper()} ({VakVolledig.ToLower()})";
        }
    }
}
