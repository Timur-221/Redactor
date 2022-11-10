using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public class Items
    {
        public Items(string name, int count)
        {
            Name = name;
            Count = count;
        }
        public string Name { get; set; }

        public int Count { get; set; }
    }
}
