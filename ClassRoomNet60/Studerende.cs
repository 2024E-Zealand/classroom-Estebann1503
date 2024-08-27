using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        // Properties
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
           
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            private set { _fødselsmåned = value; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
            private set { _fødselsdag = value; }
        }

        // Constructor
        public Studerende(string _navn, int _fødselsmåned, int _fødselsdag)
        {
            Navn = _navn;
            Fødselsmåned = _fødselsmåned;
            Fødselsdag = _fødselsdag;
        }

        // Metode til at bestemme årstiden
        public string Årstid()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                return "Vinter";
            }
            else if (Fødselsmåned >= 3 && Fødselsmåned <= 5)
            {
                return "Forår";
            }
            else if (Fødselsmåned >= 6 && Fødselsmåned <= 8)
            {
                return "Sommer";
            }
            else if (Fødselsmåned >= 9 && Fødselsmåned <= 11)
            {
                return "Efterår";
            }
            else
            {
                return "Ugyldig måned";
            }
        }

    }
}
