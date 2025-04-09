using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz2 : QuizClass
    {
        public Quiz2() : base("내가 운동 좀 치거든",false,false)
        {
            
        }
        public override void Render()
        {


            Console.WriteLine("*****************************************");
            Console.WriteLine("********        숫자야구         *********");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("규칙1 : 자리와 숫자가 맞으면 Strike!");
            Console.WriteLine("규칙2 : 자리는 다르지만 숫자만 맞으면 ball");
            Console.WriteLine("규칙3 : 다 틀릴경우 OUT!");
            Console.WriteLine("규칙4 : 4가지 숫자를 넣어 1~9까지 자리중 맞춰보세요!");
            Console.WriteLine("틀릴때마다 -10의 체력을 잃습니다!");
            Console.WriteLine("**Item을 입력하시면 인벤토리창에 들어갑니다**");
            Console.WriteLine();
            Console.WriteLine();
            


            int[] questionArr = new int[4];                           
            int[] answerArr = new int[4];                       

            Random rand = new Random();

            int cnt = 0;                                       

            int strike = 0;                                        
            int ball = 0;                                              

            for (int i = 0; i < questionArr.Length; i++)                   
            {
                questionArr[i] = rand.Next(1, 10);
            }

            for (int i = 0; i < questionArr.Length; i++)                   
            {
                for (int j = 0; j < questionArr.Length; j++)
                {
                    if (i != j && questionArr[i] == questionArr[j])
                    {
                        questionArr[j] = rand.Next(1, 10);
                        j = 0;
                    }
                }
            }
            
            while (Game.Player.CurHP > 0 && isGoal == false)                                          
            {
                Console.Clear();
                Game.PrintPlayerHP();
                foreach (int num in questionArr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                if (hint == true)
                {
                    Console.WriteLine($"힌트F : {questionArr[0]}");
                    Console.WriteLine($"힌트L : {questionArr[3]}");
                }
                cnt++;

                Console.WriteLine("========={0} 번째 기회 ============", cnt);
                Console.Write("숫자를 입력하세요 : ");

                string a= Console.ReadLine();
                
                int answer;                                                 
                bool isTrue = int.TryParse(a, out answer);
                string answerStr = answer.ToString();
                
                if (a == "Item")
                {
                    Game.Player.InventoryOpen();
                    cnt--;
                    Game.PrintPlayerHP();
                }

                if (isTrue)                                                    
                {
                    for (int i = answerArr.Length - 1; i >= 0; i--)            
                    {
                        answerArr[i] = answer % 10;
                        answer /= 10;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");                      
                }

                for (int i = 0; i < questionArr.Length; i++)
                {
                    if (answerArr[i] == questionArr[i])                            
                    {                                                           
                        strike++;
                    }
                }

                for (int i = 0; i < questionArr.Length; i++)
                {                                                              
                    for (int j = 0; j < answerArr.Length; j++)                  
                    {
                        if (i != j && answerArr[i] == questionArr[j])
                        {
                            ball++;
                        }

                    }
                }
                Console.WriteLine("Strike : {0}  Ball : {1}", strike, ball);
                Console.WriteLine();
                Console.WriteLine();
                
                if (strike == 4 || isGoal == true)
                {
                    Util.PressAnyKey("홈럽~~~~");
                    break;
                }
                
                strike -= strike;                                              
                ball -= ball;                                                  
                if (strike != 4 && a != "Item")
                {
                    Game.Player.TakeDamage(5);
                }
            }
        }

        public override void Update()
        {
            
            Render();
            
        }

        public override void Exit()
        {
            isGoal = true;
            hint = false; 
            Game.MainQuiz.Finish();
        }
    }
}
