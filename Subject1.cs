﻿using System;

namespace ConsoleApp1
{
   
        internal class Program
        {
            private static Character player;

            static void Main(string[] args)
            {
                GameDataSetting();
                DisplayGameIntro();
            }

            static void GameDataSetting()
            {
                // 캐릭터 정보 세팅
                player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

                // 아이템 정보 세팅
            }

            static void DisplayGameIntro()
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");

                int input = int.Parse(Console.ReadLine()); 
                switch (input)
                {
                    case 1:
                        DisplayMyInfo();
                        break;

                    case 2:
                        DisplayInventory();
                        break;

                    default :
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }

            static void DisplayMyInfo()
            {
                Console.Clear();

                Console.WriteLine("상태보기");
                Console.WriteLine("캐릭터의 정보를 표시합니다.");
                Console.WriteLine();
                Console.WriteLine($"Lv.{player.Level}");
                Console.WriteLine($"{player.Name}({player.Job})");
                Console.WriteLine($"공격력 :{player.Atk}");
                Console.WriteLine($"방어력 : {player.Def}");
                Console.WriteLine($"체력 : {player.Hp}");
                Console.WriteLine($"Gold : {player.Gold} G");
                Console.WriteLine();
                Console.WriteLine("1. 인벤토리");
                Console.WriteLine("0. 나가기");

                int input = int.Parse(Console.ReadLine()) ;
                switch (input)
                {
                    case 1:
                    DisplayInventory();
                    break;

                    case 0:
                        DisplayGameIntro();
                        break;

                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }
            }

            static void DisplayInventory()
            {
                Console.Clear();

                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine($"[아이템 목록]");
                Console.WriteLine($"무쇠갑옷 \t \\방어력 + 5 || 무쇠로 만들어져 튼튼한 갑옷입니다.");
                Console.WriteLine($"낡은 검 \t \\ 공격력 +2 || 쉽게 볼 수 있는 낡은 검입니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("0. 나가기");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                    DisplayMyInfo();
                        break;
                
                    case 0:
                        DisplayGameIntro();
                        break;

                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }
        }


        public class Character
        {
            public string Name { get; }
            public string Job { get; }
            public int Level { get; }
            public int Atk { get; }
            public int Def { get; }
            public int Hp { get; }
            public int Gold { get; }

            public Character(string name, string job, int level, int atk, int def, int hp, int gold)
            {
                Name = name;
                Job = job;
                Level = level;
                Atk = atk;
                Def = def;
                Hp = hp;
                Gold = gold;
            }
        }

    }

}