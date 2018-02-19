using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List < c1 > listC1= new List<c1>() { new c1() { id = 1, name = "one" }, new c1() { id = 2, name = "two" }, new c1() { id = 3, name = "three" } };
            List<c2> listc2 = listC1.Select(x => ConvertC1ToC2(x)).ToList();
        }
        public static c2 ConvertC1ToC2( c1 first)
        {
            return new c2() { seq = first.id, group = first.name };
        }
        
    }


    class c1
    {
        public int id;
        public string name;
    }
    class c2
    {
        public int seq;
        public string group;
    }
}
