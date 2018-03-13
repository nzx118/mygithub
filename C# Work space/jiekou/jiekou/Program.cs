using System;

namespace jiekou
{/*
		接口声明和类相似，关键字是interface.
		接口内可有属性和方法，不能有字段
		接口内的方法在子类必须实现，在接口内不能实现
*/
	interface lArea{
		void Area();
	}

	interface lVolume{
		void  Volume();
	}

	public class Ball:lArea,lVolume{

		public int r;
		public void Area ()
		{
			Console.WriteLine ("Area is {0}",4 * Math.PI * r*r);

		}




		public void Volume ()
		{
			Console.WriteLine ("Volume is {0}",Math.PI * r * r);
		}

		
		
	}
	public class Cube:lArea,lVolume{

		public int a;
		public int b;
		public int c;
		public void  Area ()
		{
			Console.WriteLine ("Area is {0}",2 * (a * b + a * c + b * c));
		}



		public void  Volume ()
		{
			Console.WriteLine ("Volume is {0}",a * b * c);
		}

		
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Ball B1 = new Ball ();
			Cube C1 = new Cube ();
			B1.r = 1;
			C1.a = 1;
			C1.b = 2;
			C1.c = 3;
			B1.Area();
			B1.Volume();
			C1.Area ();
			C1.Volume ();



		}
	}
}
