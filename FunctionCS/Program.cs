﻿using System;

namespace FunctionCS
{
    class Program
    {
        /// <summary>
        /// 두 수를 더하여 그 결괏값을 반환시켜 주는 함수
        /// </summary>
        /// <param name="a">첫번째 매개변수</param>
        /// <param name="b">두번째 매개변수</param>
        /// <returns>a + b 결과</returns>
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = AddNumbers(3, 5);
            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}
