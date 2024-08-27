using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class KlasseRum
    {
        // Properties
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        // Default constructor
        public KlasseRum()
        {
            Klasseliste = new List<Studerende>();

        }

        // Metode til at tælle antal fødselsdage per årstid
        public void TælFødselsdagePerÅrstid()
        {
            var fødselsdagePerÅrstid = Klasseliste
                .GroupBy(studerende => studerende.Årstid())
                .Select(gruppe => new
                {
                    Årstid = gruppe.Key,
                    Antal = gruppe.Count()
                });

            Console.WriteLine("Antal fødselsdage per årstid:");
            foreach (var item in fødselsdagePerÅrstid)
            {
                Console.WriteLine($"{item.Årstid}: {item.Antal}");
            }
        }
    }
}
