using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice3
{
    enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    class Game
    {
        Random rand = new Random();
        private GameMode mode = GameMode.Lobby;
        Player player = null;
        Monster monster = null;

        public void Process()
        {

            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;

            }
            
        }
        private void ProcessLobby()
        {
            Console.WriteLine("게임에 접속하였습니다.");
            Console.WriteLine("캐릭터를 생성하십시오");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1]필드로 간다.");
            Console.WriteLine("[2]로비로 돌아간다.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
                
            }
        }
        private void ProcessField()
        {
            Console.WriteLine("필드입장");
            CreateRandomMonster();
            
            FieldSelect();
            

        }
        private void FieldSelect()
        {
            Console.WriteLine("[1]싸운다.");
            Console.WriteLine("[2]일정 확률로 도망친다.");
            string input = null;
            while(input =="1"||input =="2")
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    int randValue = rand.Next(0, 101);
                    if (randValue < 33)
                        mode = GameMode.Town;
                    else
                    {
                        ProcessFight();
                    }
                    break;
          

            }
        }
        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamage(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은HP{player.GetHp()}");
                    break;
                }
                damage = monster.GetAttack();
                player.OnDamage(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("패배하였습니다.");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);
            switch (randValue)
            {
                case (int)MonsterType.Slime:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 나타났다!"); 
                    break;
                case (int)MonsterType.Orc:
                    monster = new Orc();
                    Console.WriteLine("오크가 나타났다!");
                    break;
                case (int)MonsterType.Skeleton:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 나타났다!");
                    break;
            }
        }
    }
}
