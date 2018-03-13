using System;

namespace chouxiang
{/*
抽象类的特点：
1.有抽象方法时，那个类必须为抽象类
2.子类运用抽象方法时，加override
3.抽象方法在父类中只声明不实现，但在子类必须全部实现

*/
	public abstract class Ball{
		public abstract void Play();

	}

	public class Basketball:Ball{
		public override void Play(){
			Console.WriteLine ("I'm playing basketball");

		}
	}

	public class Football:Ball{
		public override void Play(){
			Console.WriteLine ("I'm playing football");

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
				Ball A=new Basketball();
				Ball B = new Football ();
				A.Play ();
				B.Play ();
		}
	}
}
}