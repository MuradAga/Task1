using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Group group1 = new Group(1, "655.20");
            Student student1 = new Student("Araz", "Merdanov", group1);
            Student student2 = new Student("Araz2", "Merdanov2", group1);
            Student student3 = new Student("Araz3", "Merdanov3", group1);


            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.RemoveStudent(student2);

            foreach (var item in group1.Students)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
