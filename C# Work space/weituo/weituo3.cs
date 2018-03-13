using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {//左手拿杯b上。右手拿杯a上。
        public delegate void Act(string hand);
        class Teacher {
            public event Act IWillAct;
            public void Ouch(string hand) {
                Console.WriteLine("老师是"+hand+"手拿杯");
                if (IWillAct!=null)
                {
                    IWillAct(hand);
                }
            }
        }

        class StudentB {
            Teacher C;

            public StudentB(Teacher N) {
                C = N;
                N.IWillAct += new Act(React);

            }
            public void React(string hand) {
                if (hand.Equals("左"))
                {
                    Console.WriteLine("老师我B来");
                    Console.ReadKey();
                }

            }
        }

        class StudentA
        {
            Teacher C;

            public StudentA(Teacher N)
            {
                C=N;
                N.IWillAct += new Act(React);
            }
            public void React(string hand)
            {
                if (hand.Equals("右"))
                {
                    Console.WriteLine("老师我A来");
                    Console.ReadKey();
                }

            }
        }
        static void Main(string[] args)
        {
            Teacher C = new Teacher();
            StudentB B = new StudentB(C);
            StudentA A = new StudentA(C);
            C.Ouch("右");
        }
    }
}
