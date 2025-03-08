using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using test;


public class Program
{
    public static void Main()
    {


        Obj obj1 = new Obj();
        List<model> models = obj1.res();

         


        foreach (var Stu in models) 
        {
            Console.WriteLine($" Name: {Stu.Name } ID: {Stu.Id} AGE: {Stu.Age} ");
        }


        Console.ReadKey();

    }

}
