using System;
using System.Globalization;
using System.Net.WebSockets;

namespace CS_Textbook
{
    class CSTb
    {
        static void Main(string[] args)
        {
            //출력
            //string name = "임연상";
            //string name1 = "연상";
            //Console.WriteLine("안녕하세요 {0}입니다, 저는 {1}입니다.", name, name1); //자리 지정자
            //Console.WriteLine("Hello World!"); //자동 줄바꿈
            //Console.Write("Hello World"); //no줄바꿈

            //Console.WriteLine("안녕 \"난 큰따옴표야.\""); //따옴표 = \"

            //const int Max = 100;  //const로 선언 후에는 값을 다시 바꿀 수 없다.

            //string hi = @"안녕
            //하세요";
            //Console.WriteLine("{0}", hi); //빈 공간까지 문자열로 저장

            //string message = "Hello";
            //int number = 3;
            //Console.WriteLine($"{message} {number}아"); //'$'를 사용하면 바로 문자열 출력(문자열 보간법)

            //string msg = string.Format("{0}님, {1}", 바보, 안녕하세요);
            //Console.WriteLine(msg); // 변수 msg에 저장하고 거시기

            //string name = "C#";
            //string version = "8.0";
            //Console.WriteLine("{0} {1}", name, version); 
            //string result = String.Format("{0} {1}", name, version); //string.Format() 메서드 사용
            //Console.WriteLine(result); 
            //Console.WriteLine($"{name} {version}"); //문자열 보간법 사용

            //bool bln = true; //or false
            //Console.WriteLine(bln);

            //응용
            //char c = 'a';
            //string s = "hello";
            //bool b = true;
            //Console.WriteLine($"{c}\n{s}\n{b}"); 

            //예제
            //Console.ReadLine(); //입력받기
            //Console.WriteLine(Console.ReadLine()); //입력받고 출력
            //string name = Console.ReadLine(); //변수에 입력받기
            //Console.WriteLine($"{name}님 안녕하세요"); //변수출력
            //int x = Console.Read(); //한 문자만 입력됨, 정수로 반환
            //Console.WriteLine(x); //정수로 출력됨
            //Console.WriteLine(Convert.ToChar(x)); //형변환으로 문자로 출력

            //long l = long.MaxValue //long형식 변수의 가장 큰 값을 저장

            //형변환
            //Convert.To~() //~형식으로 변경됨
            //Console.WriteLine(Convert.ToString(10, 2).PadLeft(8, '0')); //10을 2진수로 나타냄,PadLeft:8자리까지 나타냄,0으로채움
            // 0b,0B로 2진수 표현 됨 int b1 = 0b0010

            //var number = 1234; //var message = "안녕하세요" .ect
            //var덕분에 입력되는 값에 따라 자동 형변환 

            //var s = Console.ReadLine();
            //var c = Convert.ToChar(Console.Read());
            //Console.Write($"{s} : {s.GetType()}, {c} : {c.GetType()}"); //변수명.GetType() 변수의 형식을 출력

            //키보드의 키 값 입력받기
            //ConsoleKeyInfo cki = Console.ReadKey(true);
            //Console.WriteLine("{0}", cki.Key);
            //Console.WriteLine("{0}", cki.KeyChar);
            //Console.Write("{0}", cki.Modifiers);

            //default 초기화
            //int i = default; //ect 숫자 데이터 형식은 0
            //char c = default; //char는 \0
            //string s = default; // string은 NULL
            //bool b = default; // bool은 false 
            //Console.WriteLine($"{i} {c} {s} {b}"); //초기화할 때 사용하는 default

            //연산자
            //int value = default;
            ////value = 8; //or -8
            ////value = + +value; //+는 부호 그대로 
            ////Console.WriteLine($"{value}");
            ////value = 8; //or -8
            ////value = -value; //-value에서 -는 부호를 바꿔준다
            //Console.WriteLine(value);

            //decimal i = 3.14M; //decimal형식은 실수 데이터를 저장
            //decimal j = 3.14M; //M을 접미사로 붙여 초기화함
            //decimal sum = i - j;
            //Console.WriteLine(sum); //소숫점 자리까지 계산해줌
            //나누기 연산자는 0으로 나누면 에러가 뜸
            //Console.WriteLine(3/0); //= error

            //+연산자는 문자열일 때는 문자열 연결 기능이 있다
            //Console.WriteLine("Hello" + "World");
            //Console.WriteLine("Hi"+" "+"everyone");
            //Console.WriteLine("123" + true);
            //Console.WriteLine("123" + "456");

            //비교 연산자
            //int x = 3;
            //int y = 5;
            //Console.WriteLine(x == y); //==.ect 비교 연산자는 ture or false를 출력
            //Console.WriteLine("AAA" != "aaa"); //==은 문자열 비교도 ㄱㄴ

            //논리 연산자
            //var i = 3;
            //var j = 5;
            //var r = false;
            //r = (i == 3) && (j != 3); //i==3=true, j!=3=true
            //Console.WriteLine(r); //true && true = true

            
        }
    }
}
