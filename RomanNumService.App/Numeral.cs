using System;

namespace RomanNumService
{
    public class Numeral
    {
        private string _numeral;
        private int _value;

        public Numeral(string romanNumeral, int value)
        {
            _numeral = romanNumeral;
            _value = value;
        }

        public string RomanNumeral
        {
            get { return _numeral; }
        }

        public int Value
        {
            get { return _value; }
        }
    }
}