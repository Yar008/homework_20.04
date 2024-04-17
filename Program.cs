using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Wonders_of_World;
struct Gid
{
    int number;
    public int Number
    {
        set {number = value > 0 && value < 8 ? value : 0; }
        get { return number; }

    }
    bool start;
    public bool Start
    { 
        set { start = value; } 
        get { return start; }
    }
    public void entry()
    {
        if(this.number == 1)
        {
            Console.WriteLine("Welcome to Pyramid!");
            Wonders_of_World.Pyramid.get_info();
        }
        if (this.number == 2)
        {
            Console.WriteLine("Welcome to Ear!");
            Wonders_of_World.Ear.get_info();
        }
        if (this.number == 3)
        {
            Console.WriteLine("Welcome to Beacon!");
            Wonders_of_World.Beacon.get_info();
        }
        if (this.number == 4)
        {
            Console.WriteLine("Welcome to Temple!");
            Wonders_of_World.Temple.get_info();
        }
        if (this.number == 5)
        {
            Console.WriteLine("Welcome to Statue!");
            Wonders_of_World.Statue.get_info();
        }
        if (this.number == 6)
        {
            Console.WriteLine("Welcome to Mausoleum!");
            Wonders_of_World.Mausoleum.get_info();
        }
        if (this.number == 7)
        {
            Console.WriteLine("Welcome to Gardens!");
            Wonders_of_World.Gardens.get_info();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Wonders_of_World.Pyramid.Name = "The Pyramid of Heops";
        Wonders_of_World.Pyramid.Number = 1;
        Wonders_of_World.Pyramid.Country = "Egypt";
        Wonders_of_World.Pyramid.Wiki = "https://ru.wikipedia.org/wiki/Пирамида_Хеопса";

        Wonders_of_World.Ear.Name = "The Colossus of Rhodes";
        Wonders_of_World.Ear.Number = 2;
        Wonders_of_World.Ear.Country = "Greece";
        Wonders_of_World.Ear.Wiki = "https://ru.wikipedia.org/wiki/Колосс Родосский";

        Wonders_of_World.Beacon.Name = "The Lighthouse of Alexandria";
        Wonders_of_World.Beacon.Number = 3;
        Wonders_of_World.Beacon.Country = "Egypt";
        Wonders_of_World.Beacon.Wiki = "https://ru.wikipedia.org/wiki/Александрийский маяк";

        Wonders_of_World.Temple.Name = "Temple of Artemis of Ephesus";
        Wonders_of_World.Temple.Number = 4;
        Wonders_of_World.Temple.Country = "Turkey";
        Wonders_of_World.Temple.Wiki = "https://ru.wikipedia.org/wiki/Храм Артемиды Эфесской";

        Wonders_of_World.Statue.Name = "Statue of Zeus in Olympia";
        Wonders_of_World.Statue.Number = 5;
        Wonders_of_World.Statue.Country = "Greece";
        Wonders_of_World.Statue.Wiki = "https://ru.wikipedia.org/wiki/Статуя_Зевса_в_Олимпии";

        Wonders_of_World.Mausoleum.Name = "Mausoleum in Halicarnassus";
        Wonders_of_World.Mausoleum.Number = 6;
        Wonders_of_World.Mausoleum.Country = "Turkey";
        Wonders_of_World.Mausoleum.Wiki = "https://ru.wikipedia.org/wiki/Мавзолей_в_Галикарнасе";

        Wonders_of_World.Gardens.Name = "Hanging Gardens of Semiramis";
        Wonders_of_World.Gardens.Number = 7;
        Wonders_of_World.Gardens.Country = "Iraq";
        Wonders_of_World.Gardens.Wiki = "https://ru.wikipedia.org/wiki/Висячие_сады_Семирамиды";
        Gid obj = new Gid();
        Console.WriteLine("Welcome to wonders travel! You ready to start travel? 0 - no, 1 - yes");
        obj.Number = Int32.Parse(Console.ReadLine());
        while(obj.Number != 0)
        {
            Console.WriteLine("What number would you like to get into the miracle? 0 - if you want end the travel");
            obj.Number = Int32.Parse(Console.ReadLine());
            obj.entry();
        }
    }
}


