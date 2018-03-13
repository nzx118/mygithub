using System;

namespace chongzai
{
	public class calculate{

		public int sum(int a,int b){

			return(a + b);
		}
		public float sum(float a,float b){
			return(a + b);

		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			calculate A = new calculate ();
			
			Console.WriteLine ("{0},{1}",A.sum (3, 4) ,A.sum (5.2f, 4.6f));
		}
	}
}
