using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using System.Net.WebSockets;

namespace CS_Textbook
{
    class CSTb
    {
        static void Main(string[] args)
        {
            //조건문(if)
            //string s1 = "Hello.";
            //string s2 = "Hello.";
            //if(s1 == s2)
            //  Console.WriteLine("Same"); //문자열 비교

            //bool bln = false; //과 if(!bln)은 같은걸 의미

            //알아서 손해 볼거 없는 것
            //int a = Convert.To~(Console.ReadLine()); //~형으로 입력받는 방법
            //예약어 + Tab+Tab으로 코드 자동생성
            //ctrl + c로 명령 프롬포트에서 무한 루프를 종료 할 수 있다

            //foreach (var item in collection) { } //배열에 데이터가 있는 동안 반복


            //배열
            //type[] 변수명; : 배열선언 
            //데이터형식[] 배열이름 = new 데이터형식[크기]; : 배열을 지정한 크기로 만들어주는 연산자 
            //ex) int[] number = new int[3]; //int형 인덱스가 3개
            //int[] number = new int[3] { 1, 2, 3 }; //이런식으로 선언과 동시에 초기화
            //int[] number = { 1, 2, 3 }; //이런식으로도 ㄱㄴ

            //예제
            //var array = new int[] { 1, 2, 3 };
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i}번째 인덱스 : {array[i]}");
            //}
            //foreach(int value in array)
            //{
            //    Console.WriteLine("{0}", value);
            //}

            //문자열 배열
            //string[] languages = { "Korean", "English", "Spanish" }; //선언과 동시에 초기화
            //Console.WriteLine($"{languages[0]}, {languages[1]}, {languages[2]}");

            //int[] numbers = { 1, 1_000, 10_000, 1_000_000 }; //'_'로 천단위 구분 ㄱㄴ
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number); //배열에 데이터가 있는 만큼 반복
            //}

            //char[] c = { 'a', 'b', 'c', 'd' };
            //Console.WriteLine(c.Length); //배열의 요소 갯수 = 4

            //Console.WriteLine($ "{3.141592:0.00}"); //소수점 2째 자리까지 표현 = 3.14

            //int[] student = new int[1];
            //student[0] = Convert.ToInt32(Console.ReadLine());
            //student[1] = Convert.ToInt32(Console.ReadLine()); //이런식으로 배열에 입력을 받을 수 있다.

            //예제
            //decimal[] arr = { 10.5M, 20.1M, 30.2M };
            //decimal sum = 0.0M;
            //foreach (decimal d in arr)
            //{
            //    sum += d;
            //}
            //Console.WriteLine(sum);

            //2차원배열
            //int[,] arr = new int[2, 2] { { 1,2},{ 3,4} }; //2차원배열 선언, 초기화
            //예제
            //int[,] score = {
            //    {90,100,0,0 },
            //    {80,90,0,0 },
            //    { 100,80,0,0 }
            //};
            //for (int i = 0; i < 3; i++)
            //{
            //    score[i, 2] = score[i, 0] + score[i, 1]; //합계
            //    score[i, 3] = score[i, 2] / 2;
            //}
            //Console.WriteLine("국어 영어 합계 평균");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{score[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}

            //string[,,] names = new string[2, 2, 2]; //3차원 배열 선언, 층,행,열 순임
            //배열명.Rank //배열의 차수를 반환
            //변수명.GetLength(n); //n=0=층, 1=헹, 2=열

            //함수(메서드) 
            //static void 함수이름(){ } //으로 생성


        }
    }
}
