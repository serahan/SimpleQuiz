﻿using System;

namespace SimpleQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ########## 7번문제 ##########
            // 1부터 5까지의 숫자를 영어로 쓰면 one, two, three, four, five 이고,
            // 각 단어의 길이를 더하면 3 + 3 + 5 + 4 + 4 = 19 이므로 사용된 글자는 모두 19개입니다.
            // 1부터 1,000까지 영어로 썼을 때는 모두 몇 개의 글자를 사용해야 할까요?

            Quiz_1 quiz = new Quiz_1();
            //quiz.func1();
            //quiz.func2();
            //quiz.func3();
            //quiz.func4();
            //quiz.func5();
            //quiz.func6();
            quiz.func7();
        }
    }
}
