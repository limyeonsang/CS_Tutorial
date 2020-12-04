using System;
using System.Data;
using static System.Math;

namespace ABA	
{
	public class Class1
	{
		public static void Main()
        {
			Console.WriteLine(nameof(System)); //nameof(): 클래스 또는 메서드 이름을 문자열로 가져옴

			//Math 클래스 using static System.Math; 적기
			Console.WriteLine(Math.Max(3, 5)); //최대
			Console.WriteLine(Math.Min(3, 5)); //최소값
		}
	}
	ㅌ
}