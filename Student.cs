using System;
using System.Xml.Linq;
class Student
{
        string? name; public string Name
{
    get { return name; }
    set { name = value; }
}
string? surname;
public string Surname
{
    get { return surname; }
    set { surname = value; }
}
string? surname2;
public string Surname2
{
    get { return surname2; }
    set { surname2 = value; }
}
char group;
public char Group
{
    get { return group; }
    set { group = value; }
}
int age;
public int Age
{
    get { return age; }
    set { age = value; }
}
int[][] journal = new int[3][];
/*public void set_initials(int numb,string new_n)    {
   if(numb == 1) { this.name = new_n;}       else if(numb == 2) {  this.surname = new_n;}
    else if(numb == 3) { this.surname2 = new_n; }    }
public void set_group(char groupP) { this.group = groupP;}    public void set_age(int age) {  this.age = age;}
public void get_initials()    {
    Console.Write(this.name);        Console.Write("  ");
    Console.Write(this.surname);        Console.Write("  ");
    Console.WriteLine(this.surname2);    }
public void get_group() { Console.WriteLine(this.group); }    public void get_age() { Console.WriteLine(this.age); }*/
public void show_journal()
{
    for (int i = 0; i < journal.Length; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("Программирование:");
        }
        else if (i == 1)
        {
            Console.WriteLine("Администрирование:");
        }
        else if (i == 2)
        {
            Console.WriteLine("Дизайн:");
        }; for (int j = 0; j < journal[i].Length; j++)
        {
            Console.Write(journal[i][j]);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}
public void set_journal(int num, int[] arr)
{
    this.journal[num] = new int[arr.Length]; for (int i = 0; i < arr.Length; i++)
    {
        this.journal[num][i] = arr[i];
    }
}
public double mid_ball(int num)
{
    double count = 0; foreach (int i in this.journal[num])
    {
        count += i;
    }
    double mid = count / journal[num].Length;
    return mid;
}
public void student_info()
{
    Console.WriteLine("Student:"); Console.Write("Initials: ");
    Console.Write(this.name); Console.Write("  ");
    Console.Write(this.surname); Console.Write("  ");
    Console.WriteLine(this.surname2); Console.Write("Group: ");
    Console.WriteLine(this.group); Console.Write("Age: ");
    Console.WriteLine(this.age); Console.WriteLine("Journal: ");
    this.show_journal();
}
    }
class Program
{
    static void Main(string[] args)
    {
        

    
        
            Student student = new Student();
            student.Name = "Winston-Leonard"; student.Surname = "Spencer";
            student.Surname2 = "Churchill"; student.Group = '^';
            student.Age = 150; int[] programming = { 4, 3, 5, 2, 4, 3, 2 };
            student.set_journal(0, programming); int[] administrating = { 2, 2, 2, 2, 2, 3, 2 };
            student.set_journal(1, administrating); int[] design = { 5, 4, 3, 5, 5, 3, 4 };
            student.set_journal(2, design); student.student_info();
            Console.WriteLine(""); Console.WriteLine(student.mid_ball(0));
            Console.WriteLine(student.mid_ball(1)); Console.WriteLine(student.mid_ball(2));
            /*int[] programming = { 4, 3, 5, 2, 4, 3, 2 };        int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4, 5 };        for (int i = 0; i < programming.Length; i++)
            {            arr[0][i] = programming[i];
            }        for(int i = 0; i< arr[0].Length; i++)
            {            Console.WriteLine(arr[i].ToString());
            }*/
        
    }
}
