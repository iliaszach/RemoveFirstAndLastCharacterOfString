using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFirstAndLastCharacterOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Remove_char("ok");
            Console.WriteLine(a);
        }

        public static string Remove_char(string s)
        {
            var a = s.Remove(0, 1).Remove(s.Length - 2);
            return a;
        }
    }
    }
}
