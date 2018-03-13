using System;
using System.Collections.Generic;//引入命名空间
//字典用来存储无序的键值对
namespace zidian
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<string,int> dic=new Dictionary<string, int>();//创建对象
			int s;
			dic.Clear();
			dic.Add("xiaowang",3);
			dic.TryGetValue("xiaowang",out s);//尝试获取key,并存储value在s中
			int d = dic ["xiaowang"];//获取值value
			Console.WriteLine (d);
			Console.WriteLine (s);
		}
	}
}
