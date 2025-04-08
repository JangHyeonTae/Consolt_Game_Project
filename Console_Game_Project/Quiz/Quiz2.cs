using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz2 : QuizClass
    {
        MainQuiz mainQuiz;

        private int answer;
        private int question;
        public Quiz2() : base("문제2")
        {
        }
        public override void Render()
        {
            Game.PrintPlayerHP();
            Console.WriteLine("*****************************************");
            Console.WriteLine("******** 숫자야구 ************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();


            int[] comRand = new int[4];                                //플레이어, 컴퓨터 배열 선언
            int[] playerNum = new int[4];                              //플레이어, 컴퓨터 배열 선언

            Random rand = new Random();

            int cnt = 0;                                               //몇번 시도 했는지

            int strike = 0;                                            //스트라이크 초기화
            int ball = 0;                                              //ball초기화

            for (int i = 0; i < comRand.Length; i++)                   //comRand배열 랜덤 값넣기
            {
                comRand[i] = rand.Next(1, 10);
            }

            for (int i = 0; i < comRand.Length; i++)                    //랜덤의 숫자 중복제거
            {
                for (int j = 0; j < comRand.Length; j++)
                {
                    if (i != j && comRand[i] == comRand[j])
                    {
                        comRand[j] = rand.Next(1, 10);
                        j = 0;
                    }
                }
            }

            while (cnt < 10)                                           //시도 횟수 10회보다 작을경우에만 while문 실행
            {
                foreach (int num in comRand)
                {
                    Console.Write(num + " ");
                }

                cnt++;

                Console.WriteLine("========={0} 번째 기회 ============", cnt);
                Console.Write("숫자를 입력하세요 : ");

                string playerString = Console.ReadLine();                      //플레이어 시도시 적을 숫자
                int playerInt;                                                 //
                bool isTrue = int.TryParse(playerString, out playerInt);       //TryParse로 string -> int 변형

                Game.Player.TakeDamage(10);

                if (isTrue)                                                    //TryParse가 true일경우 if문 실행
                {
                    for (int i = playerNum.Length - 1; i >= 0; i--)            //playerNum의 각 자리마다 값을 나눠서 playerNum에 대입
                    {
                        playerNum[i] = playerInt % 10;
                        playerInt /= 10;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");                      //TryParse가 false일 경우 출력
                }

                for (int i = 0; i < comRand.Length; i++)
                {
                    if (playerNum[i] == comRand[i])                              //playerNum 과 comRand가 같은 
                    {                                                            //숫자 같은 자리일경우 strike가 하나 올라감
                        strike++;
                    }
                }

                for (int i = 0; i < comRand.Length; i++)
                {                                                                //playerNum 과 comRand가 같은 숫자
                    for (int j = 0; j < playerNum.Length; j++)                   //다른 자리일경우 ball이 하나 올라감
                    {
                        if (i != j && playerNum[i] == comRand[j])
                        {
                            ball++;
                        }

                    }
                }
                Console.WriteLine("Strike : {0}  Ball : {1}", strike, ball);
                Console.WriteLine();
                Console.WriteLine();
                if (strike == 4)
                {
                    Console.WriteLine("홈럽~~~~");
                    Exit();
                    break;
                }
                else if (cnt > 10)
                {
                    Console.WriteLine("땡! ");
                    break;
                }
                strike -= strike;                                                 //다음 입력을 위해 strike 와
                ball -= ball;                                                     //ball 0으로 만들기

            }
        }

        public override void Input()
        {
            string a = Console.ReadLine();
            int.TryParse(a, out answer);
        }
        public override void Update()
        {
            Render();
            
        }

        public override void Exit()
        {
            if (answer == question)
            {
                mainQuiz.Finish();
            }
        }
    }
}
