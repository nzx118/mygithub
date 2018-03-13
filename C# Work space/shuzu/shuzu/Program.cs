using System;

namespace shuzu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArray = new int[5];
			float[] floatArray = new float[5];
			intArray [0] = 7;
			Console.WriteLine (intArray[0]);
			int[,] numbers=new int[2,3] ;
			numbers [1, 2] = 5;

			Console.WriteLine(numbers[1,2]);
			//遍历numbers数组，依次获取里面的int类型元素

			foreach (int num in numbers) {
				Console.WriteLine (num);
			}
		}
	}
}
