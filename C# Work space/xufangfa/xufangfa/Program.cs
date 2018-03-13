using System;

namespace xufangfa
{
	//方法替换：在子类中用new重新定义父类中的同名方法，使得调用子类的方法时和父类的不一样
	//虚方法：父类型的子对象，调用子对象参数
	public class Person{
		public  void A(){
			Console.WriteLine ("Person类中调用的方法A");

		}
		public virtual void B(){
			Console.WriteLine ("Person类中调用的方法B");
		}
	}
		public class Student:Person {
			public new void A(){
				
				Console.WriteLine ("Student类中调用的方法A");
			}

		public override void B(){
			Console.WriteLine ("Student类中调用的方法B");
		}
		}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Person I = new Person ();
			I.A();
			Student J = new Student ();
			J.A();

			Person K = new Student ();
			K.A();
			K.B ();

		}
	}
}
