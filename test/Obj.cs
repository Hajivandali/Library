using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Obj
    {
        List<model> models = new List<model> { 
            new model{Id=100,Name="Ali",Age=24},
            new model{Id=101,Name="Alireza",Age=52},
            new model{Id=102,Name="reza",Age=55}
        
        };
        public List<model> res()
        {
            var result = models.Select(x => new model
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age
            }).ToList();

            return result;

        }
         

    }
}
