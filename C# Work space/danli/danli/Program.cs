using System;

namespace danli
{//一个类只有一个对象：方法：1.把构造函数私有化。2.提供静态实例。3.提供调用静态实例的接口
	/*
	1.静态成员和静态成员函数存储整个类的信息，只有唯一一个
	2.静态成员函数只能引用静态成员，非静态成员函数可以调用静态成员

	*/
	public class Player{
		public string name;
		public int level;
		public int exp;
		public int maxexp;
		public int hp;
		public int maxhp;

		public void hit(){
			if (hp > 10) {
				hp -= 10;
			} else {hp = 0;
				Console.WriteLine ("You Are Dead.");
			}
		}
		public void getexp(){
			if (exp < maxexp) {
				exp += 10;
			} else {
				level++;
				exp = 0;

			}

		}
	
		private static Player _Instance;
		private Player(){}
		public static Player GetInstance(){
			if(null==_Instance)
				_Instance=new Player();
			return _Instance;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Player A = Player.GetInstance ();
			A.name ="K";
			A.exp = 0;
			A.maxexp = 20;
			A.hp = 20;
			A.maxhp = 100;
			A.level = 1;
			A.hit ();
			Console.WriteLine (A.hp);
			A.hit ();

			A.getexp();
			Console.WriteLine("Level is {0}",A.level);
			A.getexp();
			Console.WriteLine("Level is {0}",A.level);
			A.getexp();
			Console.WriteLine("Level is {0}",A.level);

			Player B = Player.GetInstance ();

			Console.WriteLine("Hp is {0}",B.hp );
		}
	}
}
