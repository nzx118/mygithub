using System;
using System.Collections.Generic;  //首先引用命名空间

namespace List
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> arr=new List<int>();
			arr.Add(1);
			arr.Add(3);
			arr.Add (2);
			arr.Add (4);
			arr.Add (5);
			arr.Add (8);
			arr.Remove (1);    //移除元素名
			arr.RemoveAt (0);	//移除位置
			arr.Insert(1,3);     //添加位置与内容
			arr.Clear();		//清除表
			int a = arr.Count;		//内容个数
			arr.Add(1);
			bool b=arr.Contains(1);	//判断元素是否在数组中
			Console.WriteLine (arr[0]);
		}
	}
}
