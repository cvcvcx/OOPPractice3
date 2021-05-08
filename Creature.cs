using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice3
{
    enum CreatureType
    {
        None,
        Player,
        Monster
    }
    class Creature
    {

        protected Creature(CreatureType type){ }

        protected int hp = 0;
        protected int attack = 0;

        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        public bool IsDead() { return hp <= 0; }

        public void OnDamage(int damage)
        {
            this.hp -= damage;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

    }
}
