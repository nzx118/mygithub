using System;

namespace fanxing
{
	//泛型：关键字<T>,能实现多种类型的参数，提高代码重用率
	public class Array<T>{
		
		public  Array(){
			arr = new T [100]; //声明数组
		}

		public int Count{
			get{ return _count;}//计数属性
		}
		public void add(T value){//添加数
			arr [_count] = value;
			_count++;
		}
		public void Log(){
			string str = "该数组有" + Count + "个数:(";  //显示所有数
			for (int i = 0; i < Count; i++) {
				str+=arr[i];
				if(i<Count-1)
					str+=",";
			}
			str+=")";
			Console.WriteLine (str);
		}

		private int _count=0;
		private T[] arr;

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Array<float> A = new Array<float> ();//要加<>
			A.add (12.3f);
			A.Log();
			A.add (6f);
			A.Log ();
		}
	}
}
