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
    }
}
