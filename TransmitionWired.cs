using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Users_with_Objects
{
    public class TransmitionWired : HeadPhones
    {
        public string _wired { get; set; }

        public TransmitionWired(string type) : base()
        {
            _wired = type;
        }

        public void Transmition()
        {
            _wired = "Wired";
        }
        public override string ToString()
        {
            return this.GetType() + $" {_wired}";
        }
    }
}
