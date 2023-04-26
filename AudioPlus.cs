using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Users_with_Objects
{
    internal static class AudioPlus
    {
        public static string _firstName;
        public static string _lastName;
        private static List<HeadPhones> _headphones;

        static AudioPlus()
        {
            _headphones = new List<HeadPhones>();
            _headphones.Add(new HeadPhones());
            //_headphones.Add("Beyerdynamic", "Open Back", "DT 1990 Pro", 42000, "");
        }

        public static string FirstName { get => _firstName; set => _firstName = value; }
        public static string LastName { get => _lastName; set => _lastName = value; }
        public static List<HeadPhones> Headphones { get => _headphones; set => _headphones = value; }

        public static void AddSubscription(HeadPhones headPhones, string fName, string lName)
        {
            _headphones.Add(headPhones);
            _firstName = fName;
            _lastName = lName;
        }
    }
}
