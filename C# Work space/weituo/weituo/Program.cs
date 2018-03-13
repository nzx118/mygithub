using System;

namespace weituo
{
	public delegate void Something(string name);  //声明委托
	public class Student{
		private string name;
		public Student(string Name){
			name = Name;
		}
		public void Do(Something P){ //参数为一个方法P
			P(name);
		}
	}

	public class Teacher{
		public  void hungry(){
			Student A = new Student ("xiaohong");

			Something S = new Something (call);
			A.Do(S);
		}
		public void call(string name){
			Console.WriteLine ("111,{0}",name);
		}

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Teacher K = new Teacher ();
			K.hungry ();
		}
	}
}
