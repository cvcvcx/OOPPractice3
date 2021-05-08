using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice3
{
    enum PlayerType
    {
        None,
        Knight,
        Archer,
        Mage
    }
    class Player : Creature
    {
        protected PlayerType type = PlayerType.None;
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
    }
    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
