using System;
using System.Collections.Generic;//引入命名空间
namespace zhanduilie
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stack<int> A=new Stack<int>();
			//栈没有插入删除方法
			//后进先出
			A.Push(3);
			A.Push (4);
			A.Push (5);
			//入栈


			int a = A.Pop ();//出栈并删除元素
			Console.WriteLine (a);





			//队列先进先出


			Queue<string> Q=new Queue<string>();
			Q.Clear();
			int b=Q.Count;
		


			Q.Enqueue("laowang");
			Q.Enqueue("xiaoming");	//加入队列


			string c=Q.Dequeue();
			string d = Q.Dequeue ();//获取队列元素并移除
			Console.WriteLine (c);
			Console.WriteLine (d);
		}
	}
}
