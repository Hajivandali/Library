using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using test;


public class Program
{
    public static void Main()
    {
        Obj obj1 = new Obj();
        List<model> models = obj1.res();
        
        Obj obj2 = new Obj();
        List<string> models1 = obj2.NumString();

        Obj obj3 = new Obj();
        List<model> models2 = obj3.Order();

        Obj obj4 = new Obj();
        IEnumerable<IGrouping<int, model>> groupedModels = obj4.Groupby();

        Obj obj5 = new Obj();
        List<model> models3 = obj5.Distinct();



        foreach (var item in models3 )
        {
            Console.WriteLine($"DIstance :{item.Name}");
           
        }





        // foreach (var Group in groupedModels)
        // {
        //     Console.WriteLine($"position  : {Group.Key} , Count : {Group.Count()}");
        //     Console.WriteLine("_________________________");
        //     foreach (var item in Group)
        //     {
        //         Console.WriteLine($"Name: {item.Name} ");
                 
        //     }

        // }   


        // foreach (var item in models2)
        // {
        //     Console.WriteLine($"Name: {item.Name} ID: {item.Id} Age: {item.Age}");
        //      foreach (var mobile in item.Mobile)
        //     {
        //         Console.WriteLine($"Mobile: {mobile}");
        //     }      
        // }


        // foreach (var x in models1)
        // {
        //     Console.WriteLine($"num : {x}");
        // }

        


        // foreach (var Stu in models) 
        // {
        //     Console.WriteLine($" Name: {Stu.Name } ID: {Stu.Id}  AGE: {Stu.Age} ");
        // }



        Console.ReadKey();

    }

}
