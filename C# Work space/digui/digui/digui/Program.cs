using System;

namespace digui
{
	public class person{
		public int digui(int a){
			if (a > 1) {
				return digui (a - 1) + a;
			} else
				return 1;
		}

		public long leicheng(int a){
			if (a > 1) {
				return a * leicheng (a - 1);

			} else
				return 1;

		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			person A = new person ();
			Console.WriteLine ("{0},{1}", A.digui(100),A.leicheng(18));
		}
	}
	}

