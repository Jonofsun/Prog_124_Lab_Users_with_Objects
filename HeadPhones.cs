using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Users_with_Objects
{
    public class HeadPhones
    {
        string _brand { get; set; }
        string _styleOfHeadphones { get; set; }
        string _modle { get; set; }
        int _frequency { get; set; }
        TransmitionWired TransmitionWired { get; set; }

        TransmitionWireless TransmitionWireless { get; set; }


        public HeadPhones()
        {
            _brand = string.Empty;
            _styleOfHeadphones = string.Empty;
            _modle = string.Empty;
            _frequency = 0;
            TransmitionWired = null;
            TransmitionWireless = null;
        }

        public HeadPhones(string brand, string styleOfHeadphones, string modle, int frequency, TransmitionWireless transmitionWireless)
        {
            _brand = brand;
            _styleOfHeadphones = styleOfHeadphones;
            _modle = modle;
            _frequency = frequency;
            TransmitionWireless = transmitionWireless;


        }

        public HeadPhones(string brand, string styleOfHeadphones, string modle, int frequency, TransmitionWired transmitionWired)
        {
            _brand = brand;
            _styleOfHeadphones = styleOfHeadphones;
            _modle = modle;
            _frequency = frequency;
            TransmitionWired = transmitionWired;
        }
        public override string ToString()
        {
            return $"{_brand} - {_styleOfHeadphones} - {_modle} - {_frequency} - {this.GetType()}"; 
        }
    }
}
