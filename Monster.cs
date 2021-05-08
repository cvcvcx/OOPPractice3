using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice3
{
    enum MonsterType
    {
        None,
        Slime,
        Orc,
        Skeleton
    }
    class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
        public MonsterType GetMonsterType() {return type; }
    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(20, 2);
        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(40, 4);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(30, 3);
        }
    }
}
    