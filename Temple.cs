using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonders_of_World
{
    public class Temple
    {
        static int number;
        public static int Number
        {
            set { number = value > 0 && value < 8 ? value : 0; }
            get { return number; }
        }
        static string name;
        public static string Name
        {
            set { name = value; }
            get { return name; }
        }
        static string country;
        public static string Country
        {
            set { country = value; }
            get { return country; }
        }
        static string wiki;
        public static string Wiki
        {
            get { return wiki; }
            set { wiki = value; }
        }
        public static void get_info()
        {
            Console.Write("Wonder ");
            Console.Write(Name);
            Console.Write(" is number ");
            Console.WriteLine(Number);
            Console.Write("Wonder is located in the country of ");
            Console.Write(Country);
            Console.WriteLine(".");
            Console.WriteLine(Wiki);
        }
    }
}
