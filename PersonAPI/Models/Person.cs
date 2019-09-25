using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAPI.Models
{
    public class Person
    {
        public Person(long id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }
    }
}
