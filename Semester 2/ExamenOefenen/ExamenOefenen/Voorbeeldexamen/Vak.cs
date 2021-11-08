using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExamenOefenen.Voorbeeldexamen
{
    public class Vak : Initaliseren
    {
        private string omschrijving;
        public string VakCode { get; set; }
        public string Omschrijving 
        {
            get
            {
                switch (VakCode)
                {
                    case "PRO":
                        return "Programmeren";
                    case "SNE":
                        return "Systemen en netwerken";
                    case "DVG":
                        return "Digitale vormgeving";
                    case "IOT":
                        return "Internet Of things"; 
                }
                return "";
                
            }
            set { omschrijving = value; }
        }

        public Vak()
        {
            MaakKolommen();
        }

        public Vak(string code)
        {
            VakCode = code;
        }

        public Vak(string code, string omschr)
        {
            MaakKolommen();
            VakCode = code;
            Omschrijving = omschr;
            VoegRijToe();
        }

        public DataTable DtVak
        {
            get; set;
        }

        public override void MaakKolommen()
        {
            string tableName = "Vak";
            if (Databank.DsStudent.Tables.Contains(tableName))
            {
                DtVak = Databank.DsStudent.Tables[tableName];
            }
            else
            {
                //Create Tabel
                DtVak = new DataTable(tableName);
                DtVak.Columns.Add("Code", typeof(string));
                DtVak.Columns.Add("Omschrijving", typeof(string));
                // Tabel toevoegen aan dataset
                Databank.DsStudent.Tables.Add(DtVak);
            }
        }

        public void VoegRijToe()
        {
            DataRow dr = DtVak.NewRow();
            dr["Code"] = VakCode;
            dr["Omschrijving"] = Omschrijving;
  
            DtVak.Rows.Add(dr);
        }
    }
}
