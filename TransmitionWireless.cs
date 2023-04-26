using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Users_with_Objects
{
    public class TransmitionWireless : HeadPhones
    {
        public string _wireless { get; set; }

        public TransmitionWireless(string type) : base()
        {
            _wireless = type;
        }

        public void Transmition()
        {
            _wireless = "Wireless";
        }
        public override string ToString()
        {
            return this.GetType() + $" {_wireless}";
        }
    }
}
