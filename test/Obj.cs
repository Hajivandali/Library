﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace test
{
    public class Obj :IEqualityComparer<model>
    {

        List<model> models = new List<model> { 
            new model{Id=100,Name="Ali",Age=24 , Mobile = new List<String> {"09123786262" }, Position = EmployeePosition.HR},
            new model{Id=101,Name="Ali",Age=44 , Mobile = new List<String> {"09323786262" }, Position = EmployeePosition.HR},
            new model{Id=102,Name="Ali",Age=21 , Mobile = new List<String> {"09123786261" }, Position = EmployeePosition.Developer},
            new model{Id=103,Name="mohsen",Age=21, Mobile = new List<String> {"09331786262" ,"091231231"},Position = EmployeePosition.Developer},
            new model{Id=104,Name="Alireza",Age=21, Mobile = new List<String> {"09331786262" ,"092231234"},Position = EmployeePosition.HR},
            new model{Id=105,Name="reza",Age=55 ,Mobile = new List<String> {"09121783262" ,"091222231"},Position = EmployeePosition.HR}
        
        };
        
        
        public List<model> Distinct()
        {
    var query = models
        .Select(x => new model { Name = x.Name })
        .Distinct(new ModelComparer())
        .ToList();
    
    return query;
        }



        public List<string> NumString(){
            
            var NumResult = models.SelectMany(x=>x.Mobile);
            var query = NumResult.Where(x=>x.Contains("0912")).ToList();
            return query;
           
        }

        public List<model> Order(){
            var result = from x in models
                         orderby x.Age descending , x.Name ascending
                         select x;

            var Result = result.ToList(); 
            // var result = models.OrderByDescending(x=>x.Name).ToList();
            return Result;
        }

        public IEnumerable<IGrouping<int, model>> Groupby(){    
            var result = models.GroupBy(x=> x.Position==EmployeePosition.Developer ? 1 : 2   )  ;
            return result ;
           }

        public List<model> res()
        {
            var result = models.Select(x => new model
            {
                Id  = x.Id,
                Name = x.Name,
                Age = x.Age,
            }).ToList();

            var finall = result.Where(x => x.Age < 30).ToList();
            return finall;

        }

        public bool Equals(model? x, model? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] model obj)
        {
            throw new NotImplementedException();
        }
    }
}
