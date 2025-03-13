using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Mobile { get; set; }
        public EmployeePosition Position { get; set; }
    }

    public enum EmployeePosition
    {
        Developer = 1,
        HR = 2
    }
}