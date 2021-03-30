using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestandPuntenKlasse
{
    public class PuntenAdmin
    {
        public float result = 0;

        public string Email { get; set; }
        public string Familyname { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }


        public float Percent()
        {
            result = (float)Score / TotalScore;
            return result;
        }

        public string Grade()
        {
            return (Percent() >= 0.8) ? "Geslaagd" : "Niet geslaagd";
        }

        public PuntenAdmin()
        {

        }

        public PuntenAdmin(string firstname, string familyname, string email, string gender, int score, int totalScore)
        {
            FirstName = firstname;
            Familyname = familyname;
            Email = email;
            Gender = gender;
            Score = score;
            TotalScore = totalScore;
        }
    }
}
