using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleQuiz
{
    class Quiz_1
    {
        public void func1()
        {
            // ######## Quiz 1번 #######
            // 3과 5의 배수 숫자의 합 구하기

            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"1~1000 사이의 3과 5의 배수 합 : {sum}");
        }
    }
}
