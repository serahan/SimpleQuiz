﻿using System;
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

        public void func6()
        {
            int[,] map = new int[,] { { 08,02,22,97,38,15,00,40,00,75,04,05,07,78,52,12,50,77,91,08 },
                   { 49,49,99,40,17,81,18,57,60,87,17,40,98,43,69,48,04,56,62,00 },
                   { 81,49,31,73,55,79,14,29,93,71,40,67,53,88,30,03,49,13,36,65 },
                   { 52,70,95,23,04,60,11,42,69,24,68,56,01,32,56,71,37,02,36,91 },
                   { 22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80 },
                   { 24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50 },
                   { 32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70 },
                   { 67,26,20,68,02,62,12,20,95,63,94,39,63,08,40,91,66,49,94,21 },
                   { 24,55,58,05,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72 },
                   { 21,36,23,09,75,00,76,44,20,45,35,14,00,61,33,97,34,31,33,95 },
                   { 78,17,53,28,22,75,31,67,15,94,03,80,04,62,16,14,09,53,56,92 },
                   { 16,39,05,42,96,35,31,47,55,58,88,24,00,17,54,24,36,29,85,57 },
                   { 86,56,00,48,35,71,89,07,05,44,44,37,44,60,21,58,51,54,17,58 },
                   { 19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40 },
                   { 04,52,08,83,97,35,99,16,07,97,57,32,16,26,26,79,33,27,98,66 },
                   { 88,36,68,87,57,62,20,72,03,46,33,67,46,55,12,32,63,93,53,69 },
                   { 04,42,16,73,38,25,39,11,24,94,72,18,08,46,29,32,40,62,76,36 },
                   { 20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,04,36,16 },
                   { 20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54 },
                   { 01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48 }
            };
            int max = 0;
            int[] arr = new int[4]; // 나중에 버릴애
            int sum = 0;

            for (int i = 0; i < 20; i++) // 수평
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((0 <= j) && (j <= 16))
                    {
                        arr[0] = map[i, j];
                        arr[1] = map[i, j + 1];
                        arr[2] = map[i, j + 2];
                        arr[3] = map[i, j + 3];
                        sum = arr[0] + arr[1] + arr[2] + arr[3];
                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            } // 수평

            //for(int i=0;i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        if ((0 <= i) && (i <= 16))
            //        {
            //            arr[0] = map[i, j];
            //            arr[1] = map[i + 1, j];
            //            arr[2] = map[i + 2, j];
            //            arr[3] = map[i + 3, j];
            //            sum = arr[0] + arr[1] + arr[2] + arr[3];
            //            if(sum>max)
            //            {
            //                max = sum;
            //            }
            //        }
            //    }
            //}



            Console.WriteLine(max);
        }
    }
}