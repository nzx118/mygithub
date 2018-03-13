using System;

namespace gouzao
{
	//1.构造方法和类名一样
	//2.构造方法不能有返回值，不写void
	//3.能加参数,允许重载
	public class person{
		public string name;
		public person(string name){
			this.name = name;
			Console.WriteLine ("Hello");
		}
		//析构函数：1.只有一个析构函数，用于对象销毁时释放内存
		//			2.不能有返回值
		//			3.不能手动调用，由系统自动调用
		//			4.没有访问修饰符，没有参数，不能重载
		~person(){
			Console.WriteLine ("析构函数");
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			person A=new person("K");
			Console.WriteLine ("{0}",A.name);
		}
	}
}
