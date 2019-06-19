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

        public void func4()
        {
            // ######## Quiz 4번 #######
            // 2520은 1부터 10까지의 숫자로 모두 나눠지는 최소의 수입니다.
            // 1부터 20까지의 숫자로 모두 나눠지는 최소의 수를 구하세요
            // 232 792 560

            int[] factors = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] amounts = new int[factors.Length];
            int[] comp = new int[factors.Length];
            int number;

            for(int i=2;i<20;i++)
            {
                number = i;
                for (int j=0;j<factors.Length;j++)
                {
                    if (number==1)
                    {
                        break;
                    }
                    if(number%factors[j]==0)
                    {
                        amounts[j]++;
                        number = number / factors[j];
                        j = -1;
                    }
                }

                for(int j=0;j<factors.Length;j++)
                {
                    if(amounts[j]>comp[j])
                    {
                        comp[j] = amounts[j];
                        amounts[j] = 0;
                    }
                }
                for (int j = 0; j < factors.Length; j++)
                {
                    amounts[j] = 0;
                }
            }

            int sum = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                for(int j=0;j<comp[i];j++)
                {
                    sum *= factors[i];
                }
            }
            Console.WriteLine(sum);

        }

        public void func5()
        {
            // ######## Quiz 5번 #######
            // 10001번째 소수를 구하시오.
            // 104743

            int index = 0;
            int count = 0;

            for(int i=1;index<10001;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    index++;
                    Console.WriteLine($"{index}번째 소수 : {i}");
                }
                count = 0;
            }
        }
    }
}