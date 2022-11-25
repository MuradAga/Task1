using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Group Group { get; set; }
        public Student(string name, string lastname, Group group)
        {
            Name = name;
            Lastname = lastname;
            Group = group;
        }
    }
}
