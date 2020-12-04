using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.WebSockets;

/*template
  class CSTb
{
    static void Main(string[] args)
    {

    }
}
 */

//함수의 여러가지 활용법
//namespace CS_Textbook
//{
//    class CSTb
//    {
//        static void Main(string[] args)
//        {
//            Log("디버그");
//            Log("에러", 4);

//        }

//        static void Log(string message, byte level = 1) //매서드 선언시 동시에 초기화하면 매서드를 호출할 때
//        {                                               //매개변수를 지정하지 않아도 기본값으로 자동설정
//            Console.WriteLine($"{message}, {level}");
//        }
//    }
//}
//namespace CS_Textbook
//{
//    class CSTb
//    {
//        static void Main(string[] args)
//        {
//            Sum(first: 10, second: 20); //매개변수를 지정해서 값을 넣을 수 있다
//            Sum(second: 10, first: 20); //뒤집어서 사용가능
//        }
//        static void Sum(int first, int second)
//        {
//            Console.WriteLine(first + second);
//        }
//    }
//}
//namespace CS_Textbook
//{
//    class CSTb
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

/*함수 오버로드 //클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의하는 것
namespace CS_Textbook
{
    class CSTb
    {
        static void Hi() //ㄱ.매개변수가 없는 함수로 오게된다
        {
            Console.WriteLine("안녕하세요");
        }
        static void Hi(string msg) //ㄴ.string매개변수가 있는 함수로감
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            Hi(); //ㄱ.매개변수를 안넘긴 경우
            Hi("반갑습니다"); //ㄴ.매개변수로 넘기는 데이터가 string인 경우
        }
    }
} */

/* //재귀함수 팩토리얼 예제
namespace CS_Textbook
{
    class CSTb
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Fact(4));
        }
        static int Fact(int n)
        {
            return (n > 1) ? n * Fact(n - 1) : 1;
        }
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}*/

//전역변수: static 형식 변수명 = 값; 으로 선언 ex)static string message = "전역 변수";

//namespace CS_Textbook
//{
//    class CSTb
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

/* //화살표 연산자: 함수를 간결하게 해줌
namespace CS_Textbook
{
    class CSTb
    {
        static bool Same(string a, string b) => a==b;
        static void Multiply(int a, int b) => Console.WriteLine(a * b);

        static void Main(string[] args)
        {
            Same("A", "B");
            Multiply(3,5);
        }
    }
}*/

/* 로컬함수와 화살표 연산자 사용하기
namespace CS_Textbook
{
    class CSTb
    {
        static void Main(string[] args)
        {
            //void Display(string text)
            //{
            //    Console.WriteLine(text);
            //}
            //Display("로컬 함수"); 
            
            //화살표 연산자+로컬
            int Add(int a, int b) => a + b; //로컬 함수 선언
            decimal Subtract(decimal x, decimal y) => x - y;

            Console.WriteLine($"3+5 = {Add(3, 5)}"); //로컬 함수 사용
            Console.WriteLine($"34.56 - 12.34 = {Subtract(34.56M, 12.34M)}");
        }
    }
}*/

/* 구조체 배열 활용
namespace CS_Textbook
{
    struct BusinessCard
    {
        public string Name;
        public int Age;
    }
    class CSTb
    {
        static void Print(string name, int age)
        {
            Console.WriteLine($"{name}은 {age}살");
        }
        static void Main(string[] args)
        {
            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "짱구"; names[0].Age = 17;
            names[1].Name = "철수"; names[1].Age = 17;
            for (int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}*/

/*매개변수가 많다면 구조체로 묶어 매개변수로 전달
    struct Member
    {
        public string Name;
        public int Age;
    }
    class CSTb
    {
        static void Main(string[] args)
        {
            Member m;
            m.Name = "짱구";
            m.Age = 35;
            Print(m);
        }
        static void Print(Member member) => Console.WriteLine($"이름: {member.Name} 나이: {member.Age}");
    }*/

/*내장형 구조체 
날짜관련 p.292~296 / 문자관련 p.296~297
class CSTb
{
    static void Main(string[] args)
    {
        string unique = Guid.NewGuid().ToString();
        Console.WriteLine($"유일한 값: {unique}");
        Console.WriteLine(Guid.NewGuid().ToString("D")); //D사용->하이픈으로 구별된 32자리 숫자로 표현
    }
}*/

/*ConsoleColor 열거형
class CSTb
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}*/

//enum Priority
//{
//    High, Nornal, Low
//}
//class CSTb
//{
//    static void Main(string[] args)
//    {
//        Priority high = Priority.High;
//        Priority normal = Priority.Nornal;
//        Priority low = Priority.Low;

//        Console.WriteLine($"{high}, {normal}, {low}");
//    }
//}

class CSTb
{
    static void Main(string[] args)
    {
        string color = "Red";
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}