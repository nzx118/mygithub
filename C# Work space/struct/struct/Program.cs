using System;

namespace struct1{

	public class A{
		public void swap(ref int a,ref int b){
			int temp;
		temp=a;
		a=b;
		b=temp;

	}
		public int Max(int i,int j,out int min){
			min = 0;
			if (i > j)
				min = j;
			else
				min = i;

			int max = i;
			if (i > j)
				max = i;
			else
				max = j;
			return max;

		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			
			A a = new A ();
		int i = 5;
		int j = 12;
			int k = 0;
			int z = a.Max (i, j,out k);
			a.swap (ref i, ref j);

			Console.WriteLine ("{0},{1}",i, j);
			Console.WriteLine ("{0},{1}", z, k);
			
		}
	}
}
