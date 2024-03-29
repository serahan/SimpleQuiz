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
            // 4613732

            int sum = 0;
            int index = 1;

            while (Pib(index) < 4000000)
            {
                if (Pib(index) % 2 == 0)
                {
                    sum += Pib(index);
                }
                index++;
            }

            Console.WriteLine(sum);
        }

        public int Pib(int a)  // func2()
        {
            if (a == 1)
            {
                return 1;
            }
            else if (a == 2)
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

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (i > max)
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

            for (int i = 2; i < 20; i++)
            {
                number = i;
                for (int j = 0; j < factors.Length; j++)
                {
                    if (number == 1)
                    {
                        break;
                    }
                    if (number % factors[j] == 0)
                    {
                        amounts[j]++;
                        number = number / factors[j];
                        j = -1;
                    }
                }

                for (int j = 0; j < factors.Length; j++)
                {
                    if (amounts[j] > comp[j])
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
                for (int j = 0; j < comp[i]; j++)
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

            for (int i = 1; index < 10001; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    index++;
                    Console.WriteLine($"{index}번째 소수 : {i}");
                }
                count = 0;
            }
        }

        public void func6()
        {
            // ########## 6번문제 ##########
            // 20×20 격자에서 연속된 네 숫자의 곱 중 최대값
            // 70600674

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
            int[] arr = new int[4];
            int sum = 1;

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
                        sum = arr[0] * arr[1] * arr[2] * arr[3];
                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }

            } // 수평


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((0 <= i) && (i <= 16))
                    {
                        arr[0] = map[i, j];
                        arr[1] = map[i + 1, j];
                        arr[2] = map[i + 2, j];
                        arr[3] = map[i + 3, j];
                        sum = arr[0] * arr[1] * arr[2] * arr[3];
                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((3 <= j) && (j <= 19) && (0 <= i) && (i <= 16))
                    {
                        arr[0] = map[i, j];
                        arr[1] = map[i + 1, j - 1];
                        arr[2] = map[i + 2, j - 2];
                        arr[3] = map[i + 3, j - 3];
                        sum = arr[0] * arr[1] * arr[2] * arr[3];
                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            }  // 아래 왼쪽

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((0 <= i) && (i <= 16) && (0 <= j) && (j <= 16))
                    {
                        arr[0] = map[i, j];
                        arr[1] = map[i + 1, j + 1];
                        arr[2] = map[i + 2, j + 2];
                        arr[3] = map[i + 3, j + 3];
                        sum = arr[0] * arr[1] * arr[2] * arr[3];
                        if (sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            }
            Console.WriteLine(max);
        }

        public void func7()
        {
            // ########## 7번문제 ##########
            // 1부터 5까지의 숫자를 영어로 쓰면 one, two, three, four, five 이고,
            // 각 단어의 길이를 더하면 3 + 3 + 5 + 4 + 4 = 19 이므로 사용된 글자는 모두 19개입니다.
            // 1부터 1,000까지 영어로 썼을 때는 모두 몇 개의 글자를 사용해야 할까요?
            // 21124

            String[] one_to_nine = { "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine" }; // 1 ~ 9
            String[] eleven_to_nineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            String[] ten_to_ninety = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int sum = 0;
            int index = 1;
            int ten_number = 0;

            for (int i = 1; index <= 1000; i++)
            {
                if ((1 <= index) && (index <= 9))
                {
                    sum += one_to_nine[index - 1].Length;
                    //Console.Write($"{one_to_nine[index - 1]} ");
                }
                else if ((10 <= index) && (index <= 99))
                {
                    if ((11 <= index) && (index <= 19))
                    {
                        sum += eleven_to_nineteen[(index - 10) - 1].Length;
                        //Console.Write($"{eleven_to_nineteen[(index - 10) - 1]} ");
                    }
                    else if (index % 10 == 0)
                    {
                        ten_number = index / 10;
                        sum += ten_to_ninety[ten_number - 1].Length;
                        //Console.Write($"{ten_to_ninety[ten_number - 1]} ");
                    }
                    else
                    {
                        ten_number = index / 10;
                        sum += ten_to_ninety[ten_number - 1].Length;
                        //Console.Write($"{ten_to_ninety[ten_number - 1]} ");
                        sum += one_to_nine[index - (ten_number * 10) - 1].Length;
                        //Console.Write($"{one_to_nine[index - (ten_number * 10) - 1]} ");
                    }
                }
                else if ((100 <= index) && (index <= 999))
                {
                    if (index % 100 == 0) // 100의 배수 = 10의자리 1의자리 X
                    {
                        sum += one_to_nine[(index / 100) - 1].Length;
                        sum += "hundred".Length;

                        //Console.Write($"{one_to_nine[(index / 100) - 1]} ");
                        //Console.Write("hundred ");
                    }
                    else if (index % 10 == 0) // 10의 배수 = 1의 자리 X
                    {
                        ten_number = (index - (index / 100) * 100) / 10; // 십의자리

                        sum += one_to_nine[(index / 100) - 1].Length;
                        sum += "hundred".Length;
                        sum += "and".Length;

                        sum += ten_to_ninety[ten_number - 1].Length;

                        //Console.Write($"{one_to_nine[(index / 100) - 1]} ");
                        //Console.Write("hundred and ");
                        //Console.Write($"{ten_to_ninety[ten_number - 1]} ");
                    }
                    else if ((11 <= index % 100) && (index % 100 <= 19))
                    {
                        ten_number = index % 100;

                        sum += one_to_nine[(index / 100) - 1].Length;
                        sum += "hundred".Length;
                        sum += "and".Length;

                        //Console.Write($"{one_to_nine[(index / 100) - 1]} ");
                        //Console.Write("hundred and ");

                        sum += eleven_to_nineteen[(index - (ten_number / 10) * 10) % 10 - 1].Length;

                        //Console.Write($"{eleven_to_nineteen[(index - (ten_number / 10) * 10) % 10 - 1]} ");
                    }
                    else
                    {
                        ten_number = (index - (index / 100) * 100) / 10; // 십의자리

                        sum += one_to_nine[(index / 100) - 1].Length;
                        sum += "hundred".Length;
                        sum += "and".Length;

                        //Console.Write($"{one_to_nine[(index / 100) - 1]} ");
                        //Console.Write("hundred and ");

                        if (ten_number != 0)// 십의자리 0일때
                        {
                            sum += ten_to_ninety[ten_number - 1].Length;
                            //Console.Write($"{ten_to_ninety[ten_number - 1]} ");
                        }

                        ten_number = index % 10;
                        sum += one_to_nine[ten_number - 1].Length;

                        //Console.Write($"{one_to_nine[ten_number - 1]} ");
                    }
                }
                else if (index == 1000)
                {
                    sum += "one".Length;
                    sum += "thousand".Length;
                    //Console.Write("one thousand ");
                }
                //Console.Write($"{index} ");
                //Console.WriteLine($" {sum} ");
                index++;
            }
            Console.WriteLine($"{sum}");
        }

        public void func8()
        {
            // ########## 8번문제 ##########
            // 다음은 달력에 관한 몇 가지 일반적인 정보입니다(필요한 경우 좀 더 연구를 해 보셔도 좋습니다).
            // 1900년 1월 1일은 월요일이다.
            // 4월, 6월, 9월, 11월은 30일까지 있고, 1월, 3월, 5월, 7월, 8월, 10월, 12월은 31일까지 있다.
            // 2월은 28일이지만, 윤년에는 29일까지 있다.
            // 윤년은 연도를 4로 나누어 떨어지는 해를 말한다.
            // 하지만 400으로 나누어 떨어지지 않는 매 100년째는 윤년이 아니며, 400으로 나누어 떨어지면 윤년이다
            // 20세기(1901년 1월 1일 ~2000년 12월 31일) 에서, 매월 1일이 일요일인 경우는 총 몇 번입니까?

            int[] thirty_days = { 4, 6, 9, 11 }; // 30일까지
            int[] thirty_one_days = { 1, 3, 5, 7, 8, 10, 12 }; // 31일까지
            int[,] calendar = new int[6, 7]; // 일 월 화 수 목 금 토

            int year = 1901;
            int month = 1;
            int day = 1;

            int last_day = 1;  // 마지막 요일을 저장. => 다음 달 넘어갈때 배열 첫번째 행으로 이동해서 그 다음날부터 1일.
            int index = 1;  // 
            int count = 0;
            int SundayCount = 0;

            while ((year != 2001) || (month != 1) || (day != 1))
            {
                Console.WriteLine($"####{year}년 {month}월 #####");
                Console.WriteLine("일 월 화 수 목 금 토");
                // 하지만 400으로 나누어 떨어지지 않는 매 100년째는 윤년이 아니며, 400으로 나누어 떨어지면 윤년이다
                if (year % 400 != 0)
                {
                    //leap_year = year / 400
                    count++;
                }

                if (year == 1920)
                {
                    Console.WriteLine("");
                }
                if (last_day == 0)
                {
                    SundayCount++;
                }
                // 29일까지 있는 월인 경우 윤년 (연도를 4로 나누어 떨어지는 해)
                if ((year % 4 == 0) || (count % 100 == 0))
                {
                    if (month == 2)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (index <= 29)
                                {
                                    if (last_day > 0)
                                    {
                                        Console.Write("  ");
                                        last_day--;
                                    }
                                    else
                                    {
                                        calendar[i, j] = index;
                                        if ((0 <= calendar[i, j]) && (calendar[i, j] <= 9))
                                        {
                                            Console.Write($"0{calendar[i, j]} ");
                                        }
                                        else
                                        {
                                            Console.Write($"{calendar[i, j]} ");
                                        }
                                        index++;
                                    }
                                }
                                if (index == 30)
                                {
                                    last_day = j;
                                    i = 6;
                                    j = 7;
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                }
                else if (month == 2) // 28일까지 있는 월인 경우
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (index <= 28)
                            {
                                if (last_day > 0)
                                {
                                    Console.Write("   ");
                                    last_day--;
                                }
                                else
                                {
                                    calendar[i, j] = index;
                                    if ((0 <= calendar[i, j]) && (calendar[i, j] <= 9))
                                    {
                                        Console.Write($"0{calendar[i, j]} ");
                                    }
                                    else
                                    {
                                        Console.Write($"{calendar[i, j]} ");
                                    }
                                    index++;
                                }
                            }
                            if (index == 29)
                            {
                                last_day = j;
                                i = 6;
                                j = 7;
                            }
                        }
                        Console.WriteLine("");
                    }
                }

                // 30일까지 있는 월인 경우
                for (int k = 0; k < thirty_days.Length; k++)
                {
                    if (month == thirty_days[k])
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (index <= 30)
                                {
                                    if (last_day > 0)
                                    {
                                        Console.Write("   ");
                                        last_day--;
                                    }
                                    else
                                    {
                                        calendar[i, j] = index;
                                        if ((0 <= calendar[i, j]) && (calendar[i, j] <= 9))
                                        {
                                            Console.Write($"0{calendar[i, j]} ");
                                        }
                                        else
                                        {
                                            Console.Write($"{calendar[i, j]} ");
                                        }
                                        index++;
                                    }
                                }
                                if (index == 31)
                                {
                                    last_day = j;
                                    i = 6;
                                    j = 7;
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                }

                // 31일까지 있는 월인 경우
                for (int k = 0; k < thirty_one_days.Length; k++)
                {
                    if (month == thirty_one_days[k])
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (index <= 31)
                                {
                                    if (last_day > 0)
                                    {
                                        Console.Write("   ");
                                        last_day--;
                                    }
                                    else
                                    {
                                        calendar[i, j] = index;
                                        if ((0 <= calendar[i, j]) && (calendar[i, j] <= 9))
                                        {
                                            Console.Write($"0{calendar[i, j]} ");
                                        }
                                        else
                                        {
                                            Console.Write($"{calendar[i, j]} ");
                                        } // cw tab 2번
                                        index++;
                                    }
                                }
                                if (index == 32)
                                {
                                    last_day = j;
                                    i = 6;
                                    j = 7;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                }
                index = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            Console.WriteLine($"{SundayCount} ");
        }

        public void func9()
        {
            // n! 이라는 표기법은 n × (n − 1) × ... × 3 × 2 × 1을 뜻합니다.
            // 예를 들자면 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800 이 되는데,
            // 여기서 10!의 각 자리수를 더해 보면 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27 입니다.
            // 100! 의 자리수를 모두 더하면 얼마입니까?

            int[] factorialValue = new int[160];
            int[] CopyValue = new int[160];
            int top = 1;

            // #################################
            // 배열 30개짜리 만들어서 한 자릿수씩 배열에 입력하는건 어떨까

            // 초기 설정
            factorialValue[0] = 1;

            for (int index = 2; index <= 100; index++) // 팩토리얼 값 더하기
            {
                top = CalculateFactorial2(factorialValue, CopyValue, index, top);
            }
        }

        public int CalculateFactorial2(int[] factorialValue, int[] CopyValue, int index, int top)
        {
            int doubleValue = 0;
            int fakeTop = top;

            for (int i = 0; i < fakeTop; i++)
            {
                doubleValue = factorialValue[i] * index;

                if (doubleValue + CopyValue[i] < 10)
                {
                    CopyValue[i] += doubleValue;
                }
                else if (doubleValue == 10)
                {
                    top = AddValue2(CopyValue, doubleValue, i, top); // 10의 자리 올려주고
                    // CopyValue[i] = 0;                             // 나머지 0
                }
                else if (doubleValue > 10)
                {
                    top = AddValue2(CopyValue, doubleValue, i, top); // 10의 자리 올려주고
                    // CopyValue[i] = doubleValue % 10;              // 10으로 나눈 나머지                                                                 
                }

                AllCheck(CopyValue, top);
            }

            Copy(CopyValue, factorialValue, top);
            MakeZero2(CopyValue);

            return top;
        }

        public int AddValue2(int[] CopyValue, int doubleValue, int num, int top)
        {
            CopyValue[num] += doubleValue % 10;

            if (doubleValue - CopyValue[num] >= 10)  // 올림이 있을 경우
            {
                CopyValue[num + 1] += (doubleValue / 10);  // 올림수만큼 올려주고
                // CopyValue[num] = CopyValue[num] % 10;       // 남은 부분 남겨주기
            }
            else if(doubleValue - CopyValue[num] == 10)
            {
                CopyValue[num + 1] += CopyValue[num] / 10;  // 올림수만큼 올려주고
                CopyValue[num] = 0;                         // 0
            }

            // top 설정 문제
            if (num + 1 >= top)
            {
                top = num + 2;
            }

            return top;
        }

        public void AllCheck(int[] CopyValue, int top)
        {
            for (int i = 0; i < top; i++)
            {
                if (CopyValue[i] >= 10)
                {
                    CopyValue[i + 1] += CopyValue[i] / 10;
                    CopyValue[i] = CopyValue[i] % 10;
                }
            }
        }

        public void Copy(int[] CopyValue, int[] factorialValue, int top)
        {
            for (int i = 0; i < top; i++)
            {
                factorialValue[i] = CopyValue[i];
            }
        }

        public void MakeZero2(int[] CopyValue)
        {
            for(int i=0;i<160;i++)
            {
                CopyValue[i] = 0;
            }
        }

        public int CalculateFactorial(int[] factorialValue, int[] CopyValue,int index, int top)
        {
            int doubleValue = 0;
            int fakeTop = top;
            int fakenum = 0;
            for (int num = 0; num < fakeTop; num++)
            {
                doubleValue = factorialValue[num] * index;
                if((CopyValue[num]+doubleValue) < 10)
                {
                    CopyValue[num] += doubleValue;
                }
                else if ((CopyValue[num] + doubleValue) >= 10)
                {
                    fakenum = AddValue(CopyValue, num, doubleValue, index);
                    if(fakenum>top)
                    {
                        top = fakenum+1;
                    }
                    for(int i=num+1;i>=top;)
                    {
                        top++;
                    }
                }
            }
            MakeCopyValue(CopyValue, factorialValue, top);
            MakeZero(CopyValue, top);
            return top;
        }

        public int AddValue(int[] CopyValue, int num, int doubleValue, int index)
        {
            CopyValue[num] += doubleValue % 10;

            if (CopyValue[num] >= 10)
            {
                CopyValue[num + 1] += CopyValue[num] / 10;
                CopyValue[num] = CopyValue[num] % 10;
            }
            // 기존 10의 자리 + 올라온 10의 자리 합이 10보다 클 때
            if ((CopyValue[num + 1] + (doubleValue / 10)) > 10)
            {
                CopyValue[num + 2] += (CopyValue[num + 1] + (doubleValue / 10)) / 10;
                if ((CopyValue[num+1] + (CopyValue[num] + doubleValue - ((doubleValue / 100) * 100) - doubleValue % 10) / 10) == 10)
                {
                    CopyValue[num + 1] = 0;
                }
                else if (((CopyValue[num] + doubleValue - ((doubleValue / 100) * 100) - doubleValue % 10) / 10) < 10)
                {
                    CopyValue[num + 1] += (CopyValue[num] + doubleValue - ((doubleValue / 100) * 100) - doubleValue % 10) / 10;
                }
                return num + 2;
            }
            else if ((CopyValue[num + 1] + (doubleValue / 10)) == 10)
            {
                CopyValue[num + 2] += (CopyValue[num + 1] + (doubleValue / 10)) / 10;
                CopyValue[num + 1] = 0;
                return num + 2;
            }
            else if ((CopyValue[num + 1] + (doubleValue / 10)) < 10)
            {
                CopyValue[num + 1] = (CopyValue[num + 1] + (doubleValue / 10));
                return num + 1;
            }
            else
            {
                return num;
            }
        }

        public void MakeCopyValue(int[] CopyValue, int[] factorialValue, int top)
        {
            for(int num=0;num<top;num++)
            {
                factorialValue[num] = CopyValue[num];
            }
        }

        public void MakeZero(int[] CopyValue, int top)
        {
            for(int i=0;i<top;i++)
            {
                CopyValue[i] = 0;
            }
        }
    }
}