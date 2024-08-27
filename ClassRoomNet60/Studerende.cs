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

    }
}
