using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wonders_of_World
{
    public partial class ThePyramidOfHeops
    {
        int number;
        public int Number
        {
            set { number = value > 0 && value < 8 ? value : 0; }
            get { return number; }
        }
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        string country;
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        string wiki;
        public string Wiki
        {
            get { return wiki; }
            set { wiki = value; }
        }
        public void get_info()
        {
            Console.Write("Wonder ", Name, " is number ");
            Console.WriteLine(Number);
            Console.WriteLine("Wonder is located in the country of ", Country, ".");
            Console.WriteLine(Wiki);
        }
    }
}
