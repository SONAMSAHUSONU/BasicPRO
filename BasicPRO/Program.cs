/*using System;

namespace BasicPRO
{
    class Program
        //using class satic voiid public string are the keyword//
        //we true false null are not a keyword but it is reserve word//
        // we can't use the kwyword the name of variable method and class or any other identifiers//
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i am user");
            Console.ReadLine();
        }
    }
}
*/
/*
using System;

namespace BasicPRO
{
    class _Test
    {
        static void Main(string[] args)
        {
            string _firstname = "sonam";
            string @last_name = "sahu";
            int _age = 25;
            Console.WriteLine("_firstname");
            Console.WriteLine("@last_name");
            Console.WriteLine("_age");
            Console.ReadLine();
        }
    }
}*/

// ex:- int a;//


/*using System;
class _Test
{
    int a = 20;

    // non static golobal variable, if you have to print the goloble we have to write insid the class  (satic int a=1;)
    //or othwish we have to create the object inside the method  (<ClassName> refrencevariableName=new<className>();)

    static void Main(string[] args)
    {

        int i = 10; //local variable

        _Test obj = new _Test();

        Console.WriteLine(i);
        Console.WriteLine(obj.a);

        Console.ReadLine();
    }
}
    
    // always first exicute the nerest variable
    */

/*using System;
class _Test
{
    int a = 20; //for that we have to create the object then we can acces non static varible in main method

    static void Main(string[] args)
    {

        int i = 10; //local variable

        _Test obj = new _Test();

        Console.WriteLine(i);
        Console.WriteLine(obj.a);

        Console.ReadLine();
    }
}*/

/*using System;
class _Test
{
   public static int i = 20;
    public static byte b = 30;
    public static string name = "Sonam";
    public static int age = 18;

    static void Main(string[] args)
    {

        int i = 10;

        Console.WriteLine(b);
        Console.WriteLine(i);
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(_Test.i);

        Console.ReadLine();
    }
}
*/
/*
using System;
class _Test
{

    static void Main(string[] args)
    {
        //this is constant variable 

       const int i = 10;
        const short j = 2;
        const byte k = 3;
        const double m = 20.4;// we can declare only one time with using const keyword 
        const float f = 4.25f;

        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(m);
        Console.WriteLine(f);
        Console.WriteLine(i);

        Console.ReadLine();
    }
}*/



using System;
public class AreaOfTriangle
{
    public static void Main()
    {
        const double Base = 2;
        const double Height = 3;

        Console.WriteLine("the Base is:");
        Console.WriteLine(Base);
        Console.WriteLine("the Height is:");
        Console.WriteLine(Height);

        double Area = (Base * Height) / 2;
        Console.Write("Area of a Triangle = " + Area);
        Console.ReadKey();
    }
}


