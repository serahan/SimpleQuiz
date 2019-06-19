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

        public void func2()
        {
            // ######## Quiz 2번 #######
            // 400만을 초과하지 않는 값 중에 짝수 수열의 합

            int sum = 0;
            int index = 1;

            while (Pib(index) < 4000000)
            {
                if (index % 2 == 0)
                {
                    sum += Pib(index);
                }
                index++;
            }

            Console.WriteLine(sum);
        }

        public int Pib(int a)  // func2()
        {
            if(a == 1)
            {
                return 1;
            }
            else if(a==2)
            {
                return 2;
            }
            else
            {
                return Pib(a - 2) + Pib(a - 1);
            }
        }

        public void func3()
        {
            long number = 600851475143;
            int max = 0;

            for(int i=2;i<=number;i++)
            {
                if(number%i==0)
                {
                    if(i>max)
                    {
                        number = number / i;
                        max = i;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
