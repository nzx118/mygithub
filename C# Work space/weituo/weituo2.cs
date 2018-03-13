using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        delegate void use(string name); 
        class Teacher {
            
            public void Hungry()
            {
                Student A = new Student("xiaowang");
                use Gan = new use(Oh);
                A.React(Gan);
            }
            public void Oh(string name) {//初始化USE时说的话
                Console.WriteLine("Hello"+name);
                Console.ReadKey();
            }
        }

        class Student {
            public string name;
           public  Student(string Name) {
                name = Name;
            }
            public void React(use B) {
                B(name);
                Console.WriteLine("好");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Teacher A = new Teacher();
            A.Hungry();
        }
    }
}
