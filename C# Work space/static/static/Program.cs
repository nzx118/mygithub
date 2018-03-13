using System;

namespace static1
{
	/*
	1.静态类只能有静态成员和const常量
	2.静态类不能实例化
	3.静态构造方法声明没有访问修饰符
	4.静态构造成员引用只能用类引用
	5.静态构造方法在静态类中，在第一次引用静态成员时调用
	6.静态构造方法在普通类中，在创建对象（实例）时调用（和普通构造方法一样）
	*/
	public class A{
		static A(){
			Console .WriteLine("A的静态构造方法");

		}

	}

	public static class B{
		static B(){
			Console.WriteLine("B的静态构造方法");

		}
		public static int i;

	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			A a = new A ();
			B.i = 10;
			Console.WriteLine (B.i);
		}
	}
}
