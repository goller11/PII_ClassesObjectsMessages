using System;

namespace Metods {

    public class Character {

        public void Attack (Character enemy) {
            enemy.Life -= this.Damage;
        }

        public bool Health () {
            return (this.Life > 0);
        }

        public string Nickname { get; set; }
        public int Life { get; set; }
        public int Damage { get; set; }
        public string Power { get; set; }
        
        public Character (string nickname, int life, int damage, string power) {
            this.Nickname = nickname;
            this.Life = life;
            this.Damage = damage;
            this.Power = power;
        }

    }
}