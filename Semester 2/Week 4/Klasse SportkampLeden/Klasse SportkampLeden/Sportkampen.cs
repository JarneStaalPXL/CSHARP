using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Klasse_SportkampLeden
{
    public class Sportkampen
    {
        private static readonly string bestand = @"Sporten.txt";
        public static string[,] InlezenKamp()
        {
            //File.ReadAllLines(bestand).Length; Can use this instead of 7 if line amount is unknown
            string[,] spKamp = new string[7, 3];
            string[] velden;
            int i = 0;

            if (File.Exists(bestand))
            {
                using (StreamReader sr = new StreamReader(bestand))
                {
                    while (!sr.EndOfStream)
                    {
                        velden = sr.ReadLine().Split(';');
                        spKamp[i, 0] = velden[0].Replace("\"", "");
                        spKamp[i, 1] = velden[1].Replace("\"", "");
                        spKamp[i, 2] = velden[2].Replace("\"", "");
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kan bestand Sporten.txt niet vinden","Foutmelding");
            }
            return spKamp; 
        }
    }
}
